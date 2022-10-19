﻿using Synth.Modules.Modifiers.Filters.Types;
using Synth;
using System.Diagnostics;
using System.Windows.Forms;
using static Synth.Enums;

namespace Synth.Modules.Modifiers.Filters {

    //  Need to calibrate cutoff and modulator properties




    public class VCF : iModule {

        #region Public Properties

        private iModule? _source;
        public iModule? Source {
            get { return _source; }
            set { 
                Debug.Assert(value != null);
                _source = value;
                _Filter.Source = _source; 
            }
        }

        private double _cutoff;
        public double Cutoff {
            get { return _cutoff; }
            set {
                _cutoff = value;
                _Filter.Cutoff = _cutoff; }
        }



        private double _modamount;
        public double ModAmount {
            get { return _modamount; }
            set {
                _modamount = value;
                _Filter.ModAmount = _modamount;
            }
        }


        private iModule? _modulator;
        public iModule? Modulator {
            get { return _modulator; }
            set {
                Debug.Assert(value != null);
                _modulator = value;
                _Filter.Modulator = _modulator; 
            }
        }

        // Bandpass and Notch only
        private double _bandwidth;
        public double Bandwidth {
            get {
                return _bandwidth;
            }

            set {
                _bandwidth = value;
                if (_Filter.GetType() == typeof(BandPass))
                    ((BandPass)_Filter).Bandwidth = _bandwidth * 1000;
                else if (_Filter.GetType() == typeof(Notch))
                    ((Notch)_Filter).Bandwidth = _bandwidth * 4000;         // Better having a wide noth to hear stuff
            }
        }

        // Butterworth only
        private double _resonance;
        public double Resonance {
            get {
                return _resonance;
            }

            set {
                // For Checby, this is Ripple, for BandPass and Notch it's bandwidth

                _resonance = value;
                if (_Filter.GetType() == typeof(Butterworth))
                    ((Butterworth)_Filter).Resonance = _resonance;
                if (_Filter.GetType() == typeof(Chebyshev))
                    ((Chebyshev)_Filter).RippleFactor = _resonance;
                if (_Filter.GetType() == typeof(BandPass))
                    ((BandPass)_Filter).Bandwidth = _resonance;
                if (_Filter.GetType() == typeof(Notch))
                    ((Notch)_Filter).Bandwidth = _resonance;

            }

        }

        // Chebushev only
        private double _ripplefactor;
        public double RippleFactor {
            get {
                return _ripplefactor;
            }

            set {
                _ripplefactor = value;
                if (_Filter.GetType() == typeof(Chebyshev))
                    ((Chebyshev)_Filter).RippleFactor = _ripplefactor;
            }
        }

        // Notch only  -  We don't have UI control so har code to something that sounds ok
        private double _attenuation = .1;
        public double Attenuation {
            get {
                return _attenuation;
            }

            set {
                _attenuation = value;
                if (_Filter.GetType() == typeof(Notch))
                    ((Notch)_Filter).Attenuation = _attenuation;
            }
        }

        private Enums.FilterType _FilterType;
        public FilterType FilterType { 
            get { return _FilterType; }
            set { _FilterType = value;
                switch (_FilterType) {
                    case FilterType.RC: _Filter = new RC();  break;  
                    case FilterType.Butterworth: _Filter = new Butterworth(); break;
                    case FilterType.Chebyshev: _Filter = new Chebyshev(); break;
                    case FilterType.Bessel: _Filter = new Bessel(); break;
                    case FilterType.BandPass: _Filter = new BandPass(); break;
                    case FilterType.Notch: _Filter = new Notch(); break;
                }
                if(_source != null)
                    _Filter.Source = _source;
                _Filter.Cutoff = _cutoff;
                if(_modulator != null)
                    _Filter.Modulator = _modulator;
                if (_Filter.GetType() == typeof(BandPass))
                    ((BandPass)_Filter).Bandwidth = _bandwidth;
                else if (_Filter.GetType() == typeof(Notch))
                    ((Notch)_Filter).Bandwidth = _bandwidth;
                if (_Filter.GetType() == typeof(Butterworth))
                    ((Butterworth)_Filter).Resonance = _resonance;
                if (_Filter.GetType() == typeof(Chebyshev))
                    ((Chebyshev)_Filter).RippleFactor = _ripplefactor;
                if (_Filter.GetType() == typeof(Notch))
                    ((Notch)_Filter).Attenuation = _attenuation;
            }
        }

        #endregion

        #region Private Properties
        private iFilter _Filter = new RC();
        #endregion

        #region iModule Members
        public double Value {
            get {
                Debug.Assert(_Filter != null);
                return _Filter.Value; 
            }
        }

        public void Tick(double TimeIncrement) {
            Debug.Assert(_Filter != null);
            _Filter.Tick(TimeIncrement);
        }
        #endregion

        #region Static Public Methods
        public static double GetCutoffFrequency(double CV, iModule? Modulator, double ModAmount) {
            return Math.Min(Math.Pow(2, 5 * CV+ 4 * ((Modulator?.Value ?? 0)*ModAmount) + 7), 5000);
        }


        #endregion

    }
}
