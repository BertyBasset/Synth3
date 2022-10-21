// To DO
// 1 Switches



// Then we leave for a month !!


// Version 4
// 2 Modulation Matrix System - maybe have a bank of VCAs to modulate modulators?
// 3 Patch Save/Recall
// 4 Rationalise CV stuff (not sure if needed, but revisit anyway)

// Version 5
// 5. Polyphony !


using Synth.IO;
using Synth;
using Synth.Modules.Modifiers;
using Synth.Modules.Modifiers.Filters;
using Synth.Modules.Modulators;
using Synth.Modules.Sources;
using SynthEngine.Modules.Modulators;
using SynthEngine.Modules.Sources;
using System.Windows.Forms;
using UI.Code;
using UI.Controls;
using static Synth.Enums;
using Synth.Modules.Effects;
using System.Diagnostics;

namespace UI;
public partial class frmMidiController : Form {
    Dictionary<int, UI.Controls.Knob> controlMap = new();       // Midi Conntroller

    #region Synth Modules
    Synth.SynthEngine engine = new Synth.SynthEngine();
    ModWheel mw = new();
    MidiControllers mc = new();         // Provides event handler when a Midi Controller changes value
    Keyboard kbd = new();
    VCO vco1 = new();
    VCO vco2 = new();
    VCO vco3 = new();
    Noise noise = new();

    LFO lfo1 = new();           // These aren't connected anywhere
    LFO lfo2 = new();

    Mixer m = new();
    BitCrusher crush = new();

    Synth.Modules.Modifiers.Filters.VCF vcf = new();
    VCA vca = new();
    EnvGen env1 = new();
    EnvGen env2 = new();
    EnvGen env3 = new();


    Effects effects = new();
    AudioOut output = new();

    // ControlHandler - this takes care of binding controls to synth modules, and plumbs events when control value changes
    ControlHandler ctls = new();
    #endregion

    #region Initiallise
    public frmMidiController() {
        InitializeComponent();
        InitSynth();
        InitControlGroupLeds();

        kVcfType.ValueChanged += (o, e) => FilterTypeChanged();
        kEffectType.ValueChanged += (o, e) => EffectTypeChanged();
        cmdViewWave.Click += (o, e) => {
            var viewer = new frmWaveViewer(engine);
            viewer.Show();
        };
        cmdControllers.Click += (o, e) => {
            var frm = new frmControlMapping();
            frm.form = this;
            frm.ShowDialog();
            SetupDefaultMidiControllers();
        };

        SetupDefaultMidiControllers();


        mc.ControllerValueChanged += (o, e) => {
            const double MAX_RANGE = 128;
            if (!controlMap.ContainsKey(e.ControllerID))
                return;         // Unhandled Controller


            var knob = controlMap[e.ControllerID];

            if (knob.LimitToInteger) {
                var newValue = Math.Round(((double)e.Value / MAX_RANGE) * (double)(knob.Max - knob.Min) + knob.Min);
                if (knob.Value != newValue)
                    knob.Value = newValue;
            } else {
                knob.Value = ((double)e.Value / MAX_RANGE) * (double)(knob.Max - knob.Min) + knob.Min;
            }
        };

        this.FormClosing += (o, e) => Patch.Save(this);
        this.Load += (o, e) => Patch.Load(this);

        cmdInit.Click += CmdInit_Click;
        cboMidiChannel.SelectedIndex = 0;
        cboMidiChannel.SelectedIndexChanged += (o, e) => {
            int? midiChannel = cboMidiChannel.SelectedIndex <= 0 ? null : cboMidiChannel.SelectedIndex;
            kbd.MidiChannel = midiChannel;
            mw.MidiChannel = midiChannel;
            mc.MidiChannel = midiChannel;
        };

        kbd.TriggerOn += (o, e) => ledGate.LedState = Led.Enums.LedState.On;
        kbd.TriggerOff += (o, e) => ledGate.LedState = Led.Enums.LedState.Off;

        lfo1.ClockTick += (o, e) => ledLfo1.LedState = e ? Led.Enums.LedState.On : Led.Enums.LedState.Off;
        lfo2.ClockTick += (o, e) => ledLfo2.LedState = e ? Led.Enums.LedState.On : Led.Enums.LedState.Off;
    }

    void InitSynth() {
        vco1.Frequency.Keyboard = kbd;
        vco2.Frequency.Keyboard = kbd;
        vco3.Frequency.Keyboard = kbd;

        m.Sources.Add(vco1);
        m.Sources.Add(vco2);
        m.Sources.Add(vco3);
        m.Sources.Add(noise);

        crush.Source = m;

        env1.Keyboard = kbd;
        vcf.Source = crush;

        //        vcf.Modulator = mw;
        vcf.Modulator = env1;

        env2.Keyboard = kbd;

        vca.Source = vcf;
        vca.Modulator = env2;
        effects.Source = vca;

        output.Source = effects;

        engine.Modules.Add(mw);
        engine.Modules.Add(kbd);
        engine.Modules.Add(vco1);
        engine.Modules.Add(vco2);
        engine.Modules.Add(vco3);
        engine.Modules.Add(noise);
        engine.Modules.Add(lfo1);
        engine.Modules.Add(lfo2);
        engine.Modules.Add(m);
        engine.Modules.Add(crush);
        engine.Modules.Add(env1);
        engine.Modules.Add(vcf);
        engine.Modules.Add(env2);
        engine.Modules.Add(vca);
        engine.Modules.Add(env3);       // Env3 not connected to anything yet
        engine.Modules.Add(effects);

        engine.Modules.Add(output);

        InitControllers();
    }

    private void InitControllers() {
        // Bind controllers to modules


        //            Knob object           Controlled object       Controller Property
        ctls.Register(kOsc1Freq, vco1.Frequency, "FineTune");
        ctls.Register(kOsc1Octave, vco1.Frequency, "Octave");
        ctls.Register(kOsc1Waveform, vco1, "WaveForm");
        ctls.Register(kOsc1PW, vco1.Duty, "Value");
        ctls.Register(kOsc2Freq, vco2.Frequency, "FineTune");
        ctls.Register(kOsc2Octave, vco2.Frequency, "Octave");
        ctls.Register(kOsc2Waveform, vco2, "WaveForm");
        ctls.Register(kOsc2PW, vco2.Duty, "Value");
        ctls.Register(kOsc3Freq, vco3.Frequency, "FineTune");
        ctls.Register(kOsc3Octave, vco3.Frequency, "Octave");
        ctls.Register(kOsc3Waveform, vco3, "WaveForm");
        ctls.Register(kOsc3PW, vco3.Duty, "Value");
        //                                                                      Index - for array properties
        ctls.Register(kOsc1Mix, m, "Levels", 0);
        ctls.Register(kOsc2Mix, m, "Levels", 1);
        ctls.Register(kOsc3Mix, m, "Levels", 2);
        ctls.Register(kNoiseMix, m, "Levels", 3);
        ctls.Register(kBitCrushSampleRate, crush, "SampleRate");
        ctls.Register(kBitCrushResolution, crush, "Resolution");

        ctls.Register(kLfo1Rate, lfo1, "Frequency");
        ctls.Register(kLfo1Shape, lfo1, "Shape");
        ctls.Register(kLfo2Rate, lfo2, "Frequency");
        ctls.Register(kLfo2Shape, lfo2, "Shape");
        ctls.Register(kVcfType, vcf, "FilterType");
        ctls.Register(kVcfCutoff, vcf, "Cutoff");
        ctls.Register(kVcfResonance, vcf, "Resonance");
        ctls.Register(kVcfResonance, vcf, "Bandwidth");
        ctls.Register(kVcfEnvelope, vcf, "ModAmount");


        //ctls.Register(kVcfEnvelope,       vcf.Modulator,          "FilterType");     // Need Mod Amount Property
        ctls.Register(kEnv1Attack, env1, "Attack");
        ctls.Register(kEnv1Decay, env1, "Decay");
        ctls.Register(kEnv1Sustain, env1, "Sustain");
        ctls.Register(kEnv1Release, env1, "Release");

        ctls.Register(kEnv2Attack, env2, "Attack");
        ctls.Register(kEnv2Decay, env2, "Decay");
        ctls.Register(kEnv2Sustain, env2, "Sustain");
        ctls.Register(kEnv2Release, env2, "Release");
        ctls.Register(kEnv3Attack, env3, "Attack");
        ctls.Register(kEnv3Decay, env3, "Decay");
        ctls.Register(kEnv3Sustain, env3, "Sustain");
        ctls.Register(kEnv3Release, env3, "Release");
        ctls.Register(kGlide, kbd, "Glide");

        // Effects
        ctls.Register(kEffectType, effects, "EffectType");
        ctls.Register(kEffectParam1, effects, "Param1");
        ctls.Register(kEffectParam2, effects, "Param2");
        ctls.Register(kEffectParam3, effects, "Param3");
        ctls.Register(kEffectParam4, effects, "Param4");
        ctls.Register(kEffectBalance, effects, "Balance");

    }
    #endregion

    #region Event Handlers
    private void FilterTypeChanged() {
        switch (kVcfType.Value) {
            case (int)Enums.FilterType.RC:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass RC 1 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "n/a"));
                break;
            case (int)Enums.FilterType.Butterworth:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Butterworth 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "RESONANCE"));
                break;
            case (int)Enums.FilterType.Chebyshev:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Chebyshev 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "RIPPLE"));
                vcf.RippleFactor = kVcfResonance.Value;
                break;
            case (int)Enums.FilterType.Bessel:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Bessel 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "n/a"));
                break;
            case (int)Enums.FilterType.BandPass:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Band Pass"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "BANDWIDTH"));
                vcf.Bandwidth = kVcfResonance.Value;
                break;
            case (int)Enums.FilterType.Notch:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Notch Pass"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "BANDWIDTH"));
                vcf.Bandwidth = kVcfResonance.Value;

                // Ideally need attenuation as well
                break;
            default:
                break;
        }
        vcf.ModAmount = kVcfEnvelope.Value;
    }

    private void EffectTypeChanged() {
        switch (kEffectType.Value) {
            case (int)EffectType.None:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "None"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "n/a"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "n/a"));
                kEffectParam3.Invoke((MethodInvoker)(() => kEffectParam3.LabelText = "n/a"));
                kEffectParam4.Invoke((MethodInvoker)(() => kEffectParam4.LabelText = "n/a"));
                break;
            case (int)EffectType.Chorus:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Chorus"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "MIN DELAY"));
                kEffectParam3.Invoke((MethodInvoker)(() => kEffectParam3.LabelText = "MAX DELAY"));
                kEffectParam4.Invoke((MethodInvoker)(() => kEffectParam4.LabelText = "FREQUENCY"));
                break;
            case (int)EffectType.Reverb:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Reverb"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                kEffectParam3.Invoke((MethodInvoker)(() => kEffectParam3.LabelText = "n/a"));
                kEffectParam4.Invoke((MethodInvoker)(() => kEffectParam4.LabelText = "n/a"));
                break;
            case (int)EffectType.AllPass:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "All Pass Filter"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                kEffectParam3.Invoke((MethodInvoker)(() => kEffectParam3.LabelText = "n/a"));
                kEffectParam4.Invoke((MethodInvoker)(() => kEffectParam4.LabelText = "n/a"));
                break;
            case (int)EffectType.FeedbackComb:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Feedback Comb Filter"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                kEffectParam3.Invoke((MethodInvoker)(() => kEffectParam3.LabelText = "n/a"));
                kEffectParam4.Invoke((MethodInvoker)(() => kEffectParam4.LabelText = "n/a"));
                break;
            case (int)EffectType.FeedForwardComb:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Feed Forward Comb Filter"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                kEffectParam3.Invoke((MethodInvoker)(() => kEffectParam3.LabelText = "n/a"));
                kEffectParam4.Invoke((MethodInvoker)(() => kEffectParam4.LabelText = "n/a"));
                break;
            default:
                break;
        }
        effects.Param1 = kEffectParam1.Value;
        effects.Param2 = kEffectParam2.Value;
        effects.Param3 = kEffectParam3.Value;
        effects.Param4 = kEffectParam4.Value;
    }


    private void CmdInit_Click(object? sender, EventArgs e) {
        var knobs = this.Controls.OfType<UI.Controls.Knob>();
        foreach (var k in knobs)
            k.Init();
    }


    #endregion

    #region Control Group Selection
    const int MAX_KNOBS_IN_GROUP = 4;
    Dictionary<string, Led> groupLeds = new();


    //         knobGroup    knobName
    Dictionary<string, List<string>> knobGroups = new();


    private void InitControlGroupLeds() {
        groupLeds.Add(ledVCO1.ID, ledVCO1);
        groupLeds.Add(ledVCO2.ID, ledVCO2);
        groupLeds.Add(ledVCO3.ID, ledVCO3);
        groupLeds.Add(ledLFO.ID, ledLFO);
        groupLeds.Add(ledMixer.ID, ledMixer);
        groupLeds.Add(ledBitCrush.ID, ledBitCrush);
        groupLeds.Add(ledVCF.ID, ledVCF);
        groupLeds.Add(ledEnv1.ID, ledEnv1);
        groupLeds.Add(ledEnv2.ID, ledEnv2);
        groupLeds.Add(ledEnv3.ID, ledEnv3);
        groupLeds.Add(ledEffects.ID, ledEffects);

        foreach (var l in groupLeds)
            l.Value.Clicked += Value_Clicked;



        knobGroups.Add("VCO1", new List<string>() { "kOsc1Freq", "kOsc1Octave", "kOsc1Waveform", "kOsc1PW" });
        knobGroups.Add("VCO2", new List<string>() { "kOsc2Freq", "kOsc2Octave", "kOsc2Waveform", "kOsc2PW" });
        knobGroups.Add("VCO3", new List<string>() { "kOsc3Freq", "kOsc3Octave", "kOsc3Waveform", "kOsc3PW" });
        knobGroups.Add("LFO", new List<string>() { "kLfo1Rate", "kLfo1Shape", "kLfo2Rate", "kLfo2Shape" });
        knobGroups.Add("MIXER", new List<string>() { "kOsc1Mix", "kOsc2Mix", "kOsc3Mix", "kNoiseMix" });
        knobGroups.Add("BITCRUSH", new List<string>() { "kBitCrushSampleRate", "kBitCrushResolution" });
        knobGroups.Add("VCF", new List<string>() { "kVcfType", "kVcfCutoff", "kVcfResonance", "kVcfEnvelope" });
        knobGroups.Add("ENV1", new List<string>() { "kEnv1Attack", "kEnv1Decay", "kEnv1Sustain", "kEnv1Release" });
        knobGroups.Add("ENV2", new List<string>() { "kEnv2Attack", "kEnv2Decay", "kEnv2Sustain", "kEnv2Release" });
        knobGroups.Add("ENV3", new List<string>() { "kEnv3Attack", "kEnv3Decay", "kEnv3Sustain", "kEnv3Release" });
        knobGroups.Add("EFFECTS", new List<string>() { "kEffectType", "kEffectParam1", "kEffectParam2", "kEffectBalance" });


    }


    private void Value_Clicked(object? sender, Led.Enums.LedState e) {
        Debug.Assert(sender != null);
        Led led = (Led)sender;

        if (e == Led.Enums.LedState.On) {
            // Turn other off
            foreach (var l in groupLeds) {
                if (l.Key != led.ID)
                    l.Value.LedState = Led.Enums.LedState.Off;
            }

            // Connect Group specific Midi Controllers
            var knobGroup = knobGroups[led.ID];

            var mapping = Json<List<ControlKnobMap>>.Load(Constants.MIDI_TO_KNOB_MAPPING_FILE);
            var knobs = this.Controls.OfType<UI.Controls.Knob>();
            controlMap.Clear();

            int knobNo = 0;
            foreach (var m in mapping) {
                if (knobNo >= knobGroup.Count || knobNo >= MAX_KNOBS_IN_GROUP) {
                    // We've run out of Knob Group items, so use defaults
                    controlMap.Add(m.ControllerID, knobs.Where(k => k.Name == m.KnobName).First());
                } else {
                    // Using selected Knob Group
                    controlMap.Add(m.ControllerID, knobs.Where(k => k.Name == knobGroup[knobNo]).First());
                }

                knobNo++;

            }



        } else {
            // Connect default Midi Controllers
            SetupDefaultMidiControllers();
        }




    }



    #endregion

    #region Setup Midi Controllers
    private void SetupDefaultMidiControllers() {
        var mapping = Json<List<ControlKnobMap>>.Load(Constants.MIDI_TO_KNOB_MAPPING_FILE);
        var knobs = this.Controls.OfType<UI.Controls.Knob>();
        controlMap.Clear();

        foreach (var m in mapping) {
            controlMap.Add(m.ControllerID, knobs.Where(k => k.Name == m.KnobName).First());
        }
    }

    #endregion
}



