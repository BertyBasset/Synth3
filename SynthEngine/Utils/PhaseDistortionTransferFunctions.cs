using Synth.Modules.Sources.Generators;

namespace Synth.Utils;
internal struct Point {
    internal Point(double x, double y) {
        X = x;
        Y = y;
    }

    internal double X;
    internal double Y;
}


internal class PhaseDistortionTransferFunction {



    /*                                   |+1                         
        *                                   |                          / p3
        *                                   |                      /
        *                                   |                  /
        *                                   |              /
        *                                   |          /
        *                                   |      /
        *                                   |  /
        *                                   |    y = m2 x x + c2
        *                                /  |
        *             p2             /      |
        *         knee point     /          |
        *         moves      /              |
        *           <--   /  -->            |
        *  ----------------------------------------------------------------
        *  -1           / x intercept       |                            +1
        *              /  (Distortion       | 
        *             /                     |
        *            /                      |
        *           /                       |                                  
        *          /                        |
        *         /                         |
        *        /                          |
        *       /y= m1 x x + c1             |
        *      /                            |
        *     /                             |
        *    /                              |-1
        *     p1
        * */


    // We can of course have extra transfer functions, and even vary transfer function per quadrant


    // Do transfer function here after normalising input to between -1 and +1
    //     -1 to +1                    -1 to +1       -1 to + 1                     // We can use this so sine wave can use different transfer function
    private static double GetPhaseNominal(double Phase, double Distortion, iGenerator generator) {
        // Shortcircuit if no distortion
        if (Distortion == 0)
            return Phase;

        var p1 = new Point(-1f, -1f);
        // Which is better ?

        Point p2;
        if (generator.GetType() == typeof(GeneratorSine))
            p2 = new Point(Distortion, -Distortion);           // This better for distorting sine waves
        else
            p2 = new Point(Distortion, 0);                     // This better for distorting triangles and wavetable

        var p3 = new Point(1f, 1f);

        double m;
        double c;

        if (Phase < Distortion) {
            // We are on y = m1 x x + c1
            // (-1, -1) to (Distortion, 0)
            m = (p2.Y - p1.Y) / (p2.X - p1.X);
        } else {
            // We are on y = m2 x x +c2
            // (Distortion, 0) to (1, 1)
            m = (p3.Y - p2.Y) / (p3.X - p2.X);
        }
        c = p2.Y - m * p2.X;

        return m * Phase + c;
    }

    // Normalise values, call GetPhaseNominal transfer function, the de-normalise to 0-360°
    //           0 to 360       0 to 360     0 - 1,  0.5% = no distortion
    public static double GetPhase(double Phase, double Distortion, iGenerator generator) {
        double _Phase = Phase / 180f - 1f;
        double _distPhase = GetPhaseNominal(_Phase, Distortion, generator);
        return (_distPhase + 1f) * 180f;
    }
}

