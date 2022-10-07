using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls {
    public partial class Knob : UserControl {
        public string LabelText {
            get { return lblLabelText.Text; }
            set { lblLabelText.Text = value; }  
        }

        private int _margin = 17;
        public new int Margin {
            get { return _margin; }
            set {
                _margin = value;
                if (_margin < 0)
                    _margin = 0;
                if (_margin > 30)
                    _margin = 30;

                Knob_Paint(this, null);
            }
        }


        private int _thickness = 1;
        public int Thickness {
            get { return _thickness; }
            set {
                _thickness = value;
                if (_thickness < 0)
                    _thickness = 0;
                if (_thickness > 10)
                    _thickness = 10;

                Knob_Paint(this, null);
            }
        }


        private double _min = 0;
        public double Min {
            get { return _min; }
            set {
                _min = value;
                if (_min < -100)
                    _min = -100;
                if (_min > 0)
                    _min = 0;
                if (_value < _min)
                    _value = _min;

                Knob_Paint(this, null);
            }
        }

        private double _max = 100;
        public double Max {
            get { return _max; }
            set {
                _max = value;
                if (_max < 0)
                    _max = 0;
                if (_max > 100)
                    _max = 100;
                if (_value > _max)
                    _value = _max;

                Knob_Paint(this, null);
            }
        }

        private double _value = 0;
        public double Value {
            get { return _value; }
            set {
                _value = value;
                if (_value < _min)
                    _value = _min;
                if (_value > _max)
                    _value = _max;

                Knob_Paint(this, null);
            }
        }




        private int Percent {
            get { 
                return (int)((_value - _min) / (_max - _min) * 100);
               
            }
        }




        public Knob() {
            InitializeComponent();
            this.Paint += Knob_Paint;
            this.Resize += (o, e) => DrawKnob();
            this.ForeColorChanged += (o, e) => lblLabelText.ForeColor = ForeColor;
            
        }

        private void Knob_Paint(object? sender, PaintEventArgs? e) {
            DrawKnob();
        }

        void DrawKnob() {
            var g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.Clear(BackColor);

            Pen pen = new Pen(new SolidBrush(ForeColor), _thickness);



            int radius = this.Width / 2 - _margin;
            Point pCentre = new Point(this.Width / 2, this.Height / 2);
            int angle = 270 * Percent /100;
            int a = 270 - angle;
            Point pPointer = new Point((int)(this.Width / 2 +  radius * Math.Sin((45 +a) * Math.PI / 180)), (int)(this.Height / 2 + radius * Math.Cos((45 + a) * Math.PI / 180)));

            

            g.DrawEllipse(pen, new Rectangle(new Point(_margin, _margin), new Size(this.Width - _margin*2, this.Height - _margin*2)));
            g.DrawLine(pen, pCentre, pPointer);
           


        }




    }
}
