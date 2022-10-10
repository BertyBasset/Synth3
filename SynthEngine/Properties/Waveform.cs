using Synth.Modules.Sources.Generators;

namespace Synth.Properties;

public enum VCOWaveformType {
    Sine = 0,
    Saw,
    Triangle,
    Square,
    SuperSaw,
    SawFalling
}

public class VCOWaveForm {
    #region Public Properties
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public VCOWaveformType Type { get; set; }


    internal iGenerator? _Generator;
    internal iGenerator Generator {
        get {
            if (_Generator == null) {
                switch (Type) {
                    case VCOWaveformType.Sine: _Generator = new GeneratorSine(); break;
                    case VCOWaveformType.Saw: _Generator = new GeneratorSaw(); break;
                    case VCOWaveformType.Triangle: _Generator = new GeneratorTriangle(); break;
                    case VCOWaveformType.Square: _Generator = new GeneratorSquare(); break;
                    case VCOWaveformType.SuperSaw: _Generator = new GeneratorSuperSaw(); break;
                    case VCOWaveformType.SawFalling: _Generator = new GeneratorSaw(); break;
                    // No generator for Sample and Hold. LFO will take care of it.
                    default: _Generator = new GeneratorSine(); break;
                }
            }

            return _Generator;
        }
    }
    #endregion

    #region Public Methods
    public static VCOWaveForm GetByID(int ID) {
        return GetWaveFormList().Where(w => w.ID == ID).First();
    }

    public static VCOWaveForm GetByType(VCOWaveformType Type) {
        return GetWaveFormList().Where(w => w.Type == Type).First();
    }

    public static VCOWaveForm GetByName(string Name) {
        return GetWaveFormList().Where(w => w.Name.ToLower() == Name.ToLower()).First();
    }

    public static List<VCOWaveForm> GetWaveFormList() {
        var waveforms = new List<VCOWaveForm>();

        waveforms.Add(new VCOWaveForm() { ID = 0, Name = "Sine", Type = VCOWaveformType.Sine });
        waveforms.Add(new VCOWaveForm() { ID = 1, Name = "Saw", Type = VCOWaveformType.Saw });
        waveforms.Add(new VCOWaveForm() { ID = 2, Name = "Triangle", Type = VCOWaveformType.Triangle });
        waveforms.Add(new VCOWaveForm() { ID = 3, Name = "Square", Type = VCOWaveformType.Square });
        waveforms.Add(new VCOWaveForm() { ID = 4, Name = "SuperSaw", Type = VCOWaveformType.SuperSaw });
        waveforms.Add(new VCOWaveForm() { ID = 5, Name = "SawFalling", Type = VCOWaveformType.Saw });

        return waveforms;
    }
    #endregion
}



public enum LFOWaveformType {
    Sine = 0,
    Saw,
    SawFalling,
    Triangle,
    Square,
    SH
}

public class LFOWaveForm {
    #region Public Properties
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public LFOWaveformType Type { get; set; }


    internal iGenerator? _Generator;
    internal iGenerator Generator {
        get {
            if (_Generator == null) {
                switch (Type) {
                    case LFOWaveformType.Sine:
                        _Generator = new GeneratorSine();
                        break;
                    case LFOWaveformType.Saw:
                        _Generator = new GeneratorSaw();
                        break;
                    case LFOWaveformType.Triangle:
                        _Generator = new GeneratorTriangle();
                        break;
                    case LFOWaveformType.Square:
                        _Generator = new GeneratorSquare();
                        break;
                    case LFOWaveformType.SawFalling:
                        _Generator = new GeneratorSaw();
                        break;
                    // No generator for Sample and Hold. LFO will take care of it.
                    default:
                        _Generator = new GeneratorSine();
                        break;
                }
            }

            return _Generator;
        }
    }
    #endregion

    #region Public Methods
    public static LFOWaveForm GetByID(int ID) {
        return GetWaveFormList().Where(w => w.ID == ID).First();
    }

    public static LFOWaveForm GetByType(LFOWaveformType Type) {
        return GetWaveFormList().Where(w => w.Type == Type).First();
    }

    public static LFOWaveForm GetByName(string Name) {
        return GetWaveFormList().Where(w => w.Name.ToLower() == Name.ToLower()).First();
    }

    public static List<LFOWaveForm> GetWaveFormList() {
        var waveforms = new List<LFOWaveForm>();

        waveforms.Add(new LFOWaveForm() { ID = 0, Name = "Sine", Type = LFOWaveformType.Sine });
        waveforms.Add(new LFOWaveForm() { ID = 1, Name = "Saw", Type = LFOWaveformType.Saw });
        waveforms.Add(new LFOWaveForm() { ID = 2, Name = "Saw-Falling", Type = LFOWaveformType.SawFalling });
        waveforms.Add(new LFOWaveForm() { ID = 3, Name = "Triangle", Type = LFOWaveformType.Triangle });
        waveforms.Add(new LFOWaveForm() { ID = 4, Name = "Square", Type = LFOWaveformType.Square });
        waveforms.Add(new LFOWaveForm() { ID = 5, Name = "Sample and Hold", Type = LFOWaveformType.SH });

        return waveforms;
    }
    #endregion
}

