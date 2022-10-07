// To Do
// VCF - test modes
// Mod Wheel 
// 4 knobs


// See https://aka.ms/new-console-template for more information
using NAudio.Mixer;
using Synth;
using Synth.IO;
using Synth.Modules.Modifiers;
using Synth.Modules.Modifiers.Filters;
using Synth.Modules.Modulators;
using Synth.Modules.Sources;
using SynthEngine.Modules.Modulators;

Synth.SynthEngine engine = new Synth.SynthEngine();
ModWheel mw = new();
Keyboard kbd = new();
VCO vco1 = new();
VCO vco2 = new();
VCO vco3 = new();
Synth.Modules.Modifiers.Mixer m = new();
Synth.Modules.Modifiers.Filters.VCF vcf = new();
VCA vca = new();
EnvGen env1 = new();
EnvGen env2 = new();

AudioOut output = new();





init();

while (1 == 1)
    loop();






void init() {
    
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
    m.Levels[0] = 1;
    m.Levels[1] = 1;
    m.Levels[2] = 1;

    env1.Keyboard = kbd;
    env1.Release = .2;
    env1.Decay= .2;



    vcf.Source = m;
    vcf.FilterType = VCF.eFilterType.Notch;
    vcf.Cutoff = 1.2;
    vcf.Modulator = mw;
    vcf.Resonance = 5;



    env1.Keyboard = kbd;
    env1.Release = 1;

    vca.Source = vcf;
    vca.Modulator = env1;

    output.Source = vca;


    engine.Modules.Add(mw);
    engine.Modules.Add(kbd);
    engine.Modules.Add(vco1);
    engine.Modules.Add(vco2);
    engine.Modules.Add(vco3);
    engine.Modules.Add(m);
    engine.Modules.Add(env1);
    engine.Modules.Add(vcf);
    engine.Modules.Add(vca);


    engine.Modules.Add(output);
    

    



}

void loop() {
    System.Threading.Thread.Sleep(1000);
    


}


