using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace UI.Controls {
    public partial class Knob : UserControl {
        // To DO
        // 1 Easy way of binding controls to synth
        // 2 Stop flickering when redrawing
        // 3 Smoother mouse operation
        // 4 Limit to Divisions peoperty  DONE

        int _oldIntValue = 0;


        // Event with Value prop
        public event EventHandler<double>? ValueChanged;
        public event EventHandler<int>? IntValueChanged;

        public enum MarkerStyleEnum {
            Line = 0,
            Dot
        }

        public bool HideLabels {
            get { return !lbl0.Visible; }
            set {
                lbl0.Visible = !value;
                lbl10.Visible = !value;
            }
        }

        private MarkerStyleEnum _markerStyle;
        public MarkerStyleEnum MarkerStyle {
            get { return _markerStyle; }
            set {
                _markerStyle = value;
                Knob_Paint(this, null);
            }
        }

        private bool _limitToDivisions;
        public bool LimitToDivisions {
            get { return _limitToDivisions; }
            set {
                _limitToDivisions = value;
            }
        }


        private int _sweepAngle = 270;
        public int SweepAngle {
            get { return _sweepAngle; }
            set {
                _sweepAngle = value;
                if (_sweepAngle == 0)
                    _sweepAngle = 270;
                if (_sweepAngle < 45)
                    _sweepAngle = 45;
                if (_sweepAngle > 360)
                    _sweepAngle = 360;


                Knob_Paint(this, null);
            }
        }



        private int _divisions;
        public int Divisions {
            get { return _divisions; }
            set {
                _divisions = value;
                if (_divisions < 0)
                    _divisions = 0;
                if (_divisions > 10)
                    _divisions = 10;
                Knob_Paint(this, null);
            }
        }



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


        private double __v;
        private double _v {
            get { return __v; }
            set {
                __v = value;

                if (!LimitToDivisions)
                    Value = __v;
                else {
                    var newValue = (Math.Round(__v / Divisions));
                    if (newValue < Min)
                        newValue = Min;
                    if (newValue > Max)
                        newValue = Max;


                    if (newValue != Value)
                        Value = newValue;
                }
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

                _intValue = (int)Math.Round(_value);
                if (_intValue != _oldIntValue) {
                    if (IntValueChanged != null) {
                        IntValueChanged(this, _intValue);
                    }
                    _oldIntValue = _intValue;
                }



                Knob_Paint(this, null);

                // Raise Value Changed Event
                if (ValueChanged != null) {
                    ValueChanged(this, _value);
                }

            }
        }

        private int _intValue = 0;
        public int IntValue {
            get { return _intValue; }
        }



        private int Percent {
            get { 
                // Percent Value compared to range (Max - Min)
                return (int)((_value - _min) / (_max - _min) * 100);
            }
        }




        bool mouseDown = false;
        Point startPos;
        public Knob() {
            InitializeComponent();
            this.Paint += Knob_Paint;
            this.Resize += (o, e) => DrawKnob();
            this.ForeColorChanged += (o, e) => lblLabelText.ForeColor = ForeColor;

            // Knob Move events
            this.MouseDown += (o, e) => { mouseDown = true; startPos = new Point(e.X, e.Y); };
            this.MouseUp += (o, e) => mouseDown = false;
            this.MouseMove += (o, e) => {
                if (mouseDown) {
                    var currenPos = new Point(e.X, e.Y);

                    var change = currenPos.Y - startPos.Y;
                    _v = _v- (Max- Min)* change/1000 ;
                }
            };
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
         


            Point pCentre = new Point(this.Width / 2, this.Height / 2-4);
            int angle = SweepAngle * Percent /100;
            int a = SweepAngle - angle;

            int anlgeStart = (360 - SweepAngle) / 2;

            Point pPointer = new();
            if(MarkerStyle == MarkerStyleEnum.Line)
                pPointer = new Point((int)(pCentre.X +  radius * Math.Sin((anlgeStart + a) * Math.PI / 180)), (int)(pCentre.Y + radius * Math.Cos((anlgeStart + a) * Math.PI / 180)));
            else
                pPointer = new Point((int)(pCentre.X / 2 + (radius - 4) * Math.Sin((anlgeStart + a) * Math.PI / 180)), (int)(pCentre.Y + (radius -4) * Math.Cos((anlgeStart + a) * Math.PI / 180)));


            g.DrawEllipse(pen, new Rectangle(new Point(_margin, _margin-4), new Size(this.Width - _margin*2, this.Height - _margin*2)));



            if(MarkerStyle == MarkerStyleEnum.Dot)
                g.FillEllipse(new SolidBrush(ForeColor), new Rectangle(pPointer.X -5, pPointer.Y - 5, 8, 8));
            else
                g.DrawLine(pen, pCentre, pPointer);


            if (Divisions > 0) {
                for (int i = 0; i <= Divisions; i++) {
                    int  x = SweepAngle / Divisions * i;

                    Point p1 = new Point((int)(pCentre.X + (radius + 5) * Math.Sin((x+ anlgeStart) * Math.PI / 180)), (int)(pCentre.Y + (radius+5) * Math.Cos((x + anlgeStart) * Math.PI / 180)));
                    Point p2 = new Point((int)(pCentre.X  + (radius + 9) * Math.Sin(( x + anlgeStart) * Math.PI / 180)), (int)(pCentre.Y + (radius + 9) * Math.Cos((x + anlgeStart) * Math.PI / 180)));
                    g.DrawLine(new Pen(new SolidBrush(ForeColor), 1), p1, p2);

                }
            
            
            
            
            
            }




        }




    }
}
