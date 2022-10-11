using Synth;
using System.Diagnostics;

namespace UI;
public partial class frmWaveViewer : Form {
    private Synth.SynthEngine? _synthEngine;

    public frmWaveViewer(Synth.SynthEngine SynthEngine) {
        try {
            Debug.Assert(SynthEngine != null);
            _synthEngine = SynthEngine;

            InitializeComponent();

            SynthEngine.GraphUpdated += (o, e) => {
                DrawGraph(e);
                DrawSpectrum(e);

            };
        } catch (Exception) { }
    }

    private void DrawGraph(List<double> data) {
        // Array of Doubles passed in

        var p = new Pen(Color.Lime);

        Point[] points = new Point[data.Count];
        for (int i = 0; i < data.Count; i++) {
            points[i] = new Point(i * picGraph.Width / data.Count, (int)(data[i] * picGraph.Height * .6f + picGraph.Height / 2));
        }
        if (!this.Visible)
            return;
        Graphics g = picGraph.CreateGraphics();
        g.Clear(Color.Black);
        g.DrawLines(p, points);
    }

    private async void DrawSpectrum(List<double> data) {
        var s = await Task.Run(() => GetSpectrum(data.ToArray()));

        double maxCoeff = s.MaxBy(x => x);
        if (maxCoeff < .01)
            maxCoeff = 0.01;

        Point[] spectrum = new Point[s.Length];
        for (int i = 0; i < s.Length; i++)
            spectrum[i] = new Point(i * 7, picGraph.Height - (int)((s[i] * picGraph.Height * .95 / maxCoeff) - 1));

        var p = new Pen(Color.CornflowerBlue);
        if (!this.Visible)
            return;

        Graphics g = picGraph.CreateGraphics();
        g.DrawLines(p, spectrum);


    }

    private double[] GetSpectrum(double[] signal) {
        var extract = signal[0..512];


        // Uses nuget package from https://github.com/swharden/FftSharp

        // Begin with an array containing sample data
        //double[] signal = FftSharp.SampleData.SampleAudiosc1();

        // Shape the signal using a Hanning window
        var window = new FftSharp.Windows.Hanning();
        window.ApplyInPlace(extract);

        // Calculate the FFT as an array of complex numbers
        // Complex[] fftRaw = FftSharp.Transform.FFT(signal);

        // or get the magnitude (units²) or power (dB) as real numbers
        double[] fftMag = FftSharp.Transform.FFTmagnitude(extract);
        return fftMag;
    }

}

