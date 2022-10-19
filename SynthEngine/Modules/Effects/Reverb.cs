
namespace Synth.Modules.Effects;
public class Reverb : iModule {

    public double Gain { get; set; }
    public double Delay { get; set; }


    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {

    }
}

