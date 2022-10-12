using Synth.Modules;
using SynthEngine.Modules.IO;

namespace SynthEngine.Modules.Modulators;

public class MidiControllers : iModule {
    public event EventHandler<MidiControllerEventArgs>? ControllerValueChanged;

    private Midi midi = Midi.Instance;

    public MidiControllers() {
        // MidiControllers 0 - 127
        midi.ControllerValueChanged += (o, e) => {
            if (_midichannel == null || _midichannel == e.MidiChannelID)
                ControllerValueChanged?.Invoke(this, e);
        };


        //    => Value = CurrentValue / 127f;
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

    public double Value { get; set; }

    public void Tick(double TimeIncrement) {
        // No need to do anything. Value gets set by Midi event
    }
}

