namespace Synth.Modules.Sources.Generators;

internal class GeneratorSuperSaw : iGenerator {
    #region Private Properties    
    const double AMPLITUDE_NORMALISATION = .3f;
    private double[] _PhaseAccumulators = new double[7];
    #endregion

    #region Public Properties
    private double[] _FrequencyRatios = new double[7] { 0.987, 0.998, 0.999, 1.000, 1.001, 1.002, 1.003 };
    public double[] FrequencyRatios {
        get { return _FrequencyRatios; }
        set {
            _FrequencyRatios = value;

            // Need to setup as many Phase Accumulators as there are elements in the Coefficients Array
            _PhaseAccumulators = new double[_FrequencyRatios.Length];
        }
    }
    #endregion

    #region iGenerator Members
    //                                                                                  not used
    double iGenerator.GenerateSample(double Phase, double Duty, double PhaseIncrement, bool IsZeroCrossing) {
        // Advance each Phase accumulator by PhaseIncrement time RelativeFrequenices to give 7 wave detuned SuperSaw

        // Phase Distortion
        // Don't bother for Saw!!

        float sample = 0f;
        for (int i = 0; i < _PhaseAccumulators.Length; i++) {
            sample += (float)(_PhaseAccumulators[i] / 180f - 1);

            // Increment Phase Accumulators
            _PhaseAccumulators[i] += PhaseIncrement * _FrequencyRatios[i];
            _PhaseAccumulators[i] = _PhaseAccumulators[i] % 360.0;
        }

        if (sample > 5)
            sample = 5;
        if (sample < -5)
            sample = -5;

        return sample * AMPLITUDE_NORMALISATION;
    }

    void iGenerator.Sync() {
        for (int i = 0; i < _PhaseAccumulators.Length; i++)
            _PhaseAccumulators[i] = 0f;
    }
    #endregion
}

