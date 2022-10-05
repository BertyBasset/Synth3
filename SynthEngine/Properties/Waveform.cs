using Synth.Modules.Sources.Generators;

namespace Synth.Properties
{
    public enum WaveformType {
        Sine = 0,
        Saw,
        Triangle,
        Square,
        Noise,
        SuperSaw,
        SawFalling,
        SH
    }

    public class WaveForm {
        #region Public Properties
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public WaveformType Type { get; set; }


        internal iGenerator? _Generator;
        internal iGenerator Generator {
            get {
                if (_Generator == null) {
                    switch (Type) {
                        case WaveformType.Sine: _Generator = new GeneratorSine(); break;
                        case WaveformType.Saw: _Generator = new GeneratorSaw(); break;
                        case WaveformType.SawFalling: _Generator = new GeneratorSaw(); break;
                        case WaveformType.Triangle: _Generator = new GeneratorTriangle(); break;
                        case WaveformType.Square: _Generator = new GeneratorSquare(); break;
                        case WaveformType.Noise: _Generator = new GeneratorNoise(); break;
                        case WaveformType.SuperSaw: _Generator = new GeneratorSuperSaw(); break;
                        // No generator for Sample and Hold. LFO will take care of it.
                        default: _Generator = new GeneratorSine(); break;
                    }
                }

                return _Generator;
            }
        }
        #endregion

        #region Public Methods
        public static WaveForm GetByID(int ID) {
            return GetWaveFormList().Where(w => w.ID == ID).First();
        }

        public static WaveForm GetByType(WaveformType Type) {
            return GetWaveFormList().Where(w => w.Type == Type).First();
        }

        public static WaveForm GetByName(string Name) {
            return GetWaveFormList().Where(w => w.Name.ToLower() == Name.ToLower()).First();
        }

        public static List<WaveForm> GetWaveFormList() {
            var waveforms = new List<WaveForm>();

            waveforms.Add(new WaveForm() { ID = 0, Name = "Sine", Type = WaveformType.Sine });
            waveforms.Add(new WaveForm() { ID = 1, Name = "Saw", Type = WaveformType.Saw });
            waveforms.Add(new WaveForm() { ID = 2, Name = "Triangle", Type = WaveformType.Triangle });
            waveforms.Add(new WaveForm() { ID = 3, Name = "Square", Type = WaveformType.Square });
            waveforms.Add(new WaveForm() { ID = 4, Name = "Noise", Type = WaveformType.Noise });
            waveforms.Add(new WaveForm() { ID = 7, Name = "SuperSaw", Type = WaveformType.SuperSaw });
            waveforms.Add(new WaveForm() { ID = 8, Name = "Saw-Falling", Type = WaveformType.SawFalling});
            waveforms.Add(new WaveForm() { ID = 9, Name = "Sample and Hold", Type = WaveformType.SH });

            return waveforms;
        }
        #endregion
    }
}
