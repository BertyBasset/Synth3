

namespace Synth.Modules.Sources;

public class Noise : iModule {
    const double AMPLITUDE_NORMALISATION = .5;
    public double Value {get;set;}

    Random r = new();
    void iModule.Tick(double TimeIncrement) {
        Value = (r.NextDouble() * 2 - 1)* AMPLITUDE_NORMALISATION;
    }
}

