namespace UI {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new UI.Controls.Panel();
            this.knob1 = new UI.Controls.Knob();
            this.knob2 = new UI.Controls.Knob();
            this.knob3 = new UI.Controls.Knob();
            this.knob4 = new UI.Controls.Knob();
            this.knob5 = new UI.Controls.Knob();
            this.knob6 = new UI.Controls.Knob();
            this.knob7 = new UI.Controls.Knob();
            this.knob8 = new UI.Controls.Knob();
            this.panel2 = new UI.Controls.Panel();
            this.knob9 = new UI.Controls.Knob();
            this.knob10 = new UI.Controls.Knob();
            this.knob11 = new UI.Controls.Knob();
            this.knob12 = new UI.Controls.Knob();
            this.panel3 = new UI.Controls.Panel();
            this.panel4 = new UI.Controls.Panel();
            this.knob13 = new UI.Controls.Knob();
            this.knob14 = new UI.Controls.Knob();
            this.knob15 = new UI.Controls.Knob();
            this.panel5 = new UI.Controls.Panel();
            this.panel6 = new UI.Controls.Panel();
            this.knob16 = new UI.Controls.Knob();
            this.knob17 = new UI.Controls.Knob();
            this.knob18 = new UI.Controls.Knob();
            this.knob19 = new UI.Controls.Knob();
            this.knob20 = new UI.Controls.Knob();
            this.knob21 = new UI.Controls.Knob();
            this.knob22 = new UI.Controls.Knob();
            this.knob23 = new UI.Controls.Knob();
            this.knob24 = new UI.Controls.Knob();
            this.knob25 = new UI.Controls.Knob();
            this.knob26 = new UI.Controls.Knob();
            this.knob27 = new UI.Controls.Knob();
            this.knob28 = new UI.Controls.Knob();
            this.knob29 = new UI.Controls.Knob();
            this.panel7 = new UI.Controls.Panel();
            this.knob30 = new UI.Controls.Knob();
            this.knob31 = new UI.Controls.Knob();
            this.panel8 = new UI.Controls.Panel();
            this.knob32 = new UI.Controls.Knob();
            this.knob33 = new UI.Controls.Knob();
            this.knob34 = new UI.Controls.Knob();
            this.knob35 = new UI.Controls.Knob();
            this.knob36 = new UI.Controls.Knob();
            this.knob37 = new UI.Controls.Knob();
            this.panel9 = new UI.Controls.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.CornerRadius = 10;
            this.panel1.LabelText = "OSCILLATOR 1";
            this.panel1.LineWidth = 2;
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 105);
            this.panel1.TabIndex = 0;
            // 
            // knob1
            // 
            this.knob1.Divisions = 10;
            this.knob1.ForeColor = System.Drawing.Color.White;
            this.knob1.HideLabels = false;
            this.knob1.LabelText = "FREQUENCY";
            this.knob1.LimitToDivisions = false;
            this.knob1.Location = new System.Drawing.Point(10, 15);
            this.knob1.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob1.Max = 1D;
            this.knob1.Min = 0D;
            this.knob1.Name = "knob1";
            this.knob1.Size = new System.Drawing.Size(77, 77);
            this.knob1.SweepAngle = 270;
            this.knob1.TabIndex = 1;
            this.knob1.Thickness = 2;
            this.knob1.Value = 1D;
            // 
            // knob2
            // 
            this.knob2.Divisions = 4;
            this.knob2.ForeColor = System.Drawing.Color.White;
            this.knob2.HideLabels = true;
            this.knob2.LabelText = "OCTAVE";
            this.knob2.LimitToDivisions = true;
            this.knob2.Location = new System.Drawing.Point(84, 15);
            this.knob2.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob2.Max = 4D;
            this.knob2.Min = 0D;
            this.knob2.Name = "knob2";
            this.knob2.Size = new System.Drawing.Size(77, 77);
            this.knob2.SweepAngle = 135;
            this.knob2.TabIndex = 2;
            this.knob2.Thickness = 2;
            this.knob2.Value = 0D;
            // 
            // knob3
            // 
            this.knob3.Divisions = 10;
            this.knob3.ForeColor = System.Drawing.Color.White;
            this.knob3.HideLabels = false;
            this.knob3.LabelText = "PULSE WIDTH";
            this.knob3.LimitToDivisions = false;
            this.knob3.Location = new System.Drawing.Point(247, 15);
            this.knob3.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob3.Max = 100D;
            this.knob3.Min = 0D;
            this.knob3.Name = "knob3";
            this.knob3.Size = new System.Drawing.Size(77, 77);
            this.knob3.SweepAngle = 270;
            this.knob3.TabIndex = 3;
            this.knob3.Thickness = 2;
            this.knob3.Value = 60D;
            // 
            // knob4
            // 
            this.knob4.Divisions = 4;
            this.knob4.ForeColor = System.Drawing.Color.White;
            this.knob4.HideLabels = true;
            this.knob4.LabelText = "WAVEFORM";
            this.knob4.LimitToDivisions = true;
            this.knob4.Location = new System.Drawing.Point(174, 15);
            this.knob4.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob4.Max = 4D;
            this.knob4.Min = 0D;
            this.knob4.Name = "knob4";
            this.knob4.Size = new System.Drawing.Size(77, 77);
            this.knob4.SweepAngle = 135;
            this.knob4.TabIndex = 4;
            this.knob4.Thickness = 2;
            this.knob4.Value = 0D;
            // 
            // knob5
            // 
            this.knob5.Divisions = 4;
            this.knob5.ForeColor = System.Drawing.Color.White;
            this.knob5.HideLabels = true;
            this.knob5.LabelText = "WAVEFORM";
            this.knob5.LimitToDivisions = true;
            this.knob5.Location = new System.Drawing.Point(174, 126);
            this.knob5.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob5.Max = 4D;
            this.knob5.Min = 0D;
            this.knob5.Name = "knob5";
            this.knob5.Size = new System.Drawing.Size(77, 77);
            this.knob5.SweepAngle = 135;
            this.knob5.TabIndex = 9;
            this.knob5.Thickness = 2;
            this.knob5.Value = 0D;
            // 
            // knob6
            // 
            this.knob6.Divisions = 10;
            this.knob6.ForeColor = System.Drawing.Color.White;
            this.knob6.HideLabels = false;
            this.knob6.LabelText = "PULSE WIDTH";
            this.knob6.LimitToDivisions = false;
            this.knob6.Location = new System.Drawing.Point(247, 126);
            this.knob6.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob6.Max = 100D;
            this.knob6.Min = 0D;
            this.knob6.Name = "knob6";
            this.knob6.Size = new System.Drawing.Size(77, 77);
            this.knob6.SweepAngle = 270;
            this.knob6.TabIndex = 8;
            this.knob6.Thickness = 2;
            this.knob6.Value = 0D;
            // 
            // knob7
            // 
            this.knob7.Divisions = 4;
            this.knob7.ForeColor = System.Drawing.Color.White;
            this.knob7.HideLabels = true;
            this.knob7.LabelText = "OCTAVE";
            this.knob7.LimitToDivisions = true;
            this.knob7.Location = new System.Drawing.Point(84, 126);
            this.knob7.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob7.Max = 4D;
            this.knob7.Min = 0D;
            this.knob7.Name = "knob7";
            this.knob7.Size = new System.Drawing.Size(77, 77);
            this.knob7.SweepAngle = 135;
            this.knob7.TabIndex = 7;
            this.knob7.Thickness = 2;
            this.knob7.Value = 0D;
            // 
            // knob8
            // 
            this.knob8.Divisions = 10;
            this.knob8.ForeColor = System.Drawing.Color.White;
            this.knob8.HideLabels = false;
            this.knob8.LabelText = "FREQUENCY";
            this.knob8.LimitToDivisions = false;
            this.knob8.Location = new System.Drawing.Point(10, 126);
            this.knob8.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob8.Max = 100D;
            this.knob8.Min = 0D;
            this.knob8.Name = "knob8";
            this.knob8.Size = new System.Drawing.Size(77, 77);
            this.knob8.SweepAngle = 270;
            this.knob8.TabIndex = 6;
            this.knob8.Thickness = 2;
            this.knob8.Value = 0D;
            // 
            // panel2
            // 
            this.panel2.CornerRadius = 10;
            this.panel2.LabelText = "OSCILLATOR 2";
            this.panel2.LineWidth = 2;
            this.panel2.Location = new System.Drawing.Point(6, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 105);
            this.panel2.TabIndex = 5;
            // 
            // knob9
            // 
            this.knob9.Divisions = 4;
            this.knob9.ForeColor = System.Drawing.Color.White;
            this.knob9.HideLabels = true;
            this.knob9.LabelText = "WAVEFORM";
            this.knob9.LimitToDivisions = true;
            this.knob9.Location = new System.Drawing.Point(174, 237);
            this.knob9.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob9.Max = 4D;
            this.knob9.Min = 0D;
            this.knob9.Name = "knob9";
            this.knob9.Size = new System.Drawing.Size(77, 77);
            this.knob9.SweepAngle = 135;
            this.knob9.TabIndex = 14;
            this.knob9.Thickness = 2;
            this.knob9.Value = 0D;
            // 
            // knob10
            // 
            this.knob10.Divisions = 10;
            this.knob10.ForeColor = System.Drawing.Color.White;
            this.knob10.HideLabels = false;
            this.knob10.LabelText = "PULSE WIDTH";
            this.knob10.LimitToDivisions = false;
            this.knob10.Location = new System.Drawing.Point(247, 237);
            this.knob10.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob10.Max = 100D;
            this.knob10.Min = 0D;
            this.knob10.Name = "knob10";
            this.knob10.Size = new System.Drawing.Size(77, 77);
            this.knob10.SweepAngle = 270;
            this.knob10.TabIndex = 13;
            this.knob10.Thickness = 2;
            this.knob10.Value = 0D;
            // 
            // knob11
            // 
            this.knob11.Divisions = 4;
            this.knob11.ForeColor = System.Drawing.Color.White;
            this.knob11.HideLabels = true;
            this.knob11.LabelText = "OCTAVE";
            this.knob11.LimitToDivisions = true;
            this.knob11.Location = new System.Drawing.Point(84, 237);
            this.knob11.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob11.Max = 4D;
            this.knob11.Min = 0D;
            this.knob11.Name = "knob11";
            this.knob11.Size = new System.Drawing.Size(77, 77);
            this.knob11.SweepAngle = 135;
            this.knob11.TabIndex = 12;
            this.knob11.Thickness = 2;
            this.knob11.Value = 0D;
            // 
            // knob12
            // 
            this.knob12.Divisions = 10;
            this.knob12.ForeColor = System.Drawing.Color.White;
            this.knob12.HideLabels = false;
            this.knob12.LabelText = "FREQUENCY";
            this.knob12.LimitToDivisions = false;
            this.knob12.Location = new System.Drawing.Point(10, 237);
            this.knob12.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob12.Max = 100D;
            this.knob12.Min = 0D;
            this.knob12.Name = "knob12";
            this.knob12.Size = new System.Drawing.Size(77, 77);
            this.knob12.SweepAngle = 270;
            this.knob12.TabIndex = 11;
            this.knob12.Thickness = 2;
            this.knob12.Value = 0D;
            // 
            // panel3
            // 
            this.panel3.CornerRadius = 10;
            this.panel3.LabelText = "OSCILLATOR 3";
            this.panel3.LineWidth = 2;
            this.panel3.Location = new System.Drawing.Point(6, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 105);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.CornerRadius = 10;
            this.panel4.LabelText = "MIXER";
            this.panel4.LineWidth = 2;
            this.panel4.Location = new System.Drawing.Point(334, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 436);
            this.panel4.TabIndex = 15;
            // 
            // knob13
            // 
            this.knob13.Divisions = 10;
            this.knob13.ForeColor = System.Drawing.Color.White;
            this.knob13.HideLabels = false;
            this.knob13.LabelText = "OSC 1";
            this.knob13.LimitToDivisions = false;
            this.knob13.Location = new System.Drawing.Point(341, 15);
            this.knob13.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob13.Max = 100D;
            this.knob13.Min = 0D;
            this.knob13.Name = "knob13";
            this.knob13.Size = new System.Drawing.Size(77, 77);
            this.knob13.SweepAngle = 270;
            this.knob13.TabIndex = 16;
            this.knob13.Thickness = 2;
            this.knob13.Value = 0D;
            // 
            // knob14
            // 
            this.knob14.Divisions = 10;
            this.knob14.ForeColor = System.Drawing.Color.White;
            this.knob14.HideLabels = false;
            this.knob14.LabelText = "OSC 2";
            this.knob14.LimitToDivisions = false;
            this.knob14.Location = new System.Drawing.Point(340, 126);
            this.knob14.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob14.Max = 100D;
            this.knob14.Min = 0D;
            this.knob14.Name = "knob14";
            this.knob14.Size = new System.Drawing.Size(77, 77);
            this.knob14.SweepAngle = 270;
            this.knob14.TabIndex = 17;
            this.knob14.Thickness = 2;
            this.knob14.Value = 0D;
            // 
            // knob15
            // 
            this.knob15.Divisions = 10;
            this.knob15.ForeColor = System.Drawing.Color.White;
            this.knob15.HideLabels = false;
            this.knob15.LabelText = "OSC 3";
            this.knob15.LimitToDivisions = false;
            this.knob15.Location = new System.Drawing.Point(341, 237);
            this.knob15.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob15.Max = 100D;
            this.knob15.Min = 0D;
            this.knob15.Name = "knob15";
            this.knob15.Size = new System.Drawing.Size(77, 77);
            this.knob15.SweepAngle = 270;
            this.knob15.TabIndex = 18;
            this.knob15.Thickness = 2;
            this.knob15.Value = 0D;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.CornerRadius = 10;
            this.panel5.LabelText = "FILTER - ENV 1";
            this.panel5.LineWidth = 2;
            this.panel5.Location = new System.Drawing.Point(432, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 215);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.CornerRadius = 10;
            this.panel6.LabelText = "AMPLIFIER - ENV 2";
            this.panel6.LineWidth = 2;
            this.panel6.Location = new System.Drawing.Point(432, 224);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 105);
            this.panel6.TabIndex = 20;
            // 
            // knob16
            // 
            this.knob16.BackColor = System.Drawing.Color.Navy;
            this.knob16.Divisions = 4;
            this.knob16.ForeColor = System.Drawing.Color.White;
            this.knob16.HideLabels = true;
            this.knob16.LabelText = "TYPE";
            this.knob16.LimitToDivisions = true;
            this.knob16.Location = new System.Drawing.Point(436, 15);
            this.knob16.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob16.Max = 4D;
            this.knob16.Min = 0D;
            this.knob16.Name = "knob16";
            this.knob16.Size = new System.Drawing.Size(77, 77);
            this.knob16.SweepAngle = 135;
            this.knob16.TabIndex = 21;
            this.knob16.Thickness = 2;
            this.knob16.Value = 0D;
            // 
            // knob17
            // 
            this.knob17.BackColor = System.Drawing.Color.Navy;
            this.knob17.Divisions = 10;
            this.knob17.ForeColor = System.Drawing.Color.White;
            this.knob17.HideLabels = false;
            this.knob17.LabelText = "CUTOFF";
            this.knob17.LimitToDivisions = false;
            this.knob17.Location = new System.Drawing.Point(510, 15);
            this.knob17.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob17.Max = 100D;
            this.knob17.Min = 0D;
            this.knob17.Name = "knob17";
            this.knob17.Size = new System.Drawing.Size(77, 77);
            this.knob17.SweepAngle = 270;
            this.knob17.TabIndex = 22;
            this.knob17.Thickness = 2;
            this.knob17.Value = 20D;
            // 
            // knob18
            // 
            this.knob18.BackColor = System.Drawing.Color.Navy;
            this.knob18.Divisions = 10;
            this.knob18.ForeColor = System.Drawing.Color.White;
            this.knob18.HideLabels = false;
            this.knob18.LabelText = "RESONANCE";
            this.knob18.LimitToDivisions = false;
            this.knob18.Location = new System.Drawing.Point(584, 15);
            this.knob18.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob18.Max = 100D;
            this.knob18.Min = 0D;
            this.knob18.Name = "knob18";
            this.knob18.Size = new System.Drawing.Size(77, 77);
            this.knob18.SweepAngle = 270;
            this.knob18.TabIndex = 23;
            this.knob18.Thickness = 2;
            this.knob18.Value = 70D;
            // 
            // knob19
            // 
            this.knob19.BackColor = System.Drawing.Color.Navy;
            this.knob19.Divisions = 10;
            this.knob19.ForeColor = System.Drawing.Color.White;
            this.knob19.HideLabels = false;
            this.knob19.LabelText = "ENVELOPE";
            this.knob19.LimitToDivisions = false;
            this.knob19.Location = new System.Drawing.Point(658, 14);
            this.knob19.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob19.Max = 100D;
            this.knob19.Min = 0D;
            this.knob19.Name = "knob19";
            this.knob19.Size = new System.Drawing.Size(77, 77);
            this.knob19.SweepAngle = 270;
            this.knob19.TabIndex = 24;
            this.knob19.Thickness = 2;
            this.knob19.Value = 0D;
            // 
            // knob20
            // 
            this.knob20.Divisions = 10;
            this.knob20.ForeColor = System.Drawing.Color.White;
            this.knob20.HideLabels = false;
            this.knob20.LabelText = "RELEASE";
            this.knob20.LimitToDivisions = false;
            this.knob20.Location = new System.Drawing.Point(659, 126);
            this.knob20.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob20.Max = 100D;
            this.knob20.Min = 0D;
            this.knob20.Name = "knob20";
            this.knob20.Size = new System.Drawing.Size(77, 77);
            this.knob20.SweepAngle = 270;
            this.knob20.TabIndex = 28;
            this.knob20.Thickness = 2;
            this.knob20.Value = 0D;
            // 
            // knob21
            // 
            this.knob21.Divisions = 10;
            this.knob21.ForeColor = System.Drawing.Color.White;
            this.knob21.HideLabels = false;
            this.knob21.LabelText = "SUSTAIN";
            this.knob21.LimitToDivisions = false;
            this.knob21.Location = new System.Drawing.Point(585, 126);
            this.knob21.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob21.Max = 100D;
            this.knob21.Min = 0D;
            this.knob21.Name = "knob21";
            this.knob21.Size = new System.Drawing.Size(77, 77);
            this.knob21.SweepAngle = 270;
            this.knob21.TabIndex = 27;
            this.knob21.Thickness = 2;
            this.knob21.Value = 0D;
            // 
            // knob22
            // 
            this.knob22.Divisions = 10;
            this.knob22.ForeColor = System.Drawing.Color.White;
            this.knob22.HideLabels = false;
            this.knob22.LabelText = "DECAY";
            this.knob22.LimitToDivisions = false;
            this.knob22.Location = new System.Drawing.Point(510, 126);
            this.knob22.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob22.Max = 100D;
            this.knob22.Min = 0D;
            this.knob22.Name = "knob22";
            this.knob22.Size = new System.Drawing.Size(77, 77);
            this.knob22.SweepAngle = 270;
            this.knob22.TabIndex = 26;
            this.knob22.Thickness = 2;
            this.knob22.Value = 0D;
            // 
            // knob23
            // 
            this.knob23.Divisions = 10;
            this.knob23.ForeColor = System.Drawing.Color.White;
            this.knob23.HideLabels = false;
            this.knob23.LabelText = "ATTACK";
            this.knob23.LimitToDivisions = false;
            this.knob23.Location = new System.Drawing.Point(436, 126);
            this.knob23.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob23.Max = 100D;
            this.knob23.Min = 0D;
            this.knob23.Name = "knob23";
            this.knob23.Size = new System.Drawing.Size(77, 77);
            this.knob23.SweepAngle = 270;
            this.knob23.TabIndex = 25;
            this.knob23.Thickness = 2;
            this.knob23.Value = 0D;
            // 
            // knob24
            // 
            this.knob24.Divisions = 10;
            this.knob24.ForeColor = System.Drawing.Color.White;
            this.knob24.HideLabels = false;
            this.knob24.LabelText = "RELEASE";
            this.knob24.LimitToDivisions = false;
            this.knob24.Location = new System.Drawing.Point(658, 237);
            this.knob24.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob24.Max = 100D;
            this.knob24.Min = 0D;
            this.knob24.Name = "knob24";
            this.knob24.Size = new System.Drawing.Size(77, 77);
            this.knob24.SweepAngle = 270;
            this.knob24.TabIndex = 32;
            this.knob24.Thickness = 2;
            this.knob24.Value = 0D;
            // 
            // knob25
            // 
            this.knob25.Divisions = 10;
            this.knob25.ForeColor = System.Drawing.Color.White;
            this.knob25.HideLabels = false;
            this.knob25.LabelText = "SUSTAIN";
            this.knob25.LimitToDivisions = false;
            this.knob25.Location = new System.Drawing.Point(584, 237);
            this.knob25.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob25.Max = 100D;
            this.knob25.Min = 0D;
            this.knob25.Name = "knob25";
            this.knob25.Size = new System.Drawing.Size(77, 77);
            this.knob25.SweepAngle = 270;
            this.knob25.TabIndex = 31;
            this.knob25.Thickness = 2;
            this.knob25.Value = 0D;
            // 
            // knob26
            // 
            this.knob26.Divisions = 10;
            this.knob26.ForeColor = System.Drawing.Color.White;
            this.knob26.HideLabels = false;
            this.knob26.LabelText = "DECAY";
            this.knob26.LimitToDivisions = false;
            this.knob26.Location = new System.Drawing.Point(510, 237);
            this.knob26.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob26.Max = 100D;
            this.knob26.Min = 0D;
            this.knob26.Name = "knob26";
            this.knob26.Size = new System.Drawing.Size(77, 77);
            this.knob26.SweepAngle = 270;
            this.knob26.TabIndex = 30;
            this.knob26.Thickness = 2;
            this.knob26.Value = 0D;
            // 
            // knob27
            // 
            this.knob27.Divisions = 10;
            this.knob27.ForeColor = System.Drawing.Color.White;
            this.knob27.HideLabels = false;
            this.knob27.LabelText = "ATTACK";
            this.knob27.LimitToDivisions = false;
            this.knob27.Location = new System.Drawing.Point(436, 237);
            this.knob27.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob27.Max = 100D;
            this.knob27.Min = 0D;
            this.knob27.Name = "knob27";
            this.knob27.Size = new System.Drawing.Size(77, 77);
            this.knob27.SweepAngle = 270;
            this.knob27.TabIndex = 29;
            this.knob27.Thickness = 2;
            this.knob27.Value = 0D;
            // 
            // knob28
            // 
            this.knob28.Divisions = 10;
            this.knob28.ForeColor = System.Drawing.Color.White;
            this.knob28.HideLabels = false;
            this.knob28.LabelText = "GLIDE";
            this.knob28.LimitToDivisions = false;
            this.knob28.Location = new System.Drawing.Point(745, 12);
            this.knob28.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob28.Max = 100D;
            this.knob28.Min = 0D;
            this.knob28.Name = "knob28";
            this.knob28.Size = new System.Drawing.Size(77, 77);
            this.knob28.SweepAngle = 270;
            this.knob28.TabIndex = 33;
            this.knob28.Thickness = 2;
            this.knob28.Value = 0D;
            // 
            // knob29
            // 
            this.knob29.Divisions = 10;
            this.knob29.ForeColor = System.Drawing.Color.White;
            this.knob29.HideLabels = false;
            this.knob29.LabelText = "NOISE";
            this.knob29.LimitToDivisions = false;
            this.knob29.Location = new System.Drawing.Point(341, 347);
            this.knob29.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob29.Max = 100D;
            this.knob29.Min = 0D;
            this.knob29.Name = "knob29";
            this.knob29.Size = new System.Drawing.Size(77, 77);
            this.knob29.SweepAngle = 270;
            this.knob29.TabIndex = 34;
            this.knob29.Thickness = 2;
            this.knob29.Value = 0D;
            // 
            // panel7
            // 
            this.panel7.CornerRadius = 10;
            this.panel7.LabelText = "LFO 1";
            this.panel7.LineWidth = 2;
            this.panel7.Location = new System.Drawing.Point(6, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 105);
            this.panel7.TabIndex = 35;
            // 
            // knob30
            // 
            this.knob30.Divisions = 4;
            this.knob30.ForeColor = System.Drawing.Color.White;
            this.knob30.HideLabels = true;
            this.knob30.LabelText = "SHAPE";
            this.knob30.LimitToDivisions = true;
            this.knob30.Location = new System.Drawing.Point(86, 349);
            this.knob30.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob30.Max = 4D;
            this.knob30.Min = 0D;
            this.knob30.Name = "knob30";
            this.knob30.Size = new System.Drawing.Size(77, 77);
            this.knob30.SweepAngle = 135;
            this.knob30.TabIndex = 37;
            this.knob30.Thickness = 2;
            this.knob30.Value = 0D;
            // 
            // knob31
            // 
            this.knob31.Divisions = 10;
            this.knob31.ForeColor = System.Drawing.Color.White;
            this.knob31.HideLabels = false;
            this.knob31.LabelText = "RATE";
            this.knob31.LimitToDivisions = false;
            this.knob31.Location = new System.Drawing.Point(12, 349);
            this.knob31.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob31.Max = 100D;
            this.knob31.Min = 0D;
            this.knob31.Name = "knob31";
            this.knob31.Size = new System.Drawing.Size(77, 77);
            this.knob31.SweepAngle = 270;
            this.knob31.TabIndex = 36;
            this.knob31.Thickness = 2;
            this.knob31.Value = 0D;
            // 
            // panel8
            // 
            this.panel8.CornerRadius = 10;
            this.panel8.LabelText = "LFO 2";
            this.panel8.LineWidth = 2;
            this.panel8.Location = new System.Drawing.Point(169, 333);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 105);
            this.panel8.TabIndex = 38;
            // 
            // knob32
            // 
            this.knob32.Divisions = 4;
            this.knob32.ForeColor = System.Drawing.Color.White;
            this.knob32.HideLabels = true;
            this.knob32.LabelText = "SHAPE";
            this.knob32.LimitToDivisions = true;
            this.knob32.Location = new System.Drawing.Point(249, 349);
            this.knob32.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob32.Max = 4D;
            this.knob32.Min = 0D;
            this.knob32.Name = "knob32";
            this.knob32.Size = new System.Drawing.Size(77, 77);
            this.knob32.SweepAngle = 135;
            this.knob32.TabIndex = 40;
            this.knob32.Thickness = 2;
            this.knob32.Value = 0D;
            // 
            // knob33
            // 
            this.knob33.Divisions = 10;
            this.knob33.ForeColor = System.Drawing.Color.White;
            this.knob33.HideLabels = false;
            this.knob33.LabelText = "RATE";
            this.knob33.LimitToDivisions = false;
            this.knob33.Location = new System.Drawing.Point(175, 349);
            this.knob33.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob33.Max = 5D;
            this.knob33.Min = 0D;
            this.knob33.Name = "knob33";
            this.knob33.Size = new System.Drawing.Size(77, 77);
            this.knob33.SweepAngle = 270;
            this.knob33.TabIndex = 39;
            this.knob33.Thickness = 2;
            this.knob33.Value = 0D;
            // 
            // knob34
            // 
            this.knob34.Divisions = 10;
            this.knob34.ForeColor = System.Drawing.Color.White;
            this.knob34.HideLabels = false;
            this.knob34.LabelText = "RELEASE";
            this.knob34.LimitToDivisions = false;
            this.knob34.Location = new System.Drawing.Point(658, 347);
            this.knob34.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob34.Max = 100D;
            this.knob34.Min = 0D;
            this.knob34.Name = "knob34";
            this.knob34.Size = new System.Drawing.Size(77, 77);
            this.knob34.SweepAngle = 270;
            this.knob34.TabIndex = 45;
            this.knob34.Thickness = 2;
            this.knob34.Value = 0D;
            // 
            // knob35
            // 
            this.knob35.Divisions = 10;
            this.knob35.ForeColor = System.Drawing.Color.White;
            this.knob35.HideLabels = false;
            this.knob35.LabelText = "SUSTAIN";
            this.knob35.LimitToDivisions = false;
            this.knob35.Location = new System.Drawing.Point(584, 347);
            this.knob35.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob35.Max = 100D;
            this.knob35.Min = 0D;
            this.knob35.Name = "knob35";
            this.knob35.Size = new System.Drawing.Size(77, 77);
            this.knob35.SweepAngle = 270;
            this.knob35.TabIndex = 44;
            this.knob35.Thickness = 2;
            this.knob35.Value = 0D;
            // 
            // knob36
            // 
            this.knob36.Divisions = 10;
            this.knob36.ForeColor = System.Drawing.Color.White;
            this.knob36.HideLabels = false;
            this.knob36.LabelText = "DECAY";
            this.knob36.LimitToDivisions = false;
            this.knob36.Location = new System.Drawing.Point(510, 347);
            this.knob36.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob36.Max = 100D;
            this.knob36.Min = 0D;
            this.knob36.Name = "knob36";
            this.knob36.Size = new System.Drawing.Size(77, 77);
            this.knob36.SweepAngle = 270;
            this.knob36.TabIndex = 43;
            this.knob36.Thickness = 2;
            this.knob36.Value = 0D;
            // 
            // knob37
            // 
            this.knob37.Divisions = 10;
            this.knob37.ForeColor = System.Drawing.Color.White;
            this.knob37.HideLabels = false;
            this.knob37.LabelText = "ATTACK";
            this.knob37.LimitToDivisions = false;
            this.knob37.Location = new System.Drawing.Point(436, 347);
            this.knob37.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.knob37.Max = 100D;
            this.knob37.Min = 0D;
            this.knob37.Name = "knob37";
            this.knob37.Size = new System.Drawing.Size(77, 77);
            this.knob37.SweepAngle = 270;
            this.knob37.TabIndex = 42;
            this.knob37.Thickness = 2;
            this.knob37.Value = 0D;
            // 
            // panel9
            // 
            this.panel9.CornerRadius = 10;
            this.panel9.LabelText = "ENV 3";
            this.panel9.LineWidth = 2;
            this.panel9.Location = new System.Drawing.Point(432, 334);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(307, 105);
            this.panel9.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(745, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 50);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.knob34);
            this.Controls.Add(this.knob35);
            this.Controls.Add(this.knob36);
            this.Controls.Add(this.knob37);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.knob32);
            this.Controls.Add(this.knob33);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.knob30);
            this.Controls.Add(this.knob31);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.knob29);
            this.Controls.Add(this.knob28);
            this.Controls.Add(this.knob24);
            this.Controls.Add(this.knob25);
            this.Controls.Add(this.knob26);
            this.Controls.Add(this.knob27);
            this.Controls.Add(this.knob20);
            this.Controls.Add(this.knob21);
            this.Controls.Add(this.knob22);
            this.Controls.Add(this.knob23);
            this.Controls.Add(this.knob19);
            this.Controls.Add(this.knob18);
            this.Controls.Add(this.knob17);
            this.Controls.Add(this.knob16);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.knob15);
            this.Controls.Add(this.knob14);
            this.Controls.Add(this.knob13);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.knob9);
            this.Controls.Add(this.knob10);
            this.Controls.Add(this.knob11);
            this.Controls.Add(this.knob12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.knob5);
            this.Controls.Add(this.knob6);
            this.Controls.Add(this.knob7);
            this.Controls.Add(this.knob8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.knob4);
            this.Controls.Add(this.knob3);
            this.Controls.Add(this.knob2);
            this.Controls.Add(this.knob1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Shed Prophet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Panel panel1;
        private Controls.Knob knob1;
        private Controls.Knob knob2;
        private Controls.Knob knob3;
        private Controls.Knob knob4;
        private Controls.Knob knob5;
        private Controls.Knob knob6;
        private Controls.Knob knob7;
        private Controls.Knob knob8;
        private Controls.Panel panel2;
        private Controls.Knob knob9;
        private Controls.Knob knob10;
        private Controls.Knob knob11;
        private Controls.Knob knob12;
        private Controls.Panel panel3;
        private Controls.Panel panel4;
        private Controls.Knob knob13;
        private Controls.Knob knob14;
        private Controls.Knob knob15;
        private Controls.Panel panel5;
        private Controls.Panel panel6;
        private Controls.Knob knob16;
        private Controls.Knob knob17;
        private Controls.Knob knob18;
        private Controls.Knob knob19;
        private Controls.Knob knob20;
        private Controls.Knob knob21;
        private Controls.Knob knob22;
        private Controls.Knob knob23;
        private Controls.Knob knob24;
        private Controls.Knob knob25;
        private Controls.Knob knob26;
        private Controls.Knob knob27;
        private Controls.Knob knob28;
        private Controls.Knob knob29;
        private Controls.Panel panel7;
        private Controls.Knob knob30;
        private Controls.Knob knob31;
        private Controls.Panel panel8;
        private Controls.Knob knob32;
        private Controls.Knob knob33;
        private Controls.Knob knob34;
        private Controls.Knob knob35;
        private Controls.Knob knob36;
        private Controls.Knob knob37;
        private Controls.Panel panel9;
        private PictureBox pictureBox1;
    }
}