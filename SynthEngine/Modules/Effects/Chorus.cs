
using System.Configuration;
using System.Threading;

namespace Synth.Modules.Effects;
public class Chorus : iEffect {
    public iModule Source { get; set; } = new NullModule();
    #region Public Members
    public Chorus() {
        buffer = new double[SynthEngine._SampleRate / 2];
    }
         
    private double _mindelay;
    public double MinDelay {
        get { return _mindelay * 8; }
        set {
            _mindelay = value / 8;
            if (_mindelay > .125)
                _mindelay = .125;
        }
    }

    private double _maxdelay;
    public double MaxDelay {
        get { return _maxdelay * 8; }
        set {
            _maxdelay = value / 8;
            if (_maxdelay > .125)
                _maxdelay = .125;
        }
    }

    private double _frequency;
    public double Frequency{
        get { return _frequency / 4; }
        set {
            _frequency = value *4;
            if (_frequency > 4)
                _frequency = 4;
        }
    }

    public double Gain{ get; set; }
    #endregion

    #region iEffect Members
    public double Value { get; internal set; }

    double[] buffer;
    int i;
    double phase;
    public void Tick(double TimeIncrement) {
        phase += TimeIncrement * _frequency* 360;
        phase %= 360;

        var delay = (int)((_mindelay + (_maxdelay - _mindelay) * (Math.Sin(phase * Math.PI / 180) / 2 + 0.5)) * SynthEngine._SampleRate);

        var index = mod(i - delay, buffer.Length);

        Value = Source.Value + Gain * buffer[index];

        buffer[i] = Source.Value;
        i++;
        i %= buffer.Length;
    }

    int mod(int x, int m) {
        int r = x % m;
        return r < 0 ? r + m : r;
    }
    #endregion
}
