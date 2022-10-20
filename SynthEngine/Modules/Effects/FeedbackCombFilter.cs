using Synth.Modules;
using System.Threading;

namespace Synth.Modules.Effects;
public class FeedbackCombFilter : iEffect {
    #region Public Members
    public iModule Source { get; set; } = new NullModule();
    public double Gain { get; set; }
    public double DelayLength { get; set; }
    #endregion

    #region iEffect Members
    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {
        if ((int)Math.Max(SynthEngine._SampleRate * DelayLength, 1) != buffer.Length) {
            var newBuffer = new double[(int)Math.Max(SynthEngine._SampleRate * DelayLength, 1)];

            for (int j = 0; j < newBuffer.Length; j++)
                newBuffer[j] = buffer[(int)((double)j / newBuffer.Length * buffer.Length)];

            i = i * newBuffer.Length / buffer.Length;
            buffer = newBuffer;
        }

        Value = Source.Value + Gain * buffer[i];
        buffer[i] = Value;
        i += 1;
        i %= buffer.Length;
    }
    double[] buffer = new double[1];
    int i = 0;
    #endregion
}

