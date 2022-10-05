using Synth.Modules;
using SynthEngine.Modules.IO;

namespace SynthEngine.Modules.Modulators;

public class ModWheel : iModule {
    private Midi midi = Midi.Instance;

    public ModWheel() {
        // ModWheel 0 - 127
        midi.ModWheelChanged += (o, e) => Value = midi.CurrentModWheel / 127f;
    }

    public double Value { get; set; }

    public void Tick(double TimeIncrement) {
        // No need to do anything. Value gets set by Midi event
    }
}

