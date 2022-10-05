namespace Synth.Modules.Sources.Generators;

internal class GeneratorSquare : iGenerator {
    #region Private Properties
    const double AMPLITUDE_NORMALISATION = .7f;
    #endregion

    #region IGenerator Members
    //                                                             Not Used
    double iGenerator.GenerateSample(double Phase, double Duty, double PhaseIncrement, bool IsZeroCrossing) {

        double sample;
        if (Phase > 360 * ((Duty + 1f) / 2f))
            sample = 1;
        else
            sample = 0;

        return sample * AMPLITUDE_NORMALISATION;
    }

    void iGenerator.Sync() {
        // Don't have Phase Accumulator(s), so do nothing
    }
    #endregion
}
