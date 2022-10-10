namespace Synth.Modules.Modifiers.Filters.Types;
internal class Notch : iFilter {
    #region Public Properties
    public iModule Source { get; set; } = new NullModule();
    public double Cutoff { get; set; }
    public iModule Modulator { get; set; } = new NullModule();
    public double Bandwidth;
    public double Attenuation;
    #endregion

    #region Private Properties
    double prevIn = 0;
    double prevPrevIn = 0;
    double prevOut = 0;
    double prevPrevOut = 0;
    #endregion

    #region iModule Members
    public void Tick(double timeIncrement) {
        if (Source == null)
            return;

        if (!double.IsFinite(Value))
            Value = 0;
        if (!double.IsFinite(prevOut))
            prevOut = 0;
        if (!double.IsFinite(prevPrevOut))
            prevPrevOut = 0;

        double fc = Math.Min(Math.Pow(2, 5 * Cutoff + 4 * (Modulator?.Value ?? 0) + 7), 5000);

        double w0 = fc * 2 * Math.PI;
        double K = w0 / Math.Tan(w0 * timeIncrement / 2);

        double b0 = 1;
        double b1 = Bandwidth * Attenuation * 2;
        double b2 = w0 * w0;
        double a0 = 1;
        double a1 = Bandwidth * 2;
        double a2 = w0 * w0;

        Value = (b0 * K * K + b1 * K + b2) / (a0 * K * K + a1 * K + a2) * Source.Value
                        + (2 * b2 - 2 * b0 * K * K) / (a0 * K * K + a1 * K + a2) * prevIn
                        + (b0 * K * K - b1 * K + b2) / (a0 * K * K + a1 * K + a2) * prevPrevIn
                        - (2 * a2 - 2 * a0 * K * K) / (a0 * K * K + a1 * K + a2) * prevOut
                        - (a0 * K * K - a1 * K + a2) / (a0 * K * K + a1 * K + a2) * prevPrevOut;

        prevPrevIn = prevIn;
        prevPrevOut = prevOut;
        prevIn = Source.Value;
        prevOut = Value;
    }

    public double Value { get; set; }
    #endregion
}



