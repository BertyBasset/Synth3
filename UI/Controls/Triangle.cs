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
    public partial class Triangle : UserControl {
        public Triangle() {
            InitializeComponent();
            this.Paint += Triangle_Paint;
            this.Resize += (o, e) => DrawTriangle();
        }

        private int _thickness = 1;
        public int Thickness {
            get { return _thickness; }
            set {
                _thickness = value;
            }
        }


        public string Label { 
            get { return lblLabel.Text; }
            set { lblLabel.Text = value; }
        
        }


        private void Triangle_Paint(object? sender, PaintEventArgs? e) {
            DrawTriangle();
        }

        void DrawTriangle() {
            lblLabel.Top = this.Height / 2-6;

            var g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(new SolidBrush(ForeColor), _thickness);

            g.DrawLine(pen, new Point(0, 0), new Point(this.Width - 1, this.Height / 2));
            g.DrawLine(pen, new Point(0, this.Height-1), new Point(this.Width- 1, this.Height / 2));
            g.DrawLine(pen, new Point(0, 0), new Point(0, this.Height-1 ));




        }
    }
}
