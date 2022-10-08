namespace UI {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.knob1 = new UI.Controls.Knob();
            this.SuspendLayout();
            // 
            // knob1
            // 
            this.knob1.BackColor = System.Drawing.Color.Navy;
            this.knob1.Divisions = 10;
            this.knob1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.knob1.LabelText = "Test";
            this.knob1.Location = new System.Drawing.Point(215, 127);
            this.knob1.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Dot;
            this.knob1.Max = 1D;
            this.knob1.Min = 0D;
            this.knob1.Name = "knob1";
            this.knob1.Size = new System.Drawing.Size(90, 95);
            this.knob1.TabIndex = 0;
            this.knob1.Thickness = 2;
            this.knob1.Value = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.knob1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Knob knob1;
    }
}