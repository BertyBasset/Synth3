
namespace Synth.Modules.Modifiers;
public class BitCrusher : iModule {
    #region Public Members
    public iModule Source { get; set; } = new NullModule();
    public double Resolution { get; set; }
    private double _samplerate;
    public double SampleRate {
        get { return _samplerate; }
        set
        {
            _samplerate = 1 - value;
            if (_samplerate < .01)
                _samplerate = 0.01;

        }
    }
    #endregion

    #region iModule Members
    public double Value { get; internal set; }

    double i = 0;

    public void Tick(double TimeIncrement) {
        if (++i > 1 / map(SampleRate)) {
            i -= 1 / map(SampleRate);

            if (Resolution != 0)
                Value = Math.Round(Source.Value / Resolution) * Resolution;
            else
                Value = Source.Value;
        }
    }
    #endregion

    #region Private Members
    double map(double num) {
        return (Math.Exp(2 * SampleRate) - 1) / (Math.E * Math.E - 1);
    }
    #endregion
}

