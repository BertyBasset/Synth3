namespace Synth.Modules.Modifiers.Filters.Types;
internal class RC : iFilter {
    #region Public Properties
    public iModule Source { get; set; } = new NullModule();
    public double Cutoff { get; set; }
    public double ModAmount { get; set; }
    public iModule Modulator { get; set; } = new NullModule();
    #endregion

    #region Private Poperties
    double[] stages = new double[4];
    #endregion

    #region iModule Members
    public void Tick(double timeIncrement) {
        if (Source == null)
            return;

        // Assume Cutoff and Modulator 0 -> 1

        double fc =  VCF.GetCutoffFrequency(Cutoff, Modulator, ModAmount);     // This now centrallised
        double RC = 1.0 / (2 * Math.PI * fc);   
        double dt =  timeIncrement;
        double a = dt / (RC + dt);

        stages[0] = a * Source.Value + (1 - a) * stages[0];
        for (int i = 1; i < stages.Length; i++)
            stages[i] = a * stages[i - 1] + (1 - a) * stages[i];
        Value = stages[^1];
    }

    public double Value { get; set; }
    #endregion
}
