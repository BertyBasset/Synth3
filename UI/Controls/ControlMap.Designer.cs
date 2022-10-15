namespace UI.Controls {
    partial class ControlMap {
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
            this.cboController = new System.Windows.Forms.ComboBox();
            this.cboKnob = new System.Windows.Forms.ComboBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboController
            // 
            this.cboController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboController.FormattingEnabled = true;
            this.cboController.Location = new System.Drawing.Point(0, 0);
            this.cboController.Name = "cboController";
            this.cboController.Size = new System.Drawing.Size(216, 23);
            this.cboController.TabIndex = 0;
            // 
            // cboKnob
            // 
            this.cboKnob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKnob.FormattingEnabled = true;
            this.cboKnob.Location = new System.Drawing.Point(219, 0);
            this.cboKnob.Name = "cboKnob";
            this.cboKnob.Size = new System.Drawing.Size(180, 23);
            this.cboKnob.TabIndex = 1;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(401, -1);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(25, 25);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "X";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // ControlMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cboKnob);
            this.Controls.Add(this.cboController);
            this.Name = "ControlMap";
            this.Size = new System.Drawing.Size(439, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboController;
        private ComboBox cboKnob;
        private Button cmdDelete;
    }
}
