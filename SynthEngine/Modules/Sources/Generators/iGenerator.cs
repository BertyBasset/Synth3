namespace Synth.Modules.Sources.Generators;

// Generates a single audio sample using a mathematcial algorithm for a given Phase Angle
// Wave shape is determined by Frequency and Duty, (and a couple of other things for Fourier (Fourier Coeffs), Wavetable (.wav filename) and Supersaw (Saw Relative frequencies))
internal interface iGenerator {

    #region iGenerator Members
    // The Generator can either use Phase - the Phase Accumulator maintained by the Oscillator,
    // or it may chose to maintain it's own Phase Accumulator(s) by incrementing using phaseIncrement
    // Cases where this might be don is if the Generator needs to track the Phase Angles of separate harmonics
    //                            Degrees 0-360     0 - 1 (0-100% duty cycle)
    internal double GenerateSample(double Phase, double Duty, double phaseIncrement, bool IsZeroCrossing);

    internal void Sync();           // Reset Phase accumuators if Generator has it's own
    #endregion
}
