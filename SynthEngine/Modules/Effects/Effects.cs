using Synth.Modules;
using SynthEngine.Modules.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Synth.Enums;

namespace Synth.Modules.Effects {
    public class Effects : iModule {
        private double _param1;
        public double Param1 {
            get { return _param1; }
            set {
                _param1 = value;
                switch (_EffectType) {
                    case EffectType.Chorus: 
                        ((Chorus)_Effect).Gain = _param1;
                        break;
                    case EffectType.Reverb: 
                        ((Reverb)_Effect).Gain = _param1; 
                        break;
                    case EffectType.AllPass:
                        ((AllPassFilter)_Effect).Gain = _param1;
                        break;
                    case EffectType.FeedbackComb:
                        ((FeedbackCombFilter)_Effect).Gain = _param1;
                        break;
                    case EffectType.FeedForwardComb:
                        ((FeedForwardCombFilter)_Effect).Gain = _param1;
                        break;
                    case EffectType.BitCrusher:
                        ((BitCrusher)_Effect).Resolution = _param1;
                        break;
                    default:
                        break;
                }
            }
        }

        private double _param2;
        public double Param2 {
            get { return _param2; }
            set {
                _param2 = value;
                switch (_EffectType) {
                    case EffectType.Chorus:
                        ((Chorus)_Effect).MinDelay = _param2;
                        break;
                    case EffectType.Reverb:
                        ((Reverb)_Effect).Delay = _param2;
                        break;
                    case EffectType.AllPass:
                        ((AllPassFilter)_Effect).Delay = _param2;
                        break;
                    case EffectType.FeedbackComb:
                        ((FeedbackCombFilter)_Effect).Delay = _param2;
                        break;
                    case EffectType.FeedForwardComb:
                        ((FeedForwardCombFilter)_Effect).Delay = _param2;
                        break;
                    case EffectType.BitCrusher:
                        ((BitCrusher)_Effect).SampleRate = _param2;
                        break;
                    default:
                        break;
                }
            }
        }

        private double _param3;
        public double Param3 {
            get { return _param3; }
            set {
                _param3 = value;
                switch (_EffectType) {
                    case EffectType.Chorus:
                        ((Chorus)_Effect).MaxDelay = _param3;
                        break;
                    default:
                        break;
                }
            }
        }

        private double _param4;
        public double Param4 {
            get { return _param4; }
            set {
                _param4 = value;
                switch (_EffectType) {
                    case EffectType.Chorus:
                        ((Chorus)_Effect).Frequency = _param4;
                        break;
                    default:
                        break;
                }
            }
        }


        public iModule Source { get; set; } = new NullModule();
        private iModule _Effect = new Chorus();

        private Enums.EffectType _EffectType = Enums.EffectType.Chorus;
        public Enums.EffectType EffectType {
            get { return _EffectType; }
            set {
                _EffectType = value;
                switch (_EffectType) {
                    case EffectType.Chorus: _Effect = new Chorus(); break;
                    case EffectType.Reverb: _Effect = new Reverb(); break;
                    case EffectType.AllPass: _Effect = new AllPassFilter(); break;
                    case EffectType.FeedbackComb: _Effect = new FeedbackCombFilter(); break;
                    case EffectType.FeedForwardComb: _Effect = new FeedForwardCombFilter(); break;
                    case EffectType.BitCrusher: _Effect = new BitCrusher(); break;
                    default: break;
                }
            }
        }



        public double Balance { get; set; } = 0;             // -1 to 1, 0 is equal mix of dry and effect

        public double Value { get; set; }

        void iModule.Tick(double TimeIncrement) {
            _Effect.Tick(TimeIncrement);


            Value = Source.Value * ( Balance - 1) / 2 + _Effect.Value * (Balance * 2 + 2) / 4;




        }
    }
}
