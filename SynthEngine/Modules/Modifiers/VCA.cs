namespace Synth.Modules.Modifiers;

public class VCA : iModule {
    #region Public Properties
    public iModule? Source { get; set; }
    public iModule? Modulator { get; set; }
    #endregion

    #region iModule Members
    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {
        if (Source == null)
            Value = 0f;
        else {
            if (Modulator == null)
                Value = Source.Value;
            else
                Value = Source.Value * Modulator.Value;
        }
    }
    #endregion
}

