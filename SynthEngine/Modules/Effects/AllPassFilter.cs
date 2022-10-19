using Synth.Modules;


namespace SynthEngine.Modules.Effects;
public class AllPassFilter : iModule {
    public double Gain { get; set; }
    public double Delay { get; set; }



    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {

    }
}

