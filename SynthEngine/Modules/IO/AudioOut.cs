using Synth.Modules;

namespace Synth.IO;

public class AudioOut : iModule {
    #region Public Properties
    public iModule? Source { get; set; }
    #endregion

    #region iModule Members
    public double Value { get; internal set; } = 0;

    public void Tick(double TimeIncrement) {
        Value = Source == null ? 0 : Source.Value;
    }
    #endregion
}
