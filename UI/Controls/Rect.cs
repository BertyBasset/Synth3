namespace UI.Controls;

public partial class Rect : UserControl {
    public Color Color { 
        get { return this.BackColor; }
        set { this.BackColor = value; }
    
    }


    public Rect() {
        InitializeComponent();
    }
}

