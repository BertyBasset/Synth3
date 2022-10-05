using Synth.Utils;

namespace Synth.Modules.Sources.Generators;

internal class GeneratorTriangle : iGenerator {
    #region Private Properties
    // To prevent clicks, only apply changed Duty on a zero crossing
    double _newDuty;
    #endregion

    #region iGenerator Members
    //                                                       Not Used                   Used
    double iGenerator.GenerateSample(double Phase, double Duty, double PhaseIncrement, bool IsZeroCrossing) {

        // Phase Distortion
        // For triangle, instead of varying SQ duty cycle, we can do phase distortion a la Casio CZ100 !
        double phase = Phase;
        if (Duty != 0) {
            // If we've wrapped round 360 -> 0, we're safe to do Phase Distortion
            if (IsZeroCrossing)
                _newDuty = Duty;

            phase = PhaseDistortionTransferFunction.GetPhase(phase, _newDuty, this);

        }

        var sample = phase / 180f - 1;               // Get Saw First
        sample = (Math.Abs(sample) - .5f) * 2f;      // Rectify and shift

        return sample;
    }

    void iGenerator.Sync() {
        // Don't have Phase Accumulator(s), so do nothing
    }
    #endregion
}


