// To DO
// 1 Smoother mouse operation
// 2 Effects Section
// 3 Switches


// Then we leave for a month !!


// Version 4
// 5 Modulaiton MAtrix System
// 6 Patch Save/REcall
// 7 Rationalise CV stuff (not sure if needed, but revisit anyway.

// Version 5
// 8. Polyphony !


using Synth.IO;
using Synth.Modules.Modifiers;
using Synth.Modules.Modulators;
using Synth.Modules.Sources;
using SynthEngine.Modules.Modulators;
using SynthEngine.Modules.Sources;
using UI.Code;
using UI.Controls;

namespace UI;
public partial class Form1 : Form {


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

    Synth.Modules.Modifiers.Mixer m = new();
    Synth.Modules.Modifiers.Filters.VCF vcf = new();
    VCA vca = new();
    EnvGen env1 = new();
    EnvGen env2 = new();
    EnvGen env3 = new();
    AudioOut output = new();

    // ControlHandler - this takes care of binding controls to synth modules, and plumbs events when control value changes
    ControlHandler ctls = new();


    public Form1() {
        InitializeComponent();
        InitSynth();

        kVcfType.ValueChanged += (o, e) => FilterTypeChanged();
        cmdViewWave.Click += (o, e) => { 
            var viewer = new frmWaveViewer(engine);
            viewer.Show();
        };
        

        
        // Midi Controller Event Handler
        Dictionary<int, Knob> controlMap = new();
        controlMap.Add(74, kVcfType);
        controlMap.Add(75, kVcfCutoff);
        controlMap.Add(76, kVcfResonance);
        controlMap.Add(77, kEnv1Release);
        mc.ControllerValueChanged += (o, e) => {
            const double MAX_RANGE = 128;
            if (!controlMap.ContainsKey(e.ControllerID))
                return;         // Unhandled Controller


            var knob = controlMap[e.ControllerID];

            if (knob.LimitToDivisions) {
                var newValue = Math.Round(((double)e.Value / MAX_RANGE) * (double)(knob.Max - knob.Min) + knob.Min);
                if (knob.Value != newValue)
                    knob.Value = newValue;
            } else {
                knob.Value = ((double)e.Value / MAX_RANGE) * (double)(knob.Max - knob.Min) + knob.Min;
            }
        };

        this.FormClosing += (o, e) => Patch.Save(this);
        this.Activated += (o, e) => Patch.Load(this);

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



        //kVcfCutoff.PolarChanged += KVcfCutoff_PolarChanged;

    }

    private void KVcfCutoff_PolarChanged(object? sender, polar e) {
        label1.Text = $"r: {e.r.ToString()}, ang: {e.ang.ToString()}";
    }

    void InitSynth() {
        vco1.Frequency.Keyboard = kbd;
        vco2.Frequency.Keyboard = kbd;
        vco3.Frequency.Keyboard = kbd;

        m.Sources.Add(vco1);
        m.Sources.Add(vco2);
        m.Sources.Add(vco3);
        m.Sources.Add(noise);

        env1.Keyboard = kbd;

        vcf.Source = m;

        //        vcf.Modulator = mw;
        vcf.Modulator = env1;

        env2.Keyboard = kbd;

        vca.Source = vcf;
        vca.Modulator = env2;

        output.Source = vca;

        engine.Modules.Add(mw);
        engine.Modules.Add(kbd);
        engine.Modules.Add(vco1);
        engine.Modules.Add(vco2);
        engine.Modules.Add(vco3);
        engine.Modules.Add(noise);
        engine.Modules.Add(lfo1);
        engine.Modules.Add(lfo2);
        engine.Modules.Add(m);
        engine.Modules.Add(env1);
        engine.Modules.Add(vcf);
        engine.Modules.Add(env2);
        engine.Modules.Add(vca);
        engine.Modules.Add(env3);       // Env3 not connected to anything yet


        engine.Modules.Add(output);

        InitControllers();
    }

    private void InitControllers() {
        // Bind controllers to modules
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
        
        ctls.Register(kOsc1Mix, m, "Levels", 0);
        ctls.Register(kOsc2Mix, m, "Levels", 1);
        ctls.Register(kOsc3Mix, m, "Levels", 2);
        ctls.Register(kNoiseMix, m, "Levels", 3);


        ctls.Register(kLfo1Rate, lfo1, "Frequency");
        ctls.Register(kLfo1Shape, lfo1, "Shape");
        ctls.Register(kLfo2Rate, lfo2, "Frequency");
        ctls.Register(kLfo2Shape, lfo2, "Shape");
        ctls.Register(kVcfType, vcf, "FilterType");
        ctls.Register(kVcfCutoff, vcf, "Cutoff");
        ctls.Register(kVcfResonance, vcf, "Resonance");
        ctls.Register(kVcfResonance, vcf, "Bandwidth");
        ctls.Register(kVcfEnvelope, vcf, "ModAmount");


        //ctls.Register(kVcfEnvelope, vcf.Modulator, "FilterType");     // Need Mod Amount Property
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
    }

    private void FilterTypeChanged() {
        switch (kVcfType.Value) {
            case 0:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass RC 1 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "n/a"));
                break;
            case 1:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Butterworth 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "RESONANCE"));
                break;
            case 2:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Chebyshev 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "RIPPLE"));
                vcf.RippleFactor = kVcfResonance.Value;
                break;
            case 3:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Bessel 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "n/a"));
                break;
            case 4:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Band Pass"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "BANDWIDTH"));
                vcf.Bandwidth = kVcfResonance.Value;
                break;
            case 5:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Notch Pass"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "BANDWIDTH"));
                vcf.Bandwidth = kVcfResonance.Value;

                // Ideally need attenuation as well
                break;
            default: break;
        }
        vcf.ModAmount = kVcfEnvelope.Value;
    }

    private void CmdInit_Click(object? sender, EventArgs e) {
        var knobs = this.Controls.OfType<Knob>();
        foreach (var k in knobs)
            k.Init();
    }


}




