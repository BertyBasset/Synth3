using Synth.Modules.Sources.Generators;
using Synth.Properties;

namespace Synth.Modules.Sources;

public class VCO : iModule {

    #region Private Members
    // Generator class will change according to selected waveform
    // The Oscillator will call _Generators GenerateSample(float Phase) method each time it requires a new waveform sample
    iGenerator _Generator = new GeneratorSine();

    // _Phase is the oscillator's 360 degree modulo phase accumulator
    double _Phase = 0f;


    #endregion

    #region Constructor
    public VCO(VCOWaveForm? waveForm = null) {
        // Default to Sine if no waveform specifified
        this.WaveForm = waveForm ?? VCOWaveForm.GetByType(VCOWaveformType.Sine);
    }
    #endregion

    #region Public Members
    // If we want current oscillator to as sync source for another oscillator, set it as sync destination
    public VCO? SyncDestination;


    // To simplify Oscillator, delegate all Frequency operations to containment class Frequecny
    public Frequency Frequency = new Frequency();


    public double Value { get; internal set; }         // This is pre amplitude modified value suitable as modulation source  

    public Duty Duty = new Duty();


    private VCOWaveForm _WaveForm = new VCOWaveForm();
    public VCOWaveForm WaveForm {
        get { return _WaveForm; }
        set {
            _WaveForm = value;
            _Generator = _WaveForm.Generator;   // This is where we assign Waveform Specific Generator to private _Generator object
        }
    }


    // **** Properties specific only some to some generator types
    //      at the moment, WaveTable, Harmonic and SuperSaw


   


    // Supersaw Oscillator Only !!
    // This is an array containing relative frequencies for the sawtooths. 
    // Generally, put nominal frequenct 1 in centre of array, then detune or retune (e.g. fifths) either side
    private double[] _FrequencyRatios = new double[] { 1f, -.5f, .33f, -.25f, .2f, -.17f };     // Default to a 'narrow' supersaw
    public double[] FrequencyRatios {
        get { return _FrequencyRatios; }
        set {
            _FrequencyRatios = value;
            if (_Generator.GetType() == typeof(GeneratorSuperSaw))
                ((GeneratorSuperSaw)_Generator).FrequencyRatios = _FrequencyRatios;
        }
    }
    #endregion

    public string? ID { get; set; } = "";

    #region Public Methods

    // Reset Phase Accumulator(s) to 0


    public void Sync() {
        _Phase = 0;

        _Generator.Sync();
        // Also reset phase accumulators of Generators
    }

    // When selecting a new waveform, all we need to do is swap in the relevant wave Generator object
    public void WaveFormSelectByID(int id) {
        var w = VCOWaveForm.GetByID(id);

        // Plug in a specific Generator for the wave type selected
        _Generator = w.Generator;



    }




    double _OldPhase;        // Use to detect zero crossing
    public void Tick(double timeIncrement) {
        // Advance Phase Accumulator acording to timeIncrement and current frequency
        double delta = timeIncrement * Frequency.GetFrequency() * 360f;
        _Phase += delta;

        double originalPhase = _Phase;
        _Phase = _Phase % 360;

        if (_Phase < originalPhase)     // If % takes us back for a new cycle we've completed a cycle and can sync other ocs if needed
            TriggerSync();

        // Use Generator to return wave value for current state of the Phase Accumulator


        // ** Pass in Zero Crossing to Generator for Phase Dist
        bool isZeroCrossing = _OldPhase > _Phase ? true : false;
        _OldPhase = _Phase;



        if (_WaveForm.Type == VCOWaveformType.SawFalling)
            Value = 1 - _Generator.GenerateSample(_Phase, Duty.GetDuty(), delta, isZeroCrossing);
        else
            Value = _Generator.GenerateSample(_Phase, Duty.GetDuty(), delta, isZeroCrossing);


    }

    private void TriggerSync() {
        if (SyncDestination != null)
            SyncDestination.Sync();
    }

    #endregion
}