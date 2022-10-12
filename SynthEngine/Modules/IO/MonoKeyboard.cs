using Synth.Modules;
using Synth.Properties;
using SynthEngine.Modules.IO;
using static SynthEngine.Modules.IO.Midi;

namespace Synth.IO;

// Keyboard and Frequency classes should be dealing with logarithmic digital
// equivalent of CV, however we've already gone down frequency route

public class Keyboard : iModule {
    private Midi midi = Midi.Instance;


    #region Public Events
    public event EventHandler? TriggerOn;
    public event EventHandler? TriggerOff;
    #endregion

    #region Private Variables
    // Used to implement Glide
    double _previousNoteFreq = 0;  // Previous Note       
    double _newNoteFreq;           // New Note 
    #endregion

    #region Constructor
    public Keyboard() {
        // init
        Value = Note.GetByDesc("C3").Frequency;     // Set default
        _previousNoteFreq = Value;
        _newNoteFreq = Value;

        midi.NoteChanged += Midi_NoteChanged;
        midi.KeyStateChanged += Midi_KeyStateChanged;
    }

    private void Midi_KeyStateChanged(object? sender, MidiKeyEventArgs e) {
        if (_midichannel == null || _midichannel == e.MidiChannelID) {
            if (e.KeyState == Midi.KeyState.Up) {
                KeyUp = true;
            } else {
                KeyDown = true;
            }
        }
    }

    private void Midi_NoteChanged(object? sender, MidiNoteEventArgs e) {
        if (_midichannel == null || _midichannel == e.MidiChannelID) 
            Note = e.Note;
    }
    #endregion

    #region Public Properties
    // This is primarilly for internal usage by synth modules
    public bool Gate { get; set; }

    // These two are write only as the 'real' keyboard manager will set them
    // They will then raise events that suscribers to the Keyboard can use
    // However, consider changing, esp if we go down C++ pico route
    public bool KeyUp { 
        set {
            Gate = false;
            TriggerOff?.Invoke(this, new EventArgs());
        }
    }
    public bool KeyDown {
        set {
            Gate = true;
            TriggerOn?.Invoke(this, new EventArgs());
        }
    }
    public double Glide { get;  set; } = 0;

    private Note _Note = new Note();
    public Note Note {
        get { return _Note; }
        set  {
            _Note = value;
            _newNoteFreq = _Note.Frequency;
        }
    }

    private int? _midichannel = 1;
    public int? MidiChannel {
        get { return _midichannel; }
        set {
            if (value < 1 || value > 16)
                throw new ArgumentOutOfRangeException("Midi Channel must be 1-16, or left as NULL");
            _midichannel = value; 
        }
    }

    #endregion

    #region iModule Members
    public double Value { get; internal set; } = 0;

    public void Tick(double interval) {
        // Shortcut, go straight to new note if glide is off
        if (Glide == 0) {
            Value = _newNoteFreq;
            return;
        }

        if (_previousNoteFreq != _newNoteFreq) {
            if (_previousNoteFreq < _newNoteFreq) {
                _previousNoteFreq += 1f/Glide;
                if (_previousNoteFreq > _newNoteFreq)       // Deals with overshoot !
                    _newNoteFreq = _previousNoteFreq;
            } else {
                _previousNoteFreq -= 1f/Glide;
                if (_previousNoteFreq < _newNoteFreq)
                    _newNoteFreq = _previousNoteFreq;       // Deals with undershoot !

            }
            Value = _previousNoteFreq;
        } else
            _previousNoteFreq = _newNoteFreq;
    }
    #endregion
}
