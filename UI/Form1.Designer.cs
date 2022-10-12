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
            this.kOsc1Freq = new UI.Controls.Knob();
            this.kOsc1Octave = new UI.Controls.Knob();
            this.kOsc1PW = new UI.Controls.Knob();
            this.kOsc1Waveform = new UI.Controls.Knob();
            this.kOsc2Waveform = new UI.Controls.Knob();
            this.kOsc2PW = new UI.Controls.Knob();
            this.kOsc2Octave = new UI.Controls.Knob();
            this.kOsc2Freq = new UI.Controls.Knob();
            this.panel2 = new UI.Controls.Panel();
            this.kOsc3Waveform = new UI.Controls.Knob();
            this.kOsc3PW = new UI.Controls.Knob();
            this.kOsc3Octave = new UI.Controls.Knob();
            this.kOsc3Freq = new UI.Controls.Knob();
            this.panel3 = new UI.Controls.Panel();
            this.panel4 = new UI.Controls.Panel();
            this.kOsc1Mix = new UI.Controls.Knob();
            this.kOsc2Mix = new UI.Controls.Knob();
            this.kOsc3Mix = new UI.Controls.Knob();
            this.panel5 = new UI.Controls.Panel();
            this.panel6 = new UI.Controls.Panel();
            this.kVcfType = new UI.Controls.Knob();
            this.kVcfCutoff = new UI.Controls.Knob();
            this.kVcfResonance = new UI.Controls.Knob();
            this.kVcfEnvelope = new UI.Controls.Knob();
            this.kEnv1Release = new UI.Controls.Knob();
            this.kEnv1Sustain = new UI.Controls.Knob();
            this.kEnv1Decay = new UI.Controls.Knob();
            this.kEnv1Attack = new UI.Controls.Knob();
            this.kEnv2Release = new UI.Controls.Knob();
            this.kEnv2Sustain = new UI.Controls.Knob();
            this.kEnv2Decay = new UI.Controls.Knob();
            this.kEnv2Attack = new UI.Controls.Knob();
            this.kGlide = new UI.Controls.Knob();
            this.kNoiseMix = new UI.Controls.Knob();
            this.panel7 = new UI.Controls.Panel();
            this.kLfo1Shape = new UI.Controls.Knob();
            this.kLfo1Rate = new UI.Controls.Knob();
            this.panel8 = new UI.Controls.Panel();
            this.kLfo2Shape = new UI.Controls.Knob();
            this.kLfo2Rate = new UI.Controls.Knob();
            this.kEnv3Release = new UI.Controls.Knob();
            this.kEnv3Sustain = new UI.Controls.Knob();
            this.kEnv3Decay = new UI.Controls.Knob();
            this.kEnv3Attack = new UI.Controls.Knob();
            this.panel9 = new UI.Controls.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.cmdViewWave = new System.Windows.Forms.Button();
            this.cmdInit = new System.Windows.Forms.Button();
            this.lblMidiChannel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMidiChannel = new System.Windows.Forms.ComboBox();
            this.ledGate = new UI.Controls.Led();
            this.ledLfo1 = new UI.Controls.Led();
            this.ledLfo2 = new UI.Controls.Led();
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
            // kOsc1Freq
            // 
            this.kOsc1Freq.Default = 0D;
            this.kOsc1Freq.Divisions = 10;
            this.kOsc1Freq.ForeColor = System.Drawing.Color.White;
            this.kOsc1Freq.HideLabels = false;
            this.kOsc1Freq.HideTicks = false;
            this.kOsc1Freq.LabelMarker0 = "-1";
            this.kOsc1Freq.LabelMarker10 = "+1";
            this.kOsc1Freq.LabelMarker5 = "0";
            this.kOsc1Freq.LabelText = "FREQUENCY";
            this.kOsc1Freq.LimitToDivisions = false;
            this.kOsc1Freq.Location = new System.Drawing.Point(10, 20);
            this.kOsc1Freq.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc1Freq.Max = 0.083333D;
            this.kOsc1Freq.Min = -0.083333D;
            this.kOsc1Freq.Name = "kOsc1Freq";
            this.kOsc1Freq.Size = new System.Drawing.Size(77, 77);
            this.kOsc1Freq.SweepAngle = 270;
            this.kOsc1Freq.TabIndex = 1;
            this.kOsc1Freq.Thickness = 2;
            this.kOsc1Freq.Value = 0D;
            // 
            // kOsc1Octave
            // 
            this.kOsc1Octave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kOsc1Octave.BackgroundImage")));
            this.kOsc1Octave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kOsc1Octave.Default = 0D;
            this.kOsc1Octave.Divisions = 3;
            this.kOsc1Octave.ForeColor = System.Drawing.Color.White;
            this.kOsc1Octave.HideLabels = true;
            this.kOsc1Octave.HideTicks = true;
            this.kOsc1Octave.LabelMarker0 = "0";
            this.kOsc1Octave.LabelMarker10 = "10";
            this.kOsc1Octave.LabelMarker5 = "5";
            this.kOsc1Octave.LabelText = "OCTAVE";
            this.kOsc1Octave.LimitToDivisions = true;
            this.kOsc1Octave.Location = new System.Drawing.Point(84, 20);
            this.kOsc1Octave.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc1Octave.Max = 3D;
            this.kOsc1Octave.Min = 0D;
            this.kOsc1Octave.Name = "kOsc1Octave";
            this.kOsc1Octave.Size = new System.Drawing.Size(77, 77);
            this.kOsc1Octave.SweepAngle = 137;
            this.kOsc1Octave.TabIndex = 2;
            this.kOsc1Octave.Thickness = 2;
            this.kOsc1Octave.Value = 0D;
            // 
            // kOsc1PW
            // 
            this.kOsc1PW.Default = 0D;
            this.kOsc1PW.Divisions = 10;
            this.kOsc1PW.ForeColor = System.Drawing.Color.White;
            this.kOsc1PW.HideLabels = false;
            this.kOsc1PW.HideTicks = false;
            this.kOsc1PW.LabelMarker0 = "0";
            this.kOsc1PW.LabelMarker10 = "10";
            this.kOsc1PW.LabelMarker5 = "";
            this.kOsc1PW.LabelText = "PULSE WIDTH";
            this.kOsc1PW.LimitToDivisions = false;
            this.kOsc1PW.Location = new System.Drawing.Point(247, 20);
            this.kOsc1PW.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc1PW.Max = 0.9D;
            this.kOsc1PW.Min = -0.9D;
            this.kOsc1PW.Name = "kOsc1PW";
            this.kOsc1PW.Size = new System.Drawing.Size(77, 77);
            this.kOsc1PW.SweepAngle = 270;
            this.kOsc1PW.TabIndex = 3;
            this.kOsc1PW.Thickness = 2;
            this.kOsc1PW.Value = 0D;
            // 
            // kOsc1Waveform
            // 
            this.kOsc1Waveform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kOsc1Waveform.BackgroundImage")));
            this.kOsc1Waveform.Default = 1D;
            this.kOsc1Waveform.Divisions = 4;
            this.kOsc1Waveform.ForeColor = System.Drawing.Color.White;
            this.kOsc1Waveform.HideLabels = true;
            this.kOsc1Waveform.HideTicks = true;
            this.kOsc1Waveform.LabelMarker0 = "0";
            this.kOsc1Waveform.LabelMarker10 = "10";
            this.kOsc1Waveform.LabelMarker5 = "5";
            this.kOsc1Waveform.LabelText = "WAVEFORM";
            this.kOsc1Waveform.LimitToDivisions = true;
            this.kOsc1Waveform.Location = new System.Drawing.Point(174, 20);
            this.kOsc1Waveform.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc1Waveform.Max = 4D;
            this.kOsc1Waveform.Min = 0D;
            this.kOsc1Waveform.Name = "kOsc1Waveform";
            this.kOsc1Waveform.Size = new System.Drawing.Size(77, 77);
            this.kOsc1Waveform.SweepAngle = 135;
            this.kOsc1Waveform.TabIndex = 4;
            this.kOsc1Waveform.Thickness = 2;
            this.kOsc1Waveform.Value = 1D;
            // 
            // kOsc2Waveform
            // 
            this.kOsc2Waveform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kOsc2Waveform.BackgroundImage")));
            this.kOsc2Waveform.Default = 1D;
            this.kOsc2Waveform.Divisions = 4;
            this.kOsc2Waveform.ForeColor = System.Drawing.Color.White;
            this.kOsc2Waveform.HideLabels = true;
            this.kOsc2Waveform.HideTicks = true;
            this.kOsc2Waveform.LabelMarker0 = "0";
            this.kOsc2Waveform.LabelMarker10 = "10";
            this.kOsc2Waveform.LabelMarker5 = "5";
            this.kOsc2Waveform.LabelText = "WAVEFORM";
            this.kOsc2Waveform.LimitToDivisions = true;
            this.kOsc2Waveform.Location = new System.Drawing.Point(174, 131);
            this.kOsc2Waveform.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc2Waveform.Max = 4D;
            this.kOsc2Waveform.Min = 0D;
            this.kOsc2Waveform.Name = "kOsc2Waveform";
            this.kOsc2Waveform.Size = new System.Drawing.Size(77, 77);
            this.kOsc2Waveform.SweepAngle = 135;
            this.kOsc2Waveform.TabIndex = 9;
            this.kOsc2Waveform.Thickness = 2;
            this.kOsc2Waveform.Value = 1D;
            // 
            // kOsc2PW
            // 
            this.kOsc2PW.Default = 0D;
            this.kOsc2PW.Divisions = 10;
            this.kOsc2PW.ForeColor = System.Drawing.Color.White;
            this.kOsc2PW.HideLabels = false;
            this.kOsc2PW.HideTicks = false;
            this.kOsc2PW.LabelMarker0 = "0";
            this.kOsc2PW.LabelMarker10 = "10";
            this.kOsc2PW.LabelMarker5 = "";
            this.kOsc2PW.LabelText = "PULSE WIDTH";
            this.kOsc2PW.LimitToDivisions = false;
            this.kOsc2PW.Location = new System.Drawing.Point(247, 131);
            this.kOsc2PW.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc2PW.Max = 0.9D;
            this.kOsc2PW.Min = -0.9D;
            this.kOsc2PW.Name = "kOsc2PW";
            this.kOsc2PW.Size = new System.Drawing.Size(77, 77);
            this.kOsc2PW.SweepAngle = 270;
            this.kOsc2PW.TabIndex = 8;
            this.kOsc2PW.Thickness = 2;
            this.kOsc2PW.Value = 0D;
            // 
            // kOsc2Octave
            // 
            this.kOsc2Octave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kOsc2Octave.BackgroundImage")));
            this.kOsc2Octave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kOsc2Octave.Default = 0D;
            this.kOsc2Octave.Divisions = 3;
            this.kOsc2Octave.ForeColor = System.Drawing.Color.White;
            this.kOsc2Octave.HideLabels = true;
            this.kOsc2Octave.HideTicks = true;
            this.kOsc2Octave.LabelMarker0 = "0";
            this.kOsc2Octave.LabelMarker10 = "10";
            this.kOsc2Octave.LabelMarker5 = "5";
            this.kOsc2Octave.LabelText = "OCTAVE";
            this.kOsc2Octave.LimitToDivisions = true;
            this.kOsc2Octave.Location = new System.Drawing.Point(84, 131);
            this.kOsc2Octave.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc2Octave.Max = 3D;
            this.kOsc2Octave.Min = 0D;
            this.kOsc2Octave.Name = "kOsc2Octave";
            this.kOsc2Octave.Size = new System.Drawing.Size(77, 77);
            this.kOsc2Octave.SweepAngle = 137;
            this.kOsc2Octave.TabIndex = 7;
            this.kOsc2Octave.Thickness = 2;
            this.kOsc2Octave.Value = 0D;
            // 
            // kOsc2Freq
            // 
            this.kOsc2Freq.Default = 0D;
            this.kOsc2Freq.Divisions = 10;
            this.kOsc2Freq.ForeColor = System.Drawing.Color.White;
            this.kOsc2Freq.HideLabels = false;
            this.kOsc2Freq.HideTicks = false;
            this.kOsc2Freq.LabelMarker0 = "0";
            this.kOsc2Freq.LabelMarker10 = "10";
            this.kOsc2Freq.LabelMarker5 = "5";
            this.kOsc2Freq.LabelText = "FREQUENCY";
            this.kOsc2Freq.LimitToDivisions = false;
            this.kOsc2Freq.Location = new System.Drawing.Point(10, 131);
            this.kOsc2Freq.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc2Freq.Max = 0.083333D;
            this.kOsc2Freq.Min = -0.083333D;
            this.kOsc2Freq.Name = "kOsc2Freq";
            this.kOsc2Freq.Size = new System.Drawing.Size(77, 77);
            this.kOsc2Freq.SweepAngle = 270;
            this.kOsc2Freq.TabIndex = 6;
            this.kOsc2Freq.Thickness = 2;
            this.kOsc2Freq.Value = -0.01D;
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
            // kOsc3Waveform
            // 
            this.kOsc3Waveform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kOsc3Waveform.BackgroundImage")));
            this.kOsc3Waveform.Default = 1D;
            this.kOsc3Waveform.Divisions = 4;
            this.kOsc3Waveform.ForeColor = System.Drawing.Color.White;
            this.kOsc3Waveform.HideLabels = true;
            this.kOsc3Waveform.HideTicks = true;
            this.kOsc3Waveform.LabelMarker0 = "0";
            this.kOsc3Waveform.LabelMarker10 = "10";
            this.kOsc3Waveform.LabelMarker5 = "5";
            this.kOsc3Waveform.LabelText = "WAVEFORM";
            this.kOsc3Waveform.LimitToDivisions = true;
            this.kOsc3Waveform.Location = new System.Drawing.Point(174, 242);
            this.kOsc3Waveform.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc3Waveform.Max = 4D;
            this.kOsc3Waveform.Min = 0D;
            this.kOsc3Waveform.Name = "kOsc3Waveform";
            this.kOsc3Waveform.Size = new System.Drawing.Size(77, 77);
            this.kOsc3Waveform.SweepAngle = 135;
            this.kOsc3Waveform.TabIndex = 14;
            this.kOsc3Waveform.Thickness = 2;
            this.kOsc3Waveform.Value = 1D;
            // 
            // kOsc3PW
            // 
            this.kOsc3PW.Default = 0D;
            this.kOsc3PW.Divisions = 10;
            this.kOsc3PW.ForeColor = System.Drawing.Color.White;
            this.kOsc3PW.HideLabels = false;
            this.kOsc3PW.HideTicks = false;
            this.kOsc3PW.LabelMarker0 = "0";
            this.kOsc3PW.LabelMarker10 = "10";
            this.kOsc3PW.LabelMarker5 = "";
            this.kOsc3PW.LabelText = "PULSE WIDTH";
            this.kOsc3PW.LimitToDivisions = false;
            this.kOsc3PW.Location = new System.Drawing.Point(247, 242);
            this.kOsc3PW.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc3PW.Max = 0.9D;
            this.kOsc3PW.Min = -0.9D;
            this.kOsc3PW.Name = "kOsc3PW";
            this.kOsc3PW.Size = new System.Drawing.Size(77, 77);
            this.kOsc3PW.SweepAngle = 270;
            this.kOsc3PW.TabIndex = 13;
            this.kOsc3PW.Thickness = 2;
            this.kOsc3PW.Value = 0D;
            // 
            // kOsc3Octave
            // 
            this.kOsc3Octave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kOsc3Octave.BackgroundImage")));
            this.kOsc3Octave.Default = 1D;
            this.kOsc3Octave.Divisions = 3;
            this.kOsc3Octave.ForeColor = System.Drawing.Color.White;
            this.kOsc3Octave.HideLabels = true;
            this.kOsc3Octave.HideTicks = true;
            this.kOsc3Octave.LabelMarker0 = "0";
            this.kOsc3Octave.LabelMarker10 = "10";
            this.kOsc3Octave.LabelMarker5 = "5";
            this.kOsc3Octave.LabelText = "OCTAVE";
            this.kOsc3Octave.LimitToDivisions = true;
            this.kOsc3Octave.Location = new System.Drawing.Point(84, 242);
            this.kOsc3Octave.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc3Octave.Max = 3D;
            this.kOsc3Octave.Min = 0D;
            this.kOsc3Octave.Name = "kOsc3Octave";
            this.kOsc3Octave.Size = new System.Drawing.Size(77, 77);
            this.kOsc3Octave.SweepAngle = 137;
            this.kOsc3Octave.TabIndex = 12;
            this.kOsc3Octave.Thickness = 2;
            this.kOsc3Octave.Value = 1D;
            // 
            // kOsc3Freq
            // 
            this.kOsc3Freq.Default = 0.01D;
            this.kOsc3Freq.Divisions = 10;
            this.kOsc3Freq.ForeColor = System.Drawing.Color.White;
            this.kOsc3Freq.HideLabels = false;
            this.kOsc3Freq.HideTicks = false;
            this.kOsc3Freq.LabelMarker0 = "0";
            this.kOsc3Freq.LabelMarker10 = "10";
            this.kOsc3Freq.LabelMarker5 = "5";
            this.kOsc3Freq.LabelText = "FREQUENCY";
            this.kOsc3Freq.LimitToDivisions = false;
            this.kOsc3Freq.Location = new System.Drawing.Point(10, 242);
            this.kOsc3Freq.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc3Freq.Max = 0.083333D;
            this.kOsc3Freq.Min = -0.083333D;
            this.kOsc3Freq.Name = "kOsc3Freq";
            this.kOsc3Freq.Size = new System.Drawing.Size(77, 77);
            this.kOsc3Freq.SweepAngle = 270;
            this.kOsc3Freq.TabIndex = 11;
            this.kOsc3Freq.Thickness = 2;
            this.kOsc3Freq.Value = 0.01D;
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
            // kOsc1Mix
            // 
            this.kOsc1Mix.Default = 1D;
            this.kOsc1Mix.Divisions = 10;
            this.kOsc1Mix.ForeColor = System.Drawing.Color.White;
            this.kOsc1Mix.HideLabels = false;
            this.kOsc1Mix.HideTicks = false;
            this.kOsc1Mix.LabelMarker0 = "0";
            this.kOsc1Mix.LabelMarker10 = "10";
            this.kOsc1Mix.LabelMarker5 = "";
            this.kOsc1Mix.LabelText = "OSC 1";
            this.kOsc1Mix.LimitToDivisions = false;
            this.kOsc1Mix.Location = new System.Drawing.Point(340, 19);
            this.kOsc1Mix.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc1Mix.Max = 1D;
            this.kOsc1Mix.Min = 0D;
            this.kOsc1Mix.Name = "kOsc1Mix";
            this.kOsc1Mix.Size = new System.Drawing.Size(77, 77);
            this.kOsc1Mix.SweepAngle = 270;
            this.kOsc1Mix.TabIndex = 16;
            this.kOsc1Mix.Thickness = 2;
            this.kOsc1Mix.Value = 1D;
            // 
            // kOsc2Mix
            // 
            this.kOsc2Mix.Default = 1D;
            this.kOsc2Mix.Divisions = 10;
            this.kOsc2Mix.ForeColor = System.Drawing.Color.White;
            this.kOsc2Mix.HideLabels = false;
            this.kOsc2Mix.HideTicks = false;
            this.kOsc2Mix.LabelMarker0 = "0";
            this.kOsc2Mix.LabelMarker10 = "10";
            this.kOsc2Mix.LabelMarker5 = "";
            this.kOsc2Mix.LabelText = "OSC 2";
            this.kOsc2Mix.LimitToDivisions = false;
            this.kOsc2Mix.Location = new System.Drawing.Point(340, 131);
            this.kOsc2Mix.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc2Mix.Max = 1D;
            this.kOsc2Mix.Min = 0D;
            this.kOsc2Mix.Name = "kOsc2Mix";
            this.kOsc2Mix.Size = new System.Drawing.Size(77, 77);
            this.kOsc2Mix.SweepAngle = 270;
            this.kOsc2Mix.TabIndex = 17;
            this.kOsc2Mix.Thickness = 2;
            this.kOsc2Mix.Value = 1D;
            // 
            // kOsc3Mix
            // 
            this.kOsc3Mix.Default = 1D;
            this.kOsc3Mix.Divisions = 10;
            this.kOsc3Mix.ForeColor = System.Drawing.Color.White;
            this.kOsc3Mix.HideLabels = false;
            this.kOsc3Mix.HideTicks = false;
            this.kOsc3Mix.LabelMarker0 = "0";
            this.kOsc3Mix.LabelMarker10 = "10";
            this.kOsc3Mix.LabelMarker5 = "";
            this.kOsc3Mix.LabelText = "OSC 3";
            this.kOsc3Mix.LimitToDivisions = false;
            this.kOsc3Mix.Location = new System.Drawing.Point(341, 242);
            this.kOsc3Mix.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kOsc3Mix.Max = 1D;
            this.kOsc3Mix.Min = 0D;
            this.kOsc3Mix.Name = "kOsc3Mix";
            this.kOsc3Mix.Size = new System.Drawing.Size(77, 77);
            this.kOsc3Mix.SweepAngle = 270;
            this.kOsc3Mix.TabIndex = 18;
            this.kOsc3Mix.Thickness = 2;
            this.kOsc3Mix.Value = 1D;
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
            // kVcfType
            // 
            this.kVcfType.BackColor = System.Drawing.Color.Navy;
            this.kVcfType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kVcfType.BackgroundImage")));
            this.kVcfType.Default = 1D;
            this.kVcfType.Divisions = 5;
            this.kVcfType.ForeColor = System.Drawing.Color.White;
            this.kVcfType.HideLabels = true;
            this.kVcfType.HideTicks = true;
            this.kVcfType.LabelMarker0 = "0";
            this.kVcfType.LabelMarker10 = "10";
            this.kVcfType.LabelMarker5 = "5";
            this.kVcfType.LabelText = "TYPE";
            this.kVcfType.LimitToDivisions = true;
            this.kVcfType.Location = new System.Drawing.Point(436, 20);
            this.kVcfType.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kVcfType.Max = 5D;
            this.kVcfType.Min = 0D;
            this.kVcfType.Name = "kVcfType";
            this.kVcfType.Size = new System.Drawing.Size(77, 77);
            this.kVcfType.SweepAngle = 180;
            this.kVcfType.TabIndex = 21;
            this.kVcfType.Thickness = 2;
            this.kVcfType.Value = 1D;
            // 
            // kVcfCutoff
            // 
            this.kVcfCutoff.BackColor = System.Drawing.Color.Navy;
            this.kVcfCutoff.Default = 0D;
            this.kVcfCutoff.Divisions = 10;
            this.kVcfCutoff.ForeColor = System.Drawing.Color.White;
            this.kVcfCutoff.HideLabels = false;
            this.kVcfCutoff.HideTicks = false;
            this.kVcfCutoff.LabelMarker0 = "0";
            this.kVcfCutoff.LabelMarker10 = "10";
            this.kVcfCutoff.LabelMarker5 = "";
            this.kVcfCutoff.LabelText = "CUTOFF";
            this.kVcfCutoff.LimitToDivisions = false;
            this.kVcfCutoff.Location = new System.Drawing.Point(510, 20);
            this.kVcfCutoff.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kVcfCutoff.Max = 1D;
            this.kVcfCutoff.Min = 0D;
            this.kVcfCutoff.Name = "kVcfCutoff";
            this.kVcfCutoff.Size = new System.Drawing.Size(77, 77);
            this.kVcfCutoff.SweepAngle = 270;
            this.kVcfCutoff.TabIndex = 22;
            this.kVcfCutoff.Thickness = 2;
            this.kVcfCutoff.Value = 0D;
            // 
            // kVcfResonance
            // 
            this.kVcfResonance.BackColor = System.Drawing.Color.Navy;
            this.kVcfResonance.Default = 1D;
            this.kVcfResonance.Divisions = 10;
            this.kVcfResonance.ForeColor = System.Drawing.Color.White;
            this.kVcfResonance.HideLabels = false;
            this.kVcfResonance.HideTicks = false;
            this.kVcfResonance.LabelMarker0 = "0";
            this.kVcfResonance.LabelMarker10 = "10";
            this.kVcfResonance.LabelMarker5 = "";
            this.kVcfResonance.LabelText = "RESONANCE";
            this.kVcfResonance.LimitToDivisions = false;
            this.kVcfResonance.Location = new System.Drawing.Point(584, 20);
            this.kVcfResonance.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kVcfResonance.Max = 1D;
            this.kVcfResonance.Min = 0D;
            this.kVcfResonance.Name = "kVcfResonance";
            this.kVcfResonance.Size = new System.Drawing.Size(77, 77);
            this.kVcfResonance.SweepAngle = 270;
            this.kVcfResonance.TabIndex = 23;
            this.kVcfResonance.Thickness = 2;
            this.kVcfResonance.Value = 1D;
            // 
            // kVcfEnvelope
            // 
            this.kVcfEnvelope.BackColor = System.Drawing.Color.Navy;
            this.kVcfEnvelope.Default = 1D;
            this.kVcfEnvelope.Divisions = 10;
            this.kVcfEnvelope.ForeColor = System.Drawing.Color.White;
            this.kVcfEnvelope.HideLabels = false;
            this.kVcfEnvelope.HideTicks = false;
            this.kVcfEnvelope.LabelMarker0 = "0";
            this.kVcfEnvelope.LabelMarker10 = "10";
            this.kVcfEnvelope.LabelMarker5 = "";
            this.kVcfEnvelope.LabelText = "ENVELOPE";
            this.kVcfEnvelope.LimitToDivisions = false;
            this.kVcfEnvelope.Location = new System.Drawing.Point(658, 20);
            this.kVcfEnvelope.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kVcfEnvelope.Max = 1D;
            this.kVcfEnvelope.Min = 0D;
            this.kVcfEnvelope.Name = "kVcfEnvelope";
            this.kVcfEnvelope.Size = new System.Drawing.Size(77, 77);
            this.kVcfEnvelope.SweepAngle = 270;
            this.kVcfEnvelope.TabIndex = 24;
            this.kVcfEnvelope.Thickness = 2;
            this.kVcfEnvelope.Value = 1D;
            // 
            // kEnv1Release
            // 
            this.kEnv1Release.Default = 2D;
            this.kEnv1Release.Divisions = 10;
            this.kEnv1Release.ForeColor = System.Drawing.Color.White;
            this.kEnv1Release.HideLabels = false;
            this.kEnv1Release.HideTicks = false;
            this.kEnv1Release.LabelMarker0 = "0";
            this.kEnv1Release.LabelMarker10 = "10";
            this.kEnv1Release.LabelMarker5 = "";
            this.kEnv1Release.LabelText = "RELEASE";
            this.kEnv1Release.LimitToDivisions = false;
            this.kEnv1Release.Location = new System.Drawing.Point(659, 131);
            this.kEnv1Release.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv1Release.Max = 5D;
            this.kEnv1Release.Min = 0D;
            this.kEnv1Release.Name = "kEnv1Release";
            this.kEnv1Release.Size = new System.Drawing.Size(77, 77);
            this.kEnv1Release.SweepAngle = 270;
            this.kEnv1Release.TabIndex = 28;
            this.kEnv1Release.Thickness = 2;
            this.kEnv1Release.Value = 2D;
            // 
            // kEnv1Sustain
            // 
            this.kEnv1Sustain.Default = 0.6D;
            this.kEnv1Sustain.Divisions = 10;
            this.kEnv1Sustain.ForeColor = System.Drawing.Color.White;
            this.kEnv1Sustain.HideLabels = false;
            this.kEnv1Sustain.HideTicks = false;
            this.kEnv1Sustain.LabelMarker0 = "0";
            this.kEnv1Sustain.LabelMarker10 = "10";
            this.kEnv1Sustain.LabelMarker5 = "";
            this.kEnv1Sustain.LabelText = "SUSTAIN";
            this.kEnv1Sustain.LimitToDivisions = false;
            this.kEnv1Sustain.Location = new System.Drawing.Point(585, 131);
            this.kEnv1Sustain.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv1Sustain.Max = 1D;
            this.kEnv1Sustain.Min = 0D;
            this.kEnv1Sustain.Name = "kEnv1Sustain";
            this.kEnv1Sustain.Size = new System.Drawing.Size(77, 77);
            this.kEnv1Sustain.SweepAngle = 270;
            this.kEnv1Sustain.TabIndex = 27;
            this.kEnv1Sustain.Thickness = 2;
            this.kEnv1Sustain.Value = 0.6D;
            // 
            // kEnv1Decay
            // 
            this.kEnv1Decay.Default = 0.5D;
            this.kEnv1Decay.Divisions = 10;
            this.kEnv1Decay.ForeColor = System.Drawing.Color.White;
            this.kEnv1Decay.HideLabels = false;
            this.kEnv1Decay.HideTicks = false;
            this.kEnv1Decay.LabelMarker0 = "0";
            this.kEnv1Decay.LabelMarker10 = "10";
            this.kEnv1Decay.LabelMarker5 = "";
            this.kEnv1Decay.LabelText = "DECAY";
            this.kEnv1Decay.LimitToDivisions = false;
            this.kEnv1Decay.Location = new System.Drawing.Point(510, 131);
            this.kEnv1Decay.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv1Decay.Max = 5D;
            this.kEnv1Decay.Min = 0D;
            this.kEnv1Decay.Name = "kEnv1Decay";
            this.kEnv1Decay.Size = new System.Drawing.Size(77, 77);
            this.kEnv1Decay.SweepAngle = 270;
            this.kEnv1Decay.TabIndex = 26;
            this.kEnv1Decay.Thickness = 2;
            this.kEnv1Decay.Value = 0.5D;
            // 
            // kEnv1Attack
            // 
            this.kEnv1Attack.Default = 0D;
            this.kEnv1Attack.Divisions = 10;
            this.kEnv1Attack.ForeColor = System.Drawing.Color.White;
            this.kEnv1Attack.HideLabels = false;
            this.kEnv1Attack.HideTicks = false;
            this.kEnv1Attack.LabelMarker0 = "0";
            this.kEnv1Attack.LabelMarker10 = "10";
            this.kEnv1Attack.LabelMarker5 = "";
            this.kEnv1Attack.LabelText = "ATTACK";
            this.kEnv1Attack.LimitToDivisions = false;
            this.kEnv1Attack.Location = new System.Drawing.Point(436, 131);
            this.kEnv1Attack.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv1Attack.Max = 5D;
            this.kEnv1Attack.Min = 0D;
            this.kEnv1Attack.Name = "kEnv1Attack";
            this.kEnv1Attack.Size = new System.Drawing.Size(77, 77);
            this.kEnv1Attack.SweepAngle = 270;
            this.kEnv1Attack.TabIndex = 25;
            this.kEnv1Attack.Thickness = 2;
            this.kEnv1Attack.Value = 0D;
            // 
            // kEnv2Release
            // 
            this.kEnv2Release.Default = 4D;
            this.kEnv2Release.Divisions = 10;
            this.kEnv2Release.ForeColor = System.Drawing.Color.White;
            this.kEnv2Release.HideLabels = false;
            this.kEnv2Release.HideTicks = false;
            this.kEnv2Release.LabelMarker0 = "0";
            this.kEnv2Release.LabelMarker10 = "10";
            this.kEnv2Release.LabelMarker5 = "";
            this.kEnv2Release.LabelText = "RELEASE";
            this.kEnv2Release.LimitToDivisions = false;
            this.kEnv2Release.Location = new System.Drawing.Point(658, 242);
            this.kEnv2Release.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv2Release.Max = 5D;
            this.kEnv2Release.Min = 0D;
            this.kEnv2Release.Name = "kEnv2Release";
            this.kEnv2Release.Size = new System.Drawing.Size(77, 77);
            this.kEnv2Release.SweepAngle = 270;
            this.kEnv2Release.TabIndex = 32;
            this.kEnv2Release.Thickness = 2;
            this.kEnv2Release.Value = 4D;
            // 
            // kEnv2Sustain
            // 
            this.kEnv2Sustain.Default = 0.7D;
            this.kEnv2Sustain.Divisions = 10;
            this.kEnv2Sustain.ForeColor = System.Drawing.Color.White;
            this.kEnv2Sustain.HideLabels = false;
            this.kEnv2Sustain.HideTicks = false;
            this.kEnv2Sustain.LabelMarker0 = "0";
            this.kEnv2Sustain.LabelMarker10 = "10";
            this.kEnv2Sustain.LabelMarker5 = "";
            this.kEnv2Sustain.LabelText = "SUSTAIN";
            this.kEnv2Sustain.LimitToDivisions = false;
            this.kEnv2Sustain.Location = new System.Drawing.Point(584, 242);
            this.kEnv2Sustain.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv2Sustain.Max = 1D;
            this.kEnv2Sustain.Min = 0D;
            this.kEnv2Sustain.Name = "kEnv2Sustain";
            this.kEnv2Sustain.Size = new System.Drawing.Size(77, 77);
            this.kEnv2Sustain.SweepAngle = 270;
            this.kEnv2Sustain.TabIndex = 31;
            this.kEnv2Sustain.Thickness = 2;
            this.kEnv2Sustain.Value = 0.7D;
            // 
            // kEnv2Decay
            // 
            this.kEnv2Decay.Default = 0.3D;
            this.kEnv2Decay.Divisions = 10;
            this.kEnv2Decay.ForeColor = System.Drawing.Color.White;
            this.kEnv2Decay.HideLabels = false;
            this.kEnv2Decay.HideTicks = false;
            this.kEnv2Decay.LabelMarker0 = "0";
            this.kEnv2Decay.LabelMarker10 = "10";
            this.kEnv2Decay.LabelMarker5 = "";
            this.kEnv2Decay.LabelText = "DECAY";
            this.kEnv2Decay.LimitToDivisions = false;
            this.kEnv2Decay.Location = new System.Drawing.Point(510, 242);
            this.kEnv2Decay.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv2Decay.Max = 5D;
            this.kEnv2Decay.Min = 0D;
            this.kEnv2Decay.Name = "kEnv2Decay";
            this.kEnv2Decay.Size = new System.Drawing.Size(77, 77);
            this.kEnv2Decay.SweepAngle = 270;
            this.kEnv2Decay.TabIndex = 30;
            this.kEnv2Decay.Thickness = 2;
            this.kEnv2Decay.Value = 0.3D;
            // 
            // kEnv2Attack
            // 
            this.kEnv2Attack.Default = 0D;
            this.kEnv2Attack.Divisions = 10;
            this.kEnv2Attack.ForeColor = System.Drawing.Color.White;
            this.kEnv2Attack.HideLabels = false;
            this.kEnv2Attack.HideTicks = false;
            this.kEnv2Attack.LabelMarker0 = "0";
            this.kEnv2Attack.LabelMarker10 = "10";
            this.kEnv2Attack.LabelMarker5 = "";
            this.kEnv2Attack.LabelText = "ATTACK";
            this.kEnv2Attack.LimitToDivisions = false;
            this.kEnv2Attack.Location = new System.Drawing.Point(436, 242);
            this.kEnv2Attack.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv2Attack.Max = 5D;
            this.kEnv2Attack.Min = 0D;
            this.kEnv2Attack.Name = "kEnv2Attack";
            this.kEnv2Attack.Size = new System.Drawing.Size(77, 77);
            this.kEnv2Attack.SweepAngle = 270;
            this.kEnv2Attack.TabIndex = 29;
            this.kEnv2Attack.Thickness = 2;
            this.kEnv2Attack.Value = 0D;
            // 
            // kGlide
            // 
            this.kGlide.Default = 50D;
            this.kGlide.Divisions = 10;
            this.kGlide.ForeColor = System.Drawing.Color.White;
            this.kGlide.HideLabels = false;
            this.kGlide.HideTicks = false;
            this.kGlide.LabelMarker0 = "0";
            this.kGlide.LabelMarker10 = "10";
            this.kGlide.LabelMarker5 = "";
            this.kGlide.LabelText = "GLIDE";
            this.kGlide.LimitToDivisions = false;
            this.kGlide.Location = new System.Drawing.Point(755, 17);
            this.kGlide.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kGlide.Max = 500D;
            this.kGlide.Min = 0D;
            this.kGlide.Name = "kGlide";
            this.kGlide.Size = new System.Drawing.Size(77, 77);
            this.kGlide.SweepAngle = 270;
            this.kGlide.TabIndex = 33;
            this.kGlide.Thickness = 2;
            this.kGlide.Value = 50D;
            // 
            // kNoiseMix
            // 
            this.kNoiseMix.Default = 0D;
            this.kNoiseMix.Divisions = 10;
            this.kNoiseMix.ForeColor = System.Drawing.Color.White;
            this.kNoiseMix.HideLabels = false;
            this.kNoiseMix.HideTicks = false;
            this.kNoiseMix.LabelMarker0 = "0";
            this.kNoiseMix.LabelMarker10 = "10";
            this.kNoiseMix.LabelMarker5 = "";
            this.kNoiseMix.LabelText = "NOISE";
            this.kNoiseMix.LimitToDivisions = false;
            this.kNoiseMix.Location = new System.Drawing.Point(341, 352);
            this.kNoiseMix.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kNoiseMix.Max = 1D;
            this.kNoiseMix.Min = 0D;
            this.kNoiseMix.Name = "kNoiseMix";
            this.kNoiseMix.Size = new System.Drawing.Size(77, 77);
            this.kNoiseMix.SweepAngle = 270;
            this.kNoiseMix.TabIndex = 34;
            this.kNoiseMix.Thickness = 2;
            this.kNoiseMix.Value = 0D;
            // 
            // panel7
            // 
            this.panel7.CornerRadius = 10;
            this.panel7.LabelText = "LFO 1 - to patchbay";
            this.panel7.LineWidth = 2;
            this.panel7.Location = new System.Drawing.Point(6, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 105);
            this.panel7.TabIndex = 35;
            // 
            // kLfo1Shape
            // 
            this.kLfo1Shape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kLfo1Shape.BackgroundImage")));
            this.kLfo1Shape.Default = 0D;
            this.kLfo1Shape.Divisions = 5;
            this.kLfo1Shape.ForeColor = System.Drawing.Color.White;
            this.kLfo1Shape.HideLabels = true;
            this.kLfo1Shape.HideTicks = true;
            this.kLfo1Shape.LabelMarker0 = "0";
            this.kLfo1Shape.LabelMarker10 = "10";
            this.kLfo1Shape.LabelMarker5 = "5";
            this.kLfo1Shape.LabelText = "SHAPE";
            this.kLfo1Shape.LimitToDivisions = true;
            this.kLfo1Shape.Location = new System.Drawing.Point(86, 354);
            this.kLfo1Shape.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kLfo1Shape.Max = 5D;
            this.kLfo1Shape.Min = 0D;
            this.kLfo1Shape.Name = "kLfo1Shape";
            this.kLfo1Shape.Size = new System.Drawing.Size(77, 77);
            this.kLfo1Shape.SweepAngle = 160;
            this.kLfo1Shape.TabIndex = 37;
            this.kLfo1Shape.Thickness = 2;
            this.kLfo1Shape.Value = 0D;
            // 
            // kLfo1Rate
            // 
            this.kLfo1Rate.Default = 0D;
            this.kLfo1Rate.Divisions = 10;
            this.kLfo1Rate.ForeColor = System.Drawing.Color.White;
            this.kLfo1Rate.HideLabels = false;
            this.kLfo1Rate.HideTicks = false;
            this.kLfo1Rate.LabelMarker0 = "0";
            this.kLfo1Rate.LabelMarker10 = "10";
            this.kLfo1Rate.LabelMarker5 = "";
            this.kLfo1Rate.LabelText = "RATE";
            this.kLfo1Rate.LimitToDivisions = false;
            this.kLfo1Rate.Location = new System.Drawing.Point(12, 354);
            this.kLfo1Rate.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kLfo1Rate.Max = 1D;
            this.kLfo1Rate.Min = 0D;
            this.kLfo1Rate.Name = "kLfo1Rate";
            this.kLfo1Rate.Size = new System.Drawing.Size(77, 77);
            this.kLfo1Rate.SweepAngle = 270;
            this.kLfo1Rate.TabIndex = 36;
            this.kLfo1Rate.Thickness = 2;
            this.kLfo1Rate.Value = 0D;
            // 
            // panel8
            // 
            this.panel8.CornerRadius = 10;
            this.panel8.LabelText = "LFO 2 - to patchbay";
            this.panel8.LineWidth = 2;
            this.panel8.Location = new System.Drawing.Point(169, 333);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 105);
            this.panel8.TabIndex = 38;
            // 
            // kLfo2Shape
            // 
            this.kLfo2Shape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kLfo2Shape.BackgroundImage")));
            this.kLfo2Shape.Default = 0D;
            this.kLfo2Shape.Divisions = 5;
            this.kLfo2Shape.ForeColor = System.Drawing.Color.White;
            this.kLfo2Shape.HideLabels = true;
            this.kLfo2Shape.HideTicks = true;
            this.kLfo2Shape.LabelMarker0 = "0";
            this.kLfo2Shape.LabelMarker10 = "10";
            this.kLfo2Shape.LabelMarker5 = "5";
            this.kLfo2Shape.LabelText = "SHAPE";
            this.kLfo2Shape.LimitToDivisions = true;
            this.kLfo2Shape.Location = new System.Drawing.Point(249, 354);
            this.kLfo2Shape.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kLfo2Shape.Max = 5D;
            this.kLfo2Shape.Min = 0D;
            this.kLfo2Shape.Name = "kLfo2Shape";
            this.kLfo2Shape.Size = new System.Drawing.Size(77, 77);
            this.kLfo2Shape.SweepAngle = 160;
            this.kLfo2Shape.TabIndex = 40;
            this.kLfo2Shape.Thickness = 2;
            this.kLfo2Shape.Value = 0D;
            // 
            // kLfo2Rate
            // 
            this.kLfo2Rate.Default = 0D;
            this.kLfo2Rate.Divisions = 10;
            this.kLfo2Rate.ForeColor = System.Drawing.Color.White;
            this.kLfo2Rate.HideLabels = false;
            this.kLfo2Rate.HideTicks = false;
            this.kLfo2Rate.LabelMarker0 = "0";
            this.kLfo2Rate.LabelMarker10 = "10";
            this.kLfo2Rate.LabelMarker5 = "";
            this.kLfo2Rate.LabelText = "RATE";
            this.kLfo2Rate.LimitToDivisions = false;
            this.kLfo2Rate.Location = new System.Drawing.Point(175, 354);
            this.kLfo2Rate.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kLfo2Rate.Max = 1D;
            this.kLfo2Rate.Min = 0D;
            this.kLfo2Rate.Name = "kLfo2Rate";
            this.kLfo2Rate.Size = new System.Drawing.Size(77, 77);
            this.kLfo2Rate.SweepAngle = 270;
            this.kLfo2Rate.TabIndex = 39;
            this.kLfo2Rate.Thickness = 2;
            this.kLfo2Rate.Value = 0D;
            // 
            // kEnv3Release
            // 
            this.kEnv3Release.Default = 0D;
            this.kEnv3Release.Divisions = 10;
            this.kEnv3Release.ForeColor = System.Drawing.Color.White;
            this.kEnv3Release.HideLabels = false;
            this.kEnv3Release.HideTicks = false;
            this.kEnv3Release.LabelMarker0 = "0";
            this.kEnv3Release.LabelMarker10 = "10";
            this.kEnv3Release.LabelMarker5 = "";
            this.kEnv3Release.LabelText = "RELEASE";
            this.kEnv3Release.LimitToDivisions = false;
            this.kEnv3Release.Location = new System.Drawing.Point(658, 352);
            this.kEnv3Release.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv3Release.Max = 5D;
            this.kEnv3Release.Min = 0D;
            this.kEnv3Release.Name = "kEnv3Release";
            this.kEnv3Release.Size = new System.Drawing.Size(77, 77);
            this.kEnv3Release.SweepAngle = 270;
            this.kEnv3Release.TabIndex = 45;
            this.kEnv3Release.Thickness = 2;
            this.kEnv3Release.Value = 0D;
            // 
            // kEnv3Sustain
            // 
            this.kEnv3Sustain.Default = 0D;
            this.kEnv3Sustain.Divisions = 10;
            this.kEnv3Sustain.ForeColor = System.Drawing.Color.White;
            this.kEnv3Sustain.HideLabels = false;
            this.kEnv3Sustain.HideTicks = false;
            this.kEnv3Sustain.LabelMarker0 = "0";
            this.kEnv3Sustain.LabelMarker10 = "10";
            this.kEnv3Sustain.LabelMarker5 = "";
            this.kEnv3Sustain.LabelText = "SUSTAIN";
            this.kEnv3Sustain.LimitToDivisions = false;
            this.kEnv3Sustain.Location = new System.Drawing.Point(584, 352);
            this.kEnv3Sustain.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv3Sustain.Max = 1D;
            this.kEnv3Sustain.Min = 0D;
            this.kEnv3Sustain.Name = "kEnv3Sustain";
            this.kEnv3Sustain.Size = new System.Drawing.Size(77, 77);
            this.kEnv3Sustain.SweepAngle = 270;
            this.kEnv3Sustain.TabIndex = 44;
            this.kEnv3Sustain.Thickness = 2;
            this.kEnv3Sustain.Value = 0D;
            // 
            // kEnv3Decay
            // 
            this.kEnv3Decay.Default = 0D;
            this.kEnv3Decay.Divisions = 10;
            this.kEnv3Decay.ForeColor = System.Drawing.Color.White;
            this.kEnv3Decay.HideLabels = false;
            this.kEnv3Decay.HideTicks = false;
            this.kEnv3Decay.LabelMarker0 = "0";
            this.kEnv3Decay.LabelMarker10 = "10";
            this.kEnv3Decay.LabelMarker5 = "";
            this.kEnv3Decay.LabelText = "DECAY";
            this.kEnv3Decay.LimitToDivisions = false;
            this.kEnv3Decay.Location = new System.Drawing.Point(510, 352);
            this.kEnv3Decay.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv3Decay.Max = 5D;
            this.kEnv3Decay.Min = 0D;
            this.kEnv3Decay.Name = "kEnv3Decay";
            this.kEnv3Decay.Size = new System.Drawing.Size(77, 77);
            this.kEnv3Decay.SweepAngle = 270;
            this.kEnv3Decay.TabIndex = 43;
            this.kEnv3Decay.Thickness = 2;
            this.kEnv3Decay.Value = 0D;
            // 
            // kEnv3Attack
            // 
            this.kEnv3Attack.Default = 0D;
            this.kEnv3Attack.Divisions = 10;
            this.kEnv3Attack.ForeColor = System.Drawing.Color.White;
            this.kEnv3Attack.HideLabels = false;
            this.kEnv3Attack.HideTicks = false;
            this.kEnv3Attack.LabelMarker0 = "0";
            this.kEnv3Attack.LabelMarker10 = "10";
            this.kEnv3Attack.LabelMarker5 = "";
            this.kEnv3Attack.LabelText = "ATTACK";
            this.kEnv3Attack.LimitToDivisions = false;
            this.kEnv3Attack.Location = new System.Drawing.Point(436, 352);
            this.kEnv3Attack.MarkerStyle = UI.Controls.Knob.MarkerStyleEnum.Line;
            this.kEnv3Attack.Max = 5D;
            this.kEnv3Attack.Min = 0D;
            this.kEnv3Attack.Name = "kEnv3Attack";
            this.kEnv3Attack.Size = new System.Drawing.Size(77, 77);
            this.kEnv3Attack.SweepAngle = 270;
            this.kEnv3Attack.TabIndex = 42;
            this.kEnv3Attack.Thickness = 2;
            this.kEnv3Attack.Value = 0D;
            // 
            // panel9
            // 
            this.panel9.CornerRadius = 10;
            this.panel9.LabelText = "ENV 3 - to patchbay";
            this.panel9.LineWidth = 2;
            this.panel9.Location = new System.Drawing.Point(432, 334);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(307, 105);
            this.panel9.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 50);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lblFilterType
            // 
            this.lblFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.ForeColor = System.Drawing.Color.White;
            this.lblFilterType.Location = new System.Drawing.Point(459, 102);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(156, 15);
            this.lblFilterType.TabIndex = 50;
            this.lblFilterType.Text = "Low Pass Butterworth 2 pole";
            this.lblFilterType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdViewWave
            // 
            this.cmdViewWave.Location = new System.Drawing.Point(766, 190);
            this.cmdViewWave.Name = "cmdViewWave";
            this.cmdViewWave.Size = new System.Drawing.Size(84, 28);
            this.cmdViewWave.TabIndex = 51;
            this.cmdViewWave.Text = "View Wave";
            this.cmdViewWave.UseVisualStyleBackColor = true;
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(766, 224);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(84, 28);
            this.cmdInit.TabIndex = 52;
            this.cmdInit.Text = "Init Patch";
            this.cmdInit.UseVisualStyleBackColor = true;
            // 
            // lblMidiChannel
            // 
            this.lblMidiChannel.AutoSize = true;
            this.lblMidiChannel.ForeColor = System.Drawing.Color.White;
            this.lblMidiChannel.Location = new System.Drawing.Point(740, 102);
            this.lblMidiChannel.Name = "lblMidiChannel";
            this.lblMidiChannel.Size = new System.Drawing.Size(81, 15);
            this.lblMidiChannel.TabIndex = 53;
            this.lblMidiChannel.Text = "Midi Channel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(741, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "GATE";
            // 
            // cboMidiChannel
            // 
            this.cboMidiChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMidiChannel.FormattingEnabled = true;
            this.cboMidiChannel.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cboMidiChannel.Location = new System.Drawing.Point(821, 98);
            this.cboMidiChannel.Name = "cboMidiChannel";
            this.cboMidiChannel.Size = new System.Drawing.Size(46, 23);
            this.cboMidiChannel.TabIndex = 55;
            // 
            // ledGate
            // 
            this.ledGate.LedColor = System.Drawing.Color.Red;
            this.ledGate.LedState = UI.Controls.Led.Enums.LedState.Off;
            this.ledGate.Location = new System.Drawing.Point(781, 125);
            this.ledGate.Name = "ledGate";
            this.ledGate.Size = new System.Drawing.Size(15, 15);
            this.ledGate.TabIndex = 56;
            // 
            // ledLfo1
            // 
            this.ledLfo1.LedColor = System.Drawing.Color.Red;
            this.ledLfo1.LedState = UI.Controls.Led.Enums.LedState.Off;
            this.ledLfo1.Location = new System.Drawing.Point(69, 350);
            this.ledLfo1.Name = "ledLfo1";
            this.ledLfo1.Size = new System.Drawing.Size(15, 15);
            this.ledLfo1.TabIndex = 57;
            // 
            // ledLfo2
            // 
            this.ledLfo2.LedColor = System.Drawing.Color.Red;
            this.ledLfo2.LedState = UI.Controls.Led.Enums.LedState.Off;
            this.ledLfo2.Location = new System.Drawing.Point(231, 350);
            this.ledLfo2.Name = "ledLfo2";
            this.ledLfo2.Size = new System.Drawing.Size(15, 15);
            this.ledLfo2.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.ledLfo2);
            this.Controls.Add(this.ledLfo1);
            this.Controls.Add(this.ledGate);
            this.Controls.Add(this.cboMidiChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMidiChannel);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.cmdViewWave);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kEnv3Release);
            this.Controls.Add(this.kEnv3Sustain);
            this.Controls.Add(this.kEnv3Decay);
            this.Controls.Add(this.kEnv3Attack);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.kLfo2Shape);
            this.Controls.Add(this.kLfo2Rate);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.kLfo1Shape);
            this.Controls.Add(this.kLfo1Rate);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.kNoiseMix);
            this.Controls.Add(this.kGlide);
            this.Controls.Add(this.kEnv2Release);
            this.Controls.Add(this.kEnv2Sustain);
            this.Controls.Add(this.kEnv2Decay);
            this.Controls.Add(this.kEnv2Attack);
            this.Controls.Add(this.kEnv1Release);
            this.Controls.Add(this.kEnv1Sustain);
            this.Controls.Add(this.kEnv1Decay);
            this.Controls.Add(this.kEnv1Attack);
            this.Controls.Add(this.kVcfEnvelope);
            this.Controls.Add(this.kVcfResonance);
            this.Controls.Add(this.kVcfCutoff);
            this.Controls.Add(this.kVcfType);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.kOsc3Mix);
            this.Controls.Add(this.kOsc2Mix);
            this.Controls.Add(this.kOsc1Mix);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.kOsc3Waveform);
            this.Controls.Add(this.kOsc3PW);
            this.Controls.Add(this.kOsc3Octave);
            this.Controls.Add(this.kOsc3Freq);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.kOsc2Waveform);
            this.Controls.Add(this.kOsc2PW);
            this.Controls.Add(this.kOsc2Octave);
            this.Controls.Add(this.kOsc2Freq);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kOsc1Waveform);
            this.Controls.Add(this.kOsc1PW);
            this.Controls.Add(this.kOsc1Octave);
            this.Controls.Add(this.kOsc1Freq);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Shed Prophet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Panel panel1;
        private Controls.Knob kOsc1Freq;
        private Controls.Knob kOsc1Octave;
        private Controls.Knob kOsc1PW;
        private Controls.Knob kOsc1Waveform;
        private Controls.Knob kOsc2Waveform;
        private Controls.Knob kOsc2PW;
        private Controls.Knob kOsc2Octave;
        private Controls.Knob kOsc2Freq;
        private Controls.Panel panel2;
        private Controls.Knob kOsc3Waveform;
        private Controls.Knob kOsc3PW;
        private Controls.Knob kOsc3Octave;
        private Controls.Knob kOsc3Freq;
        private Controls.Panel panel3;
        private Controls.Panel panel4;
        private Controls.Knob kOsc1Mix;
        private Controls.Knob kOsc2Mix;
        private Controls.Knob kOsc3Mix;
        private Controls.Panel panel5;
        private Controls.Panel panel6;
        private Controls.Knob kVcfType;
        private Controls.Knob kVcfCutoff;
        private Controls.Knob kVcfResonance;
        private Controls.Knob kVcfEnvelope;
        private Controls.Knob kEnv1Release;
        private Controls.Knob kEnv1Sustain;
        private Controls.Knob kEnv1Decay;
        private Controls.Knob kEnv1Attack;
        private Controls.Knob kEnv2Release;
        private Controls.Knob kEnv2Sustain;
        private Controls.Knob kEnv2Decay;
        private Controls.Knob kEnv2Attack;
        private Controls.Knob kGlide;
        private Controls.Knob kNoiseMix;
        private Controls.Panel panel7;
        private Controls.Knob kLfo1Shape;
        private Controls.Knob kLfo1Rate;
        private Controls.Panel panel8;
        private Controls.Knob kLfo2Shape;
        private Controls.Knob kLfo2Rate;
        private Controls.Knob kEnv3Release;
        private Controls.Knob kEnv3Sustain;
        private Controls.Knob kEnv3Decay;
        private Controls.Knob kEnv3Attack;
        private Controls.Panel panel9;
        private PictureBox pictureBox1;
        private Label lblFilterType;
        private Button cmdViewWave;
        private Button cmdInit;
        private Label lblMidiChannel;
        private Label label2;
        private ComboBox cboMidiChannel;
        private Controls.Led ledGate;
        private Controls.Led ledLfo1;
        private Controls.Led ledLfo2;
    }
}