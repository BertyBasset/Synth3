namespace Synth.Modules.Sources.Generators;

internal class GeneratorNoise : iGenerator {
    #region Private Properties
    const double AMPLITUDE_NORMALISATION = .5;
    Random r = new Random();
    #endregion

    #region iGenerator Members
    //                                                             Not Used             not used
    double iGenerator.GenerateSample(double Phase, double Duty, double PhaseIncrement, bool IsZeroCrossing) {
        double sample = r.NextDouble() * 2.0 - 1.0;
        return sample * AMPLITUDE_NORMALISATION;
    }

    void iGenerator.Sync() {
        // Don't have Phase Accumulator(s), so do nothing
    }
    #endregion
}