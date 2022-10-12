namespace UI {
    partial class frmWaveViewer {
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
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.chkSpectrum = new System.Windows.Forms.CheckBox();
            this.chkWave = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // picGraph
            // 
            this.picGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGraph.BackColor = System.Drawing.Color.Black;
            this.picGraph.Location = new System.Drawing.Point(-4, -1);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(534, 256);
            this.picGraph.TabIndex = 0;
            this.picGraph.TabStop = false;
            // 
            // chkSpectrum
            // 
            this.chkSpectrum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSpectrum.AutoSize = true;
            this.chkSpectrum.BackColor = System.Drawing.Color.Black;
            this.chkSpectrum.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSpectrum.Checked = true;
            this.chkSpectrum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpectrum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSpectrum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.chkSpectrum.Location = new System.Drawing.Point(448, 233);
            this.chkSpectrum.Name = "chkSpectrum";
            this.chkSpectrum.Size = new System.Drawing.Size(74, 19);
            this.chkSpectrum.TabIndex = 1;
            this.chkSpectrum.Text = "Spectrum";
            this.chkSpectrum.UseVisualStyleBackColor = false;
            // 
            // chkWave
            // 
            this.chkWave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWave.AutoSize = true;
            this.chkWave.BackColor = System.Drawing.Color.Black;
            this.chkWave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkWave.Checked = true;
            this.chkWave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkWave.ForeColor = System.Drawing.Color.Lime;
            this.chkWave.Location = new System.Drawing.Point(470, 213);
            this.chkWave.Name = "chkWave";
            this.chkWave.Size = new System.Drawing.Size(52, 19);
            this.chkWave.TabIndex = 2;
            this.chkWave.Text = "Wave";
            this.chkWave.UseVisualStyleBackColor = false;
            // 
            // frmWaveViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 254);
            this.Controls.Add(this.chkWave);
            this.Controls.Add(this.chkSpectrum);
            this.Controls.Add(this.picGraph);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWaveViewer";
            this.Text = "Wave Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picGraph;
        private CheckBox chkSpectrum;
        private CheckBox chkWave;
    }
}