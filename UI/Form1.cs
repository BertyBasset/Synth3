// To DO
//.5 Labels for Waveform/Octave knobs
// 1 Switches
// 2 Easy way of binding controls to synth
// 3 Hook up UI to Synth
// 4 Stop flickering when redrawing
// 5 Smoother mouse operation
// 6 Modulaiton MAtrix System
// 7 Patch Save/REcall
// 8 Effects Section
// 9 Midi filter, show gate



using Synth.IO;
using Synth.Modules.Modifiers;
using Synth.Modules.Modifiers.Filters;
using Synth.Modules.Modulators;
using Synth.Modules.Sources;
using Synth.Properties;
using SynthEngine.Modules.Modulators;

namespace UI;
public partial class Form1 : Form {

    Synth.SynthEngine engine = new Synth.SynthEngine();
    ModWheel mw = new();
    Keyboard kbd = new();
    VCO vco1 = new();
    VCO vco2 = new();
    VCO vco3 = new();
    // Add noise module
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
    }

    void InitSynth() {
        vco1.Frequency.Keyboard = kbd;
        vco1.WaveFormSelectByID(1);
        //vco1.Frequency.pi


        vco2.Frequency.Keyboard = kbd;
        vco2.Frequency.FineTune = .01;
        vco2.Frequency.Octave = -1;
        vco2.WaveFormSelectByID(2);

        vco3.Frequency.Keyboard = kbd;
        vco3.Frequency.FineTune = -.01;
        vco3.Frequency.Octave = -1;
        vco3.WaveFormSelectByID(3);

        m.Sources.Add(vco1);
        m.Sources.Add(vco2);
        m.Sources.Add(vco3);
        // Add noise module
        m.Levels[0] = 1;
        m.Levels[1] = 1;
        m.Levels[2] = 1;

        env1.Keyboard = kbd;

        vcf.Source = m;
        vcf.FilterType = VCF.eFilterType.Butterworth;
        vcf.Modulator = mw;

        env2.Keyboard = kbd;

        vca.Source = vcf;
        vca.Modulator = env2;

        output.Source = vca;

        engine.Modules.Add(mw);
        engine.Modules.Add(kbd);
        engine.Modules.Add(vco1);
        engine.Modules.Add(vco2);
        engine.Modules.Add(vco3);
        // Add Noise module
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


        ctls.Register(kLfo1Rate, lfo1, "Frequency");
        ctls.Register(kLfo1Shape, lfo1, "WaveForm");
        ctls.Register(kLfo2Rate, lfo2, "Frequency");
        ctls.Register(kLfo2Shape, lfo2, "WaveForm");
        ctls.Register(kVcfType, vcf, "FilterType");
        ctls.Register(kVcfCutoff, vcf, "Cutoff");
        ctls.Register(kVcfResonance, vcf, "Resonance");
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
}
