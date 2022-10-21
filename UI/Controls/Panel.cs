namespace UI.Controls;
public partial class Panel : UserControl {

    public string LabelText {
        get { return lblLabelText.Text.Trim(); }
        set { 
            lblLabelText.Text = " " + value ;
            lblLabelText.Left = this.Width / 2 - lblLabelText.Width / 2;


            if (lblLabelText.Text == "")
                lblLabelText.Visible = false;
            else
                lblLabelText.Visible = true;


            DrawBorder();
        }
    }


    private Color _forecolor = Color.White;
    public new Color ForeColor {
        get { 
            return _forecolor;
        }
        set {
            _forecolor = value;
            lblLabelText.ForeColor = _forecolor;
        }
    }


    private int _linewidth = 1;
    public int LineWidth {
        get {
            return _linewidth;
        }
        set {
            _linewidth = value;
            DrawBorder();
        }
    }


    private int _cornerradius = 0;
    public int CornerRadius {
        get {
            return _cornerradius;
        }
        set {
            _cornerradius = value;
            DrawBorder();
        }
    }

    public string ID { get; set; } = "";

    private bool _selected;
    public bool Selected { 
        get { return _selected; }
        set { 
            _selected = value; 
        }
    }



    public Panel() {
        InitializeComponent();
        this.Paint += Panel_Paint;
        this.Resize += (o, e) => lblLabelText.Left = this.Width / 2 - lblLabelText.Width / 2;
        BackColorChanged += (o, e) => lblLabelText.BackColor = BackColor;


    }

    private void Panel_Resize(object? sender, EventArgs e) {
        throw new NotImplementedException();
    }

    private void Panel_Paint(object? sender, PaintEventArgs e) {
        lblLabelText.ForeColor = _forecolor;
        DrawBorder();


    }


    int TopMargin = 13;
    new int Margin = 5;
    void DrawBorder() {


        var g = this.CreateGraphics();
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        Pen pen = new Pen(_forecolor, _linewidth);


        g.DrawLine(pen, Margin / 2 + _cornerradius , TopMargin / 2 - 1, this.Width - Margin / 2 - _cornerradius + 1, TopMargin / 2 -1);
        g.DrawLine(pen, this.Width - Margin / 2, TopMargin / 2 + _cornerradius, this.Width - Margin / 2, this.Height - Margin / 2 - _cornerradius);
        g.DrawLine(pen, this.Width - Margin / 2 - _cornerradius, this.Height - Margin / 2, Margin / 2 + _cornerradius, this.Height - Margin / 2);
        g.DrawLine(pen, Margin / 2, this.Height - Margin / 2 - _cornerradius, Margin / 2, TopMargin / 2 + _cornerradius);

        if (_cornerradius > 0) {
            g.DrawArc(pen, new Rectangle(new Point(Margin / 2, TopMargin / 2 - 1), new Size(_cornerradius * 2, _cornerradius * 2)), 170, 110);
            g.DrawArc(pen, new Rectangle(new Point(this.Width - Margin / 2 - _cornerradius * 2, TopMargin / 2 - 1), new Size(_cornerradius * 2, _cornerradius * 2)), 5, -100);
            g.DrawArc(pen, new Rectangle(new Point(this.Width - Margin / 2 - _cornerradius * 2, this.Height - Margin / 2 - _cornerradius * 2 ), new Size(_cornerradius * 2, _cornerradius * 2)), -3, 95);
            g.DrawArc(pen, new Rectangle(new Point(Margin / 2 , this.Height - Margin / 2 - _cornerradius * 2-1), new Size(_cornerradius * 2, _cornerradius * 2)), -176, -100); 
        }

    }

}

