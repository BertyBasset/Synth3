using Synth.Utils;

namespace Synth.Modules.Sources.Generators;

internal class GeneratorSine : iGenerator {
    #region Private Properties
    //                                                             Not Used
    // To prevent clicks, only apply changed Duty on a zero crossing
    double _newDuty;
    #endregion

    #region Public Properties
    double iGenerator.GenerateSample(double Phase, double Duty, double PhaseIncrement, bool IsZeroCrossing) {

        // Phase Distortion
        // For sine, instead of varying SQ duty cycle, we can do phase distortion a la Casio CZ100 !
        double phase = Phase;
        if (Duty != 0) {
            // If we've wrapped round 360 -> 0, we're safe to do Phase Distortion
            // Otherwise we get nasty glitches, especially with smooth waves like sines
            if (IsZeroCrossing)
                _newDuty = Duty;

            phase = PhaseDistortionTransferFunction.GetPhase(phase, _newDuty, this);

        }

        var sample = (float)Math.Sin(phase * Math.PI / 180f);
        return sample;
    }

    void iGenerator.Sync() {
        // Don't have Phase Accumulator(s), so do nothing
    }
    #endregion
}

