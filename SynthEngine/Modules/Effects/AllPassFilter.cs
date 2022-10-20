using Synth.Modules;
using System.Threading;


namespace Synth.Modules.Effects;
public class AllPassFilter : iEffect {
    #region Public Members
    public iModule Source { get; set; } = new NullModule();
    public double Gain { get; set; }
    public double DelayLength { get; set; }
    #endregion

    #region iEffect Members
    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {
        if ((int)Math.Max(SynthEngine._SampleRate * DelayLength, 1) != inBuffer.Length) {
            var newInBuffer = new double[(int)Math.Max(SynthEngine._SampleRate * DelayLength, 1)];
            var newOutBuffer = new double[(int)Math.Max(SynthEngine._SampleRate * DelayLength, 1)];

            for (int j = 0; j < newInBuffer.Length; j++) {
                newInBuffer[j] = inBuffer[(int)((double)j / newInBuffer.Length * inBuffer.Length)];
                newOutBuffer[j] = inBuffer[(int)((double)j / newInBuffer.Length * inBuffer.Length)];
            }

            i = i * newInBuffer.Length / inBuffer.Length;
            inBuffer = newInBuffer;
            outBuffer = newOutBuffer;
        }

        Value = Gain * Source.Value+ inBuffer[i] - Gain * outBuffer[i];
        inBuffer[i] = Source.Value;
        outBuffer[i] = Value;
        ;
        i += 1;
        i %= inBuffer.Length;
    }
    double[] inBuffer = new double[1];
    double[] outBuffer = new double[1];
    int i = 0;
    #endregion
}

