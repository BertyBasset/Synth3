using Synth.Modules;

namespace Synth.Properties;
public class Duty {

    #region Public Properties
    public double Value { get; set; }

    public iModule? Modulator{ get; set; }
    
    private double _ModulationAmount;
    public double ModulationAmount {         
        get { return _ModulationAmount; }
        set {
            _ModulationAmount = Utils.Misc.Constrain(value, -1f, 1f);           // not sure what this should be at the moment
        }
    }
    #endregion

    #region Public Methods
    public double GetDuty() {
        double value = Value;
        if(Modulator != null)    
            value = value + Modulator.Value * _ModulationAmount;

        return Utils.Misc.Constrain(value, -0.98f, 0.98f);
    }
    #endregion
}
