namespace Synth.Modules;
internal class NullModule : iModule {
    public double Value {
        get { 
            return 0; 
        }
        set { 
            int a = 2;
        }
    
    }

    void iModule.Tick(double TimeIncrement) {
        throw new NotImplementedException();
    }
}

