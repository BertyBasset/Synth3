using NAudio.Midi;
using Synth.Properties;
using System.Diagnostics;
using System.Threading;

namespace SynthEngine.Modules.IO;

internal class Midi {

    public enum KeyState {
        Up,
        Down
    }

    private MidiIn? MidiIn;

    public Note CurrentNote = Note.GetByDesc("C2");
    public KeyState CurrentKeyState = KeyState.Up;
    public int CurrentModWheel = 0;
    public int CurrentPitchWheel = 0;

    public event EventHandler? NoteChanged;
    public event EventHandler? KeyStateChanged;
    public event EventHandler? PitchWheelChanged;
    public event EventHandler? ModWheelChanged;



    // Convert to singleton so everything can share midi
    private static readonly Lazy<Midi> lazy =
        new Lazy<Midi>(() => new Midi());

    public static Midi Instance { get { return lazy.Value; } }

    private Midi() {
        if (MidiIn.NumberOfDevices > 0) {
            MidiIn = new MidiIn(0);
            MidiIn.MessageReceived += MidiMessage;
            MidiIn.ErrorReceived += ErrorReceived;
            MidiIn.Start();
        }
    }

    void _KeyStateChanged() {
        Debug.Assert(KeyStateChanged != null);
        KeyStateChanged?.Invoke(this, new EventArgs());
    }

    void _NoteChanged() {
        Debug.Assert(NoteChanged != null);
        NoteChanged?.Invoke(this, new EventArgs());
    }

    void _PitchWheelChanged() {
        PitchWheelChanged?.Invoke(this, new EventArgs());
    }

    void _ModWheelChanged() {
        ModWheelChanged?.Invoke(this, new EventArgs());
    }

    private void ErrorReceived(object? sender, MidiInMessageEventArgs e) {
        // DO NOTHING!
    }


    HashSet<string> PlayedNotes = new();
    void MidiMessage(object? sender, MidiInMessageEventArgs e) {
        switch (e.MidiEvent.CommandCode) {
            case MidiCommandCode.NoteOn:
                var n = (NoteEvent)e.MidiEvent;

                // Our Notes Go
                // ID       Name      Midi Note Num
                // 1        A0        21   
                // 2        A#0       22
                //
                //
                // 52       C5
                // Therefore subtract 20 from Midi Note Number

                CurrentNote = Note.GetByID(n.NoteNumber - 20);
                CurrentKeyState = KeyState.Down;
                PlayedNotes.Add(CurrentNote.Desc);
                _NoteChanged();
                _KeyStateChanged();
                break;

            case MidiCommandCode.NoteOff:
                
                // Only do key up if all notes released
                var releasedNote = Note.GetByID(((NoteEvent)e.MidiEvent).NoteNumber - 20);
                PlayedNotes.Remove(releasedNote.Desc);

                if (PlayedNotes.Count == 0) {
                    CurrentKeyState = KeyState.Up;
                    _KeyStateChanged();
                }
                break;

            case MidiCommandCode.PitchWheelChange:
                var p = (PitchWheelChangeEvent)e.MidiEvent;

                CurrentPitchWheel = p.Pitch;
                _PitchWheelChanged();
                break;

            case MidiCommandCode.ControlChange:
                var c = (ControlChangeEvent)e.MidiEvent;

                if (c.Controller == MidiController.Modulation) {
                    CurrentModWheel = c.ControllerValue;
                    _ModWheelChanged();
                }
                break;
        }
    }
}

