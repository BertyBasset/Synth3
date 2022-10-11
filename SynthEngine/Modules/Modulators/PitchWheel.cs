
using Synth.Modules;
using SynthEngine.Modules.IO;
using System.Windows.Forms;

namespace SynthEngine.Modules.Modulators;
public class PitchWheel : iModule {
    private Midi midi = Midi.Instance;

    public PitchWheel() {
        midi.PitchWheelChanged += (o, CurrentValue) => 
        Value = ((CurrentValue - 8192f) / 4096 / 12) * MathF.Pow(2, 1 / 12);
    }

    public double Value{get; set;}

    public void Tick(double TimeIncrement) {
        // No need to do anything. Value gets set by Midi event
    }
}
