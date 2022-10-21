

namespace UI.Controls {
    public partial class Switch : UserControl, iControl {
        // Event with Value prop
        public event EventHandler<double>? ValueChanged;

        #region Contructor
        public Switch() {
            InitializeComponent();

            this.Paint += Switch_Paint;
            this.Resize += (o, e) => DrawSwitch();
            this.MouseUp += Switch_MouseUp;
        }

        private void Switch_MouseUp(object? sender, MouseEventArgs e) {
            var pos = e.Y / (this.Height / _numpositions);
            if (pos < 0)
                pos = 0;
            if(pos>=_numpositions-1)
                pos = _numpositions - 1;

            if (pos != _value)
                Value = pos;
        }

        #endregion

        #region Public Properties
        // Rather than true/false or an enum, 
        private double _value;
        public double Value {
            get { return _value; }
            set {
                bool changed = _value != value;
                _value = value;

                if (changed) {
                    ValueChanged?.Invoke(this, _value);
                    DrawSwitch();
                }
            }
        }

        private int _numpositions = 2;
        public int NumPositions {
            get { return (_numpositions < 2 ? 2 : _numpositions); }
            set {
                _numpositions = value < 2 ? 2 : value;
                DrawSwitch();
            }
        }

        private int _thickness = 1;
        public int Thickness {
            get { return _thickness; }
            set {
                _thickness = value;
                DrawSwitch();
            }
        }

        private Color _outlinecolor;
        public Color OutilneColor {
            get { return _outlinecolor; }
            set {
                _outlinecolor = value;
                DrawSwitch();
            }
        }

        private Color _actuatoroutlinecolor;
        public Color ActuatorOutilneColor {
            get { return _actuatoroutlinecolor; }
            set {
                _actuatoroutlinecolor = value;
                DrawSwitch();
            }
        }

        private Color _actuatorfillcolor;
        public Color ActuatorFillColor {
            get { return _actuatorfillcolor; }
            set {
                _actuatorfillcolor = value;
                DrawSwitch();
            }
        }


        #endregion

        #region Draw Switch
        private void Switch_Paint(object? sender, PaintEventArgs? e) {
            DrawSwitch();
        }

        void DrawSwitch() {
            var g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawRectangle(new Pen(_outlinecolor, (float)_thickness), 0, 0, this.Width-1, this.Height -1);

            g.FillRectangle(new SolidBrush(_actuatorfillcolor), _thickness, _thickness - 1 + ((this.Height - _thickness * 2) / (int)_numpositions) * (int)_value + 1, this.Width - (2 * _thickness) - 1, (this.Height / _numpositions) - _thickness);
            g.DrawRectangle(new Pen(_actuatoroutlinecolor, 2), _thickness , _thickness - 1 + ((this.Height - _thickness * 2) / (int)_numpositions) * (int)_value + 1, this.Width - (2 * _thickness)-1 , (this.Height / _numpositions)-_thickness);
        }
        #endregion
    }
}