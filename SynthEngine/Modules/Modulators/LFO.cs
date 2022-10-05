using Synth.IO;
using Synth.Modules.Sources.Generators;
using Synth.Properties;

namespace Synth.Modules.Modulators;

public class LFO : iModule {
    #region Private Properties
    double _level = 0f;
    bool _Gate = false;                 // If Gate high, we're in delay phase, incrementing level
    const double MAX_DELAY = 5f;         // Max time to get to full LFO output level of x1

    // Generator class will change according to selected waveform
    // The Oscillator will call _Generators GenerateSample(float Phase) method each time it requires a new waveform sample
    iGenerator _Generator = new GeneratorSine();

    // _Phase is the oscillator's 360 degree modulo phase accumulator
    double _Phase = 0f;
    #endregion

    #region Public Properties
    private WaveForm _WaveForm = new WaveForm();
    public WaveForm WaveForm {
        get { return _WaveForm; }
        set {
            _WaveForm = value;
            _Generator = _WaveForm.Generator;   // This is where we assign Waveform Specific Generator to private _Generator object
        }
    }

    private double _Frequency;
    public double Frequency {
        get { return _Frequency; }
        set {
            _Frequency = Utils.Misc.Constrain(Value, 0f, 1f);
            // Pass in 0 to 1 to cover full LFO range logarithmically , which will be 0.1 Hz to 10Hz
            double v = value * 2 - 1;                // -1 to +1,  -1 = 0.1Hx, 0 = 1Hz, +1 = 10Hz
            double f = Math.Pow(10, v);
            _Frequency = f;
        }
    }
    private double _Delay = 0;
    public double Delay {
        get { return _Delay; }

        set {
            _Delay = Utils.Misc.Constrain(value * 5f, 0f, MAX_DELAY);
        }
    }
    #endregion

    #region Private Properties
    Random r = new();
    double oldPhase;
    #endregion

    #region iModule Members
    public double Value { get; set; }

    // This is the *-*-* MEATY *-*-* bit
    public void Tick(double timeIncrement) {
        // Advance Phase Accumulator acording to timeIncrement and current frequency
        double delta = timeIncrement * Frequency * 360f;
        _Phase += delta;
        _Phase = _Phase % 360;

        double value = 0f;

        if (_WaveForm.Type == WaveformType.SH) {
            // Only update S+H value once per phase cycle
            if (oldPhase > _Phase) {
                float i = (float)(int)r.NextInt64(-12, 12);
                Value = i / 12 * _level * 10;
            }
        } else {
            if (_WaveForm.Type == WaveformType.SawFalling)
                value = _Generator.GenerateSample(_Phase, 0, delta, false);
            else
                value = -_Generator.GenerateSample(_Phase, 0, delta, false);
            Value = value * _level * 2;         // Scale by _level, which ramps up and down according to delay (0-1 = 0-5s)  where MAX_DELAY=5
        }
        oldPhase = _Phase;


        // Increment/decrement or leave level as is
        if (_Delay == 0)
            _level = 1f;
        else {
            double inc = (timeIncrement / _Delay) / MAX_DELAY;
            if (_Gate) {
                if (_level < 1f)
                    _level += inc;
                else
                    _level = 1f;
            }

            if (!_Gate) {           // Decay 2 times faster than Delay
                if (_level > 0f)
                    _level -= (inc + 2f);       // Might make variable ??
                else
                    _level = 0f;
            }
        }
    }
    #endregion

    #region Trigger Event handling
    private Keyboard? _Keyboard;
    public Keyboard Keyboard {
        set {
            _Keyboard = value;

            _Keyboard.TriggerOn += _Keyboard_TriggerOn;
            _Keyboard.TriggerOff += _Keyboard_TriggerOff;
        }
    }

    private void _Keyboard_TriggerOff(object? sender, EventArgs e) {
        _Gate = false;
    }

    private void _Keyboard_TriggerOn(object? sender, EventArgs e) {
        _Gate = true;
    }
    #endregion

}