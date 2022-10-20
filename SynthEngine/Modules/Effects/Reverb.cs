using Synth.Modules;
using Synth.Modules.Modifiers;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;

namespace Synth.Modules.Effects;
public class Reverb : iEffect {
    #region Public Members
    private iModule _source = new NullModule();
    public iModule Source {
        get { return _source; }
        set {
            _source = value;
            FFCF0.Source = _source;
            FFCF1.Source = _source;
            FFCF2.Source = _source;
            FFCF3.Source = _source;
        } 
    }
    public double _gain;
    public double Gain {
        get { return _gain; }
        set { 
            _gain = value;
            FFCF0.Gain = _gain;
            FFCF1.Gain = _gain;
            FFCF2.Gain = _gain;
            FFCF3.Gain = _gain;
            APF0.Gain = _gain;
            APF1.Gain = _gain;
            APF2.Gain = _gain;
        }
    }

    private double _delaylength;
    public double DelayLength {
        get { return _delaylength; }
        set {
            _delaylength = value;

            FFCF0.DelayLength = DelayLength;
            FFCF1.DelayLength = DelayLength * 0.9;
            FFCF2.DelayLength = DelayLength * 0.8;
            FFCF3.DelayLength = DelayLength * 0.7;

            APF0.DelayLength = DelayLength * 0.2;
            APF1.DelayLength = DelayLength * 0.1;
            APF2.DelayLength = DelayLength * .05;
        } 
    }
    #endregion

    #region iEffect Members
    List<iModule> modules = new();
    FeedForwardCombFilter FFCF0 = new();
    FeedForwardCombFilter FFCF1 = new();
    FeedForwardCombFilter FFCF2 = new();
    FeedForwardCombFilter FFCF3 = new();

    Mixer mixer = new Mixer();

    AllPassFilter APF0 = new();
    AllPassFilter APF1 = new();
    AllPassFilter APF2 = new();

    public Reverb() {
        mixer.Sources.Add(FFCF0);
        mixer.Sources.Add(FFCF1);
        mixer.Sources.Add(FFCF2);
        mixer.Sources.Add(FFCF3);
        mixer.Levels[0] = 0.5;
        mixer.Levels[1] = 0.5;
        mixer.Levels[2] = 0.5;
        mixer.Levels[3] = 0.5;
        APF0.Source = mixer;
        APF1.Source = APF0;
        APF2.Source = APF1;

        modules.Add(FFCF0);
        modules.Add(FFCF1);
        modules.Add(FFCF2);
        modules.Add(FFCF3);
        modules.Add(mixer);
        modules.Add(APF0);
        modules.Add(APF1);
        modules.Add(APF2);

    }


    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {
        
        foreach(var m in modules)
            m.Tick(TimeIncrement);

        Value = APF2.Value;
    }
    #endregion
}

