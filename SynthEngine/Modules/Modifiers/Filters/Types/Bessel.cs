namespace Synth.Modules.Modifiers.Filters.Types;

internal class Bessel : iFilter {
    #region Public Properties
    public iModule Source { get; set; } = new NullModule();
    public double Cutoff { get; set; }
    public iModule Modulator { get; set; } = new NullModule();
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

        double fc = VCF.GetCutoffFrequency(Cutoff, Modulator);     // This now centrallised

        double w0 = fc * 2 * Math.PI;
        double K = w0 / Math.Tan(w0 * timeIncrement / 2);

        double b0 = 0;
        double b1 = 0;
        double b2 = 3;
        double a0 = 1 / (w0 * w0);
        double a1 = 3 / w0;
        double a2 = 3;

        Value = (b0 * K * K + b1 * K + b2) / (a0 * K * K + a1 * K + a2) * Source.Value + (2 * b2 - 2 * b0 * K * K) / (a0 * K * K + a1 * K + a2) * prevIn + (b0 * K * K - b1 * K + b2) / (a0 * K * K + a1 * K + a2) * prevPrevIn - (2 * a2 - 2 * a0 * K * K) / (a0 * K * K + a1 * K + a2) * prevOut - (a0 * K * K - a1 * K + a2) / (a0 * K * K + a1 * K + a2) * prevPrevOut;
        prevPrevIn = prevIn;
        prevPrevOut = prevOut;
        prevIn = Source.Value;
        prevOut = Value;
    }

    public double Value { get; set; }
    #endregion

}
