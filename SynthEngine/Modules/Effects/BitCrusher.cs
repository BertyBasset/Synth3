using Synth.Modules;

namespace SynthEngine.Modules.Effects;
public class BitCrusher : iModule {
    public double Resolution { get; set; }
    public double SampleRate { get; set; }



    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {
        
    }
}

