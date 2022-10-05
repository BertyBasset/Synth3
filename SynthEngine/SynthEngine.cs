using NAudio.Wave;
using Synth.IO;
using Synth.Modules;

namespace Synth;
public class SynthEngine : WaveProvider32 {
    #region Private Properties
    //private DirectSoundOut? waveOut;
    private NAudio.Wave.WaveOut? waveOut;

    // These config settings are injected into constructor by client application
    int _SampleRate;
    int _Channels;
    #endregion


    #region Stop/Start
    public void Start() {
        SetWaveFormat(_SampleRate, _Channels);

        waveOut = new();

        waveOut.DesiredLatency = 100;
        waveOut.NumberOfBuffers = 3;

        waveOut.Init(this);
        waveOut.Play();
    }


    #endregion

    #region Public Synth Properties
    public double Volume { get; set; } = 1.0;
    public List<iModule> Modules = new();

    #endregion

    #region Constructor
    public SynthEngine(double volume = 1.0) {
        _SampleRate = 16000;
        _Channels = 2;
        Volume = volume;

        Start();
    }
    #endregion

    #region Sound Generation loop
    // Looks like this is a callback function which gets called when NAudio needs more wave data
    public override int Read(float[] buffer, int offset, int sampleCount) {
        float timeIncrement = 1f / (float)_SampleRate;
        for (int n = 0; n < sampleCount; n++) {

            foreach (var m in Modules)
                m.Tick(timeIncrement);

            // Aggregate outputs from all AudioOut modules
            float wave = 0;
            foreach (var m in Modules.Where(m => m.GetType() == typeof(AudioOut)))
                wave += (float)m.Value;


            // Housekeeping - set final sample value with overall Volume
            double currentSample = (Volume * wave);
            buffer[n + offset] = (float)currentSample;
        }
        return sampleCount;
    }
    #endregion

}
