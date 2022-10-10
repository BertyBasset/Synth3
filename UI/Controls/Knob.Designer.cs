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
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
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
            // lbl0
            // 
            this.lbl0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl0.AutoSize = true;
            this.lbl0.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl0.Location = new System.Drawing.Point(3, 123);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(10, 12);
            this.lbl0.TabIndex = 1;
            this.lbl0.Text = "0";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl10
            // 
            this.lbl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl10.Location = new System.Drawing.Point(134, 123);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(15, 12);
            this.lbl10.TabIndex = 2;
            this.lbl10.Text = "10";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl5
            // 
            this.lbl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(34, -16);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(84, 26);
            this.lbl5.TabIndex = 3;
            this.lbl5.Text = "5";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Knob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lblLabelText);
            this.Name = "Knob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLabelText;
        private Label lbl0;
        private Label lbl10;
        private Label lbl5;
    }
}
