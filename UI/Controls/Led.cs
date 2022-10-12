using static UI.Controls.Knob;

namespace UI.Controls;
public partial class Led : UserControl {
    public Led() {
        InitializeComponent();
        this.Paint += Led_Paint;
        this.Resize += (o, e) => DrawLed();


    }

    private Color _ledcolor;
    public Color LedColor {
        get { return _ledcolor; }
        set {
            _ledcolor = value;
            Led_Paint(this, null);
        }
    }

    public class Enums {
        public enum LedState {
            Off,
            On
        }
    }
    private Enums.LedState _ledstate;
    public Enums.LedState LedState {
        get { return _ledstate; }
        set {
            _ledstate = value;
            Led_Paint(this, null);
        }
    }


    private void Led_Paint(object? sender, PaintEventArgs? e) {
        DrawLed();
    }

    void DrawLed() {
        var g = this.CreateGraphics();
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        Pen pen = new Pen(new SolidBrush(ForeColor), 1);

        Color c = _ledcolor;
        if (LedState == Enums.LedState.Off) {
            c = Color.FromArgb((int)((double)c.R * .3), (int)((double)c.G * .3), (int)((double)c.B * .3));
        }


        g.FillEllipse(new SolidBrush(c), 1, 1, this.Width - 3, this.Height - 3);
        
        
        g.DrawEllipse(pen, 1, 1, this.Width - 3, this.Height - 3);
        

    }
}
