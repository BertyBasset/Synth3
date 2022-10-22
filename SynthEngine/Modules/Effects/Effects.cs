using static Synth.Enums;

namespace Synth.Modules.Effects {
    public class Effects : iModule {
        #region Public Members
        private double _param1;
        public double Param1 {
            get { return _param1; }
            set {
                _param1 = value;
                switch (_EffectType) {
                    case EffectType.Chorus: 
                        ((Chorus)_Effect).Frequency = _param1;
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
                        ((Chorus)_Effect).MaxDelay = _param2;
                        break;
                    case EffectType.Reverb:
                        ((Reverb)_Effect).DelayLength = _param2;
                        break;
                    case EffectType.AllPass:
                        ((AllPassFilter)_Effect).DelayLength = _param2;
                        break;
                    case EffectType.FeedbackComb:
                        ((FeedbackCombFilter)_Effect).DelayLength = _param2;
                        break;
                    case EffectType.FeedForwardComb:
                        ((FeedForwardCombFilter)_Effect).DelayLength = _param2;
                        break;
                    default:
                        break;
                }
            }
        }

     


        public iModule Source { get; set; } = new NullModule();
        private iEffect _Effect = new Chorus();

        private Enums.EffectType _EffectType = Enums.EffectType.Chorus;
        public Enums.EffectType EffectType {
            get { return _EffectType; }
            set {
                _EffectType = value;
                switch (_EffectType) {
                    case EffectType.None: _Effect = new NullEffect(); break;
                    case EffectType.Chorus: _Effect = new Chorus(); break;
                    case EffectType.Reverb: _Effect = new Reverb(); break;
                    case EffectType.AllPass: _Effect = new AllPassFilter(); break;
                    case EffectType.FeedbackComb: _Effect = new FeedbackCombFilter(); break;
                    case EffectType.FeedForwardComb: _Effect = new FeedForwardCombFilter(); break;
                    default: break;
                }
                _Effect.Source = Source;
            }
        }

        public double Mix { get; set; } = 0;             // -1 to 1, 0 is equal mix of dry and effect
        #endregion

        #region iModule Members
        public double Value { get; set; }

        void iModule.Tick(double TimeIncrement) {
            _Effect.Tick(TimeIncrement);

            double dry = -(Mix - 1) / 2;
            double wet = (Mix* 2 + 2) / 4;



            Value = Source.Value * dry + _Effect.Value * wet;

            //Value = Source.Value;
            //Value = _Effect.Value;

        }
        #endregion
    }
}
