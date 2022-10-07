namespace UI.Controls {
    partial class Knob {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLabelText
            // 
            this.lblLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabelText.ForeColor = System.Drawing.Color.Black;
            this.lblLabelText.Location = new System.Drawing.Point(0, 136);
            this.lblLabelText.Name = "lblLabelText";
            this.lblLabelText.Size = new System.Drawing.Size(152, 16);
            this.lblLabelText.TabIndex = 0;
            this.lblLabelText.Text = "label1";
            this.lblLabelText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Knob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLabelText);
            this.Name = "Knob";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblLabelText;
    }
}
