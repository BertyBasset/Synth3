namespace Synth.Modules;
internal class NullModule : iModule {
    public double Value => throw new NotImplementedException();

    void iModule.Tick(double TimeIncrement) {
        throw new NotImplementedException();
    }
}

