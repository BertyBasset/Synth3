using Synth.Modules;
using Synth.Modules.Effects;


namespace Synth.Modules.Effects;
public class NullEffect : iEffect {
    public iModule Source { get; set; } = new NullModule();

    public double Value { get; set; }

    void iModule.Tick(double TimeIncrement) {
        Value = Source.Value;
    }
}

