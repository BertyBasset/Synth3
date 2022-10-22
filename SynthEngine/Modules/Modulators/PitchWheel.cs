
using Synth.Modules;
using Synth.Modules.IO;
using System.Windows.Forms;

namespace Synth.Modules.Modulators;
public class PitchWheel : iModule {
    private Midi midi = Midi.Instance;

    public PitchWheel() {
        midi.PitchWheelChanged += (o, e) => {
            if (_midichannel == null || _midichannel == e.MidiChannelID)
                Value = ((e.Value - 8192f) / 4096 / 12) * MathF.Pow(2, 1 / 12);
        };
    }

    private int? _midichannel = 1;
    public int? MidiChannel {
        get { return _midichannel; }
        set {
            if (value < 1 || value > 16)
                throw new ArgumentOutOfRangeException("Midi Channel must be 1-16, or left as NULL");
            _midichannel = value;
        }
    }

    public double Value{get; set;}

    public void Tick(double TimeIncrement) {
        // No need to do anything. Value gets set by Midi event
    }
}
