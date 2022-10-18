using Synth;
using System.Diagnostics;

namespace UI;
public partial class frmWaveViewer : Form {
    private Synth.SynthEngine? _synthEngine;

    Font fMarkers;
    Brush bMarkers;
    public frmWaveViewer(Synth.SynthEngine SynthEngine) {
        fMarkers = new Font("Arial", 8);
        bMarkers = new SolidBrush(Color.Cyan);


        try {
            Debug.Assert(SynthEngine != null);
            _synthEngine = SynthEngine;

            InitializeComponent();

            SynthEngine.GraphUpdated += (o, e) => {
                Draw(e);
            };
        } catch (Exception) { }
    }

    private void Draw(List<double> e) {
        Bitmap b = new Bitmap(this.Width, this.Height);
        Graphics g = Graphics.FromImage(b);

        if(chkWave.Checked)
            DrawGraph(g, e);
        if(chkSpectrum.Checked)
            DrawSpectrum(g, e);

        // Copy to screen
        picGraph.Image = b;
    }

    private void DrawGraph(Graphics g, List<double> data) {
        // Array of Doubles passed in

        var p = new Pen(Color.Lime);

        Point[] points = new Point[data.Count];
        for (int i = 0; i < data.Count; i++) {
            points[i] = new Point(i * picGraph.Width / data.Count * 2, (int)(data[i] * picGraph.Height * .6f + picGraph.Height / 2));
        }

        if (!this.Visible)
            return;

        g.Clear(Color.Black);
        g.DrawLines(p, points);
    }

    private async void DrawSpectrum(Graphics g, List<double> data) {
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

        g.DrawLines(p, spectrum);

        int freq = 500;
        for (int i = 0; i < picGraph.Width; i += (int)((double)picGraph.Width / 9.5)) {
            if (i == 0)
                continue;

            var label = $"{(freq < 1000 ? freq : ((int)(freq / 100)) / 10.0)}{(freq < 1000 ? "Hz" : "kHz")}";
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString(label, fMarkers, bMarkers, (float)i, (float)8, sf);
            
            
            g.DrawLine(p, i, 15, i, 20);

            freq += 500;
        }

    }

    private double[] GetSpectrum(double[] signal) {
        // Must be power of 2 samples
        var extract = signal[0..512];
        // Uses nuget package from https://github.com/swharden/FftSharp
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

