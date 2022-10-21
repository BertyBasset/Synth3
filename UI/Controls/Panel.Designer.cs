namespace UI.Controls {
    partial class Panel {
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
            this.components = new System.ComponentModel.Container();
            this.lblLabelText = new System.Windows.Forms.Label();
            this.tipToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblLabelText
            // 
            this.lblLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabelText.AutoSize = true;
            this.lblLabelText.Location = new System.Drawing.Point(183, -3);
            this.lblLabelText.Name = "lblLabelText";
            this.lblLabelText.Size = new System.Drawing.Size(38, 15);
            this.lblLabelText.TabIndex = 0;
            this.lblLabelText.Text = "label1";
            this.lblLabelText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tipToolTip
            // 
            this.tipToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipToolTip.ToolTipTitle = "Click";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLabelText);
            this.Name = "Panel";
            this.Size = new System.Drawing.Size(418, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLabelText;
        private ToolTip tipToolTip;
    }
}
