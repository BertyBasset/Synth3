using NAudio.Midi;
using Synth.Properties;
using System.Diagnostics;
using System.Threading;
using static SynthEngine.Modules.IO.Midi;

namespace SynthEngine.Modules.IO;

public class Midi {

    public enum KeyState {
        Up,
        Down
    }

    private MidiIn? MidiIn;

    public Note CurrentNote = Note.GetByDesc("C2");
    public KeyState CurrentKeyState = KeyState.Up;
    public int CurrentModWheel = 0;
    public int CurrentPitchWheel = 0;

    public event EventHandler<MidiNoteEventArgs>? NoteChanged;
    public event EventHandler<MidiKeyEventArgs>? KeyStateChanged;
    public event EventHandler<MidiWheelEventArgs>? PitchWheelChanged;
    public event EventHandler<MidiWheelEventArgs>? ModWheelChanged;
    public event EventHandler<MidiControllerEventArgs>? ControllerValueChanged;



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
                NoteChanged?.Invoke(this, new MidiNoteEventArgs(e.MidiEvent.Channel, CurrentNote));
                KeyStateChanged?.Invoke(this, new MidiKeyEventArgs(e.MidiEvent.Channel, CurrentKeyState));
                break;

            case MidiCommandCode.NoteOff:
                
                // Only do key up if all notes released
                var releasedNote = Note.GetByID(((NoteEvent)e.MidiEvent).NoteNumber - 20);
                PlayedNotes.Remove(releasedNote.Desc);

                if (PlayedNotes.Count == 0) {
                    CurrentKeyState = KeyState.Up;
                    KeyStateChanged?.Invoke(this, new MidiKeyEventArgs(e.MidiEvent.Channel, CurrentKeyState));
                }
                break;

            case MidiCommandCode.PitchWheelChange:
                var p = (PitchWheelChangeEvent)e.MidiEvent;

                CurrentPitchWheel = p.Pitch;
                PitchWheelChanged?.Invoke(this, new MidiWheelEventArgs(e.MidiEvent.Channel, CurrentPitchWheel));
                break;

            case MidiCommandCode.ControlChange:
                var c = (ControlChangeEvent)e.MidiEvent;

                if (c.Controller == MidiController.Modulation) {
                    CurrentModWheel = c.ControllerValue;
                    ModWheelChanged?.Invoke(this, new MidiWheelEventArgs(e.MidiEvent.Channel, CurrentModWheel));
                } else {
                    ControllerValueChanged?.Invoke(this, new MidiControllerEventArgs(e.MidiEvent.Channel, (int)c.Controller, c.ControllerValue));
                }
                break;
        }
    }
}

public class MidiControllerEventArgs {
    public MidiControllerEventArgs(int MidiChannelID, int ControllerID, int Value) {
        this.MidiChannelID = MidiChannelID;
        this.ControllerID = ControllerID;
        this.Value = Value;
    }

    public int MidiChannelID;
    public int ControllerID;
    public int Value;
}

public class MidiNoteEventArgs {
    public MidiNoteEventArgs(int MidiChannelID, Note Note) {
        this.MidiChannelID = MidiChannelID;
        this.Note = Note;
    }

    public int MidiChannelID;
    public Note Note;
}

public class MidiKeyEventArgs {
    public MidiKeyEventArgs(int MidiChannelID, KeyState KeyState) {
        this.MidiChannelID = MidiChannelID;
        this.KeyState = KeyState;
    }

    public int MidiChannelID;
    public KeyState KeyState;
}

public class MidiWheelEventArgs {
    public MidiWheelEventArgs(int MidiChannelID, int Value) {
        this.MidiChannelID = MidiChannelID;
        this.Value = Value;
    }

    public int MidiChannelID;
    public int Value;
}

