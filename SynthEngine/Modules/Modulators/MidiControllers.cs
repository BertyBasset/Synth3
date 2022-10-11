using Synth.Modules;
using SynthEngine.Modules.IO;

namespace SynthEngine.Modules.Modulators;

public class MidiControllers : iModule {
    public event EventHandler<ControllerEventArgs>? ControllerValueChanged;

    private Midi midi = Midi.Instance;

    public MidiControllers() {
        // MidiControllers 0 - 127
        midi.ControllerValueChanged += (o, e) => {
            ControllerValueChanged?.Invoke(this, e);
        };


        //    => Value = CurrentValue / 127f;
    }

    public double Value { get; set; }

    public void Tick(double TimeIncrement) {
        // No need to do anything. Value gets set by Midi event
    }
}

