using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synth;


// Hello !!!
// If you add a new enum here, and you use it for a public property of a
// Module that you wish to bind to a UI control, go to ControlHandler of
// the UI project to handle the new enum

public class Enums {
    public enum FilterType {
        RC,
        Butterworth,
        Chebyshev,
        Bessel,
        BandPass,
        Notch
    }
    public enum EffectType {
        Chorus = 0,
        Reverb,
        AllPass,
        FeedbackComb,
        FeedForwardComb,
        BitCrusher
    }





}

