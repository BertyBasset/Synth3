namespace Synth.Modules;
internal class NullModule : iModule {
    public double Value { get; set; }

    void iModule.Tick(double TimeIncrement) {
        throw new NotImplementedException();
    }
}

