namespace Synth.Modules.Modifiers.Filters.Types;

public class Butterworth : iFilter {
    #region Public Properties
    public iModule Source { get; set; } = new NullModule();
    public double Cutoff { get; set; }
    public iModule Modulator { get; set; } = new NullModule();
    public double Resonance { get; set; }
    #endregion

    #region Private Properties
    double prevIn = 0;
    double prevPrevIn = 0;
    double prevOut = 0;
    double prevPrevOut = 0;
    #endregion

    #region iModule Member
    public void Tick(double timeIncrement) {
        if (Source == null)
            return;

        if (!double.IsFinite(prevOut) || Math.Abs(prevOut) > 1e2)
            prevOut = 0;
        if (!double.IsFinite(prevPrevOut) || Math.Abs(prevPrevOut) > 1e2)
            prevPrevOut = 0;

        double fc = VCF.GetCutoffFrequency(Cutoff, Modulator);     // This now centrallised


        double w0 = fc * 2 * Math.PI;
        double K = w0 / Math.Tan(w0 * timeIncrement / 2);

        double Q = Resonance + 2 * .025;

        double b0 = 0;
        double b1 = 0;
        double b2 = w0 * w0;
        double a0 = 1;
        double a1 = w0 / Q;
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
