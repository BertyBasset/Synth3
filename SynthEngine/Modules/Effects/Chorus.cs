using Synth.Modules;

namespace Synth.Modules.Effects;
public class Chorus : iModule {

    public double MinDelay { get; set; }
    public double MaxDelay { get; set; }
    public double Frequency{ get; set; }
    public double Gain{ get; set; }



    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {

    }
}
