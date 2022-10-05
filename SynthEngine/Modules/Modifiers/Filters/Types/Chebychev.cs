﻿using System.Numerics;

namespace Synth.Modules.Modifiers.Filters.Types;
internal class Chebyshev : iFilter {
    #region Public Properties
    public iModule Source { get; set; } = new NullModule();
    public double Cutoff { get; set; }
    public double CV { get; set; }
    public double RippleFactor;
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

        if (!double.IsFinite(prevOut) || Math.Abs(prevOut) > 1e2)
            prevOut = 0;
        if (!double.IsFinite(prevPrevOut) || Math.Abs(prevPrevOut) > 1e2)
            prevPrevOut = 0;

        double fc = Math.Min(Math.Pow(2, 5 * Cutoff + 4 * CV + 7), 20000);
        double w0 = fc * 2 * Math.PI;
        double K = w0 / Math.Tan(w0 * timeIncrement / 2);

        var e = RippleFactor * 5;

        var s = -Math.Sinh(Math.Asinh(1 / e));
        var c = Math.Cosh(Math.Asinh(1 / e));

        var p1 = new Complex(s * Math.Sqrt(2) / 2, c * Math.Sqrt(2) / 2);
        var p2 = new Complex(s * Math.Sqrt(2) / 2, c * -Math.Sqrt(2) / 2);

        double b0 = 0;
        double b1 = 0;
        double b2 = w0 * w0;
        double a0 = 2 * e;
        double a1 = -2 * e * w0 * (p1 + p2).Real;
        double a2 = 2 * e * w0 * w0 * (p1 * p2).Real;

        Value = 2.7 / 0.7 * (
            (b0 * K * K + b1 * K + b2) / (a0 * K * K + a1 * K + a2) * Source.Value
            + (2 * b2 - 2 * b0 * K * K) / (a0 * K * K + a1 * K + a2) * prevIn
            + (b0 * K * K - b1 * K + b2) / (a0 * K * K + a1 * K + a2) * prevPrevIn
            - (2 * a2 - 2 * a0 * K * K) / (a0 * K * K + a1 * K + a2) * prevOut
            - (a0 * K * K - a1 * K + a2) / (a0 * K * K + a1 * K + a2) * prevPrevOut);
        prevPrevIn = prevIn;
        prevPrevOut = prevOut;
        prevIn = Source.Value;
        prevOut = Value * 0.7 / 2.7;

    }

    public double Value { get; set; }
    #endregion
}
