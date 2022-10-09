using System.Collections.ObjectModel;

namespace Synth.Modules.Modifiers;
public class Mixer : iModule {
    #region Constructor
    public Mixer() {
        Sources.CollectionChanged += (o, e) => SourcesChanged();
    }
    #endregion

    #region Public Properties
    // This is an enumarable but with a CollectionChanged event so we can resize Levels list when new Sources are added
    public ObservableCollection<iModule> Sources { get; set; } = new();

    public List<double> Levels { get; set; } = new();
    #endregion

    #region iModule Members
    public double Value { get; internal set; }

    public void Tick(double TimeIncrement) {
        Value = 0;
        for (int i = 0; i < Sources.Count; i++)
            Value += Sources[i].Value * Levels[i];
    }
    #endregion

    #region Private Methods
    private void SourcesChanged() {
        // Resize Levels list to match number of items in Source
        if (Sources.Count > Levels.Count) {
            // Make bigger
            for (int i = Levels.Count; i < Sources.Count; i++)
                Levels.Insert(i, 0f);
        }

        if (Sources.Count < Levels.Count) {
            throw new InvalidOperationException("Removal of modules is not allowed");
        }
    }
    #endregion
}

