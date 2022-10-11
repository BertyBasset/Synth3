namespace Synth.Modules.Modifiers.Filters.Types;

public interface iFilter : iModule
{
    public iModule Source { get; set; }
    public double Cutoff { get; set; }
    
    public double ModAmount { get; set; }
    public iModule Modulator { get; set; }
}