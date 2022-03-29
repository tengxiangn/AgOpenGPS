namespace AgOpenGPS
{
    partial class FormToolSteer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToolSteer));
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.lblSteerAngleActual = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFreeDrive = new System.Windows.Forms.Button();
            this.btnSteerAngleDown = new ProXoft.WinForms.RepeatButton();
            this.btnSteerAngleUp = new ProXoft.WinForms.RepeatButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSteer = new System.Windows.Forms.TabPage();
            this.label70 = new System.Windows.Forms.Label();
            this.hsbarTool_I = new System.Windows.Forms.HScrollBar();
            this.lblTool_I = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.hsbarTool_Counts = new System.Windows.Forms.HScrollBar();
            this.lblTool_Counts = new System.Windows.Forms.Label();
            this.hsbarTool_Offset = new System.Windows.Forms.HScrollBar();
            this.lblTool_Offset = new System.Windows.Forms.Label();
            this.pbarRight = new System.Windows.Forms.ProgressBar();
            this.pbarLeft = new System.Windows.Forms.ProgressBar();
            this.lblActualSteerAngleUpper = new System.Windows.Forms.Label();
            this.tabGain = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.hsbarTool_P = new System.Windows.Forms.HScrollBar();
            this.lblTool_P = new System.Windows.Forms.Label();
            this.hsbarTool_HighPWM = new System.Windows.Forms.HScrollBar();
            this.lblTool_HighPWM = new System.Windows.Forms.Label();
            this.hsbarTool_LowPWM = new System.Windows.Forms.HScrollBar();
            this.lblTool_LowPWM = new System.Windows.Forms.Label();
            this.hsbarTool_MinPWM = new System.Windows.Forms.HScrollBar();
            this.lblTool_MinPWM = new System.Windows.Forms.Label();
            this.tabStan = new System.Windows.Forms.TabPage();
            this.label161 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.nudToolAntennaHeight = new System.Windows.Forms.NumericUpDown();
            this.nudToolAntennaOffset = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.tabInt = new System.Windows.Forms.TabPage();
            this.label157 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.btnConvertToToolOnly = new System.Windows.Forms.Button();
            this.cboxGPSToolOnlyOnOff = new System.Windows.Forms.CheckBox();
            this.label154 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.cboxGPSNormal = new System.Windows.Forms.CheckBox();
            this.cboxGPSToolOnOff = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pboxSendToolSteer = new System.Windows.Forms.PictureBox();
            this.btnSendToolSteer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPWMDisplay = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSteer.SuspendLayout();
            this.tabGain.SuspendLayout();
            this.tabStan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToolAntennaHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToolAntennaOffset)).BeginInit();
            this.tabInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendToolSteer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSteerAngle
            // 
            this.lblSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngle.ForeColor = System.Drawing.Color.Black;
            this.lblSteerAngle.Location = new System.Drawing.Point(52, 5);
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Size = new System.Drawing.Size(70, 23);
            this.lblSteerAngle.TabIndex = 306;
            this.lblSteerAngle.Text = "-55.5";
            this.lblSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSteerAngle.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // lblSteerAngleActual
            // 
            this.lblSteerAngleActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteerAngleActual.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngleActual.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngleActual.ForeColor = System.Drawing.Color.Black;
            this.lblSteerAngleActual.Location = new System.Drawing.Point(174, 5);
            this.lblSteerAngleActual.Name = "lblSteerAngleActual";
            this.lblSteerAngleActual.Size = new System.Drawing.Size(70, 23);
            this.lblSteerAngleActual.TabIndex = 311;
            this.lblSteerAngleActual.Text = "-55.5";
            this.lblSteerAngleActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSteerAngleActual.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(286, 5);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(62, 23);
            this.lblError.TabIndex = 312;
            this.lblError.Text = "-30.0";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(11, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 318;
            this.label9.Text = "PWM:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(133, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 23);
            this.label11.TabIndex = 319;
            this.label11.Text = "Act:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(7, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 23);
            this.label12.TabIndex = 320;
            this.label12.Text = "Set:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(246, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 23);
            this.label13.TabIndex = 321;
            this.label13.Text = "Err:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // btnFreeDrive
            // 
            this.btnFreeDrive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFreeDrive.FlatAppearance.BorderSize = 0;
            this.btnFreeDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreeDrive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFreeDrive.Image = global::AgOpenGPS.Properties.Resources.SteerDriveOff;
            this.btnFreeDrive.Location = new System.Drawing.Point(16, 112);
            this.btnFreeDrive.Name = "btnFreeDrive";
            this.btnFreeDrive.Size = new System.Drawing.Size(73, 56);
            this.btnFreeDrive.TabIndex = 228;
            this.btnFreeDrive.UseVisualStyleBackColor = false;
            this.btnFreeDrive.Click += new System.EventHandler(this.btnFreeDrive_Click);
            this.btnFreeDrive.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnFreeDrive_HelpRequested);
            // 
            // btnSteerAngleDown
            // 
            this.btnSteerAngleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleDown.FlatAppearance.BorderSize = 0;
            this.btnSteerAngleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteerAngleDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleDown.Image = global::AgOpenGPS.Properties.Resources.ArrowLeft;
            this.btnSteerAngleDown.Location = new System.Drawing.Point(107, 112);
            this.btnSteerAngleDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleDown.Name = "btnSteerAngleDown";
            this.btnSteerAngleDown.Size = new System.Drawing.Size(73, 56);
            this.btnSteerAngleDown.TabIndex = 314;
            this.btnSteerAngleDown.UseVisualStyleBackColor = true;
            this.btnSteerAngleDown.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSteerAngleDown_HelpRequested);
            this.btnSteerAngleDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleDown_MouseDown);
            // 
            // btnSteerAngleUp
            // 
            this.btnSteerAngleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleUp.FlatAppearance.BorderSize = 0;
            this.btnSteerAngleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteerAngleUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleUp.Image = global::AgOpenGPS.Properties.Resources.ArrowRight;
            this.btnSteerAngleUp.Location = new System.Drawing.Point(198, 112);
            this.btnSteerAngleUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleUp.Name = "btnSteerAngleUp";
            this.btnSteerAngleUp.Size = new System.Drawing.Size(73, 56);
            this.btnSteerAngleUp.TabIndex = 315;
            this.btnSteerAngleUp.UseVisualStyleBackColor = true;
            this.btnSteerAngleUp.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSteerAngleUp_HelpRequested);
            this.btnSteerAngleUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleUp_MouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabSteer);
            this.tabControl1.Controls.Add(this.tabGain);
            this.tabControl1.Controls.Add(this.tabStan);
            this.tabControl1.Controls.Add(this.tabInt);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(86, 48);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 379);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 347;
            // 
            // tabSteer
            // 
            this.tabSteer.AutoScroll = true;
            this.tabSteer.BackColor = System.Drawing.Color.Gainsboro;
            this.tabSteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabSteer.Controls.Add(this.label70);
            this.tabSteer.Controls.Add(this.hsbarTool_I);
            this.tabSteer.Controls.Add(this.lblTool_I);
            this.tabSteer.Controls.Add(this.label158);
            this.tabSteer.Controls.Add(this.label62);
            this.tabSteer.Controls.Add(this.hsbarTool_Counts);
            this.tabSteer.Controls.Add(this.lblTool_Counts);
            this.tabSteer.Controls.Add(this.hsbarTool_Offset);
            this.tabSteer.Controls.Add(this.lblTool_Offset);
            this.tabSteer.Controls.Add(this.pbarRight);
            this.tabSteer.Controls.Add(this.pbarLeft);
            this.tabSteer.Controls.Add(this.lblActualSteerAngleUpper);
            this.tabSteer.ImageIndex = 0;
            this.tabSteer.Location = new System.Drawing.Point(4, 52);
            this.tabSteer.Name = "tabSteer";
            this.tabSteer.Size = new System.Drawing.Size(348, 323);
            this.tabSteer.TabIndex = 5;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.Black;
            this.label70.Location = new System.Drawing.Point(89, 233);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(19, 23);
            this.label70.TabIndex = 536;
            this.label70.Text = "I";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarTool_I
            // 
            this.hsbarTool_I.LargeChange = 1;
            this.hsbarTool_I.Location = new System.Drawing.Point(64, 259);
            this.hsbarTool_I.Maximum = 255;
            this.hsbarTool_I.Name = "hsbarTool_I";
            this.hsbarTool_I.Size = new System.Drawing.Size(256, 30);
            this.hsbarTool_I.TabIndex = 534;
            this.hsbarTool_I.Value = 20;
            this.hsbarTool_I.ValueChanged += new System.EventHandler(this.hsbarTool_I_ValueChanged);
            // 
            // lblTool_I
            // 
            this.lblTool_I.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool_I.ForeColor = System.Drawing.Color.Black;
            this.lblTool_I.Location = new System.Drawing.Point(8, 255);
            this.lblTool_I.Name = "lblTool_I";
            this.lblTool_I.Size = new System.Drawing.Size(55, 35);
            this.lblTool_I.TabIndex = 535;
            this.lblTool_I.Text = "888";
            this.lblTool_I.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.ForeColor = System.Drawing.Color.Black;
            this.label158.Location = new System.Drawing.Point(89, 58);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(68, 23);
            this.label158.TabIndex = 533;
            this.label158.Text = "Offset";
            this.label158.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Location = new System.Drawing.Point(89, 145);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(77, 23);
            this.label62.TabIndex = 532;
            this.label62.Text = "Counts";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarTool_Counts
            // 
            this.hsbarTool_Counts.LargeChange = 1;
            this.hsbarTool_Counts.Location = new System.Drawing.Point(64, 172);
            this.hsbarTool_Counts.Maximum = 255;
            this.hsbarTool_Counts.Name = "hsbarTool_Counts";
            this.hsbarTool_Counts.Size = new System.Drawing.Size(256, 30);
            this.hsbarTool_Counts.TabIndex = 530;
            this.hsbarTool_Counts.Value = 20;
            this.hsbarTool_Counts.ValueChanged += new System.EventHandler(this.hsbarTool_Counts_ValueChanged);
            // 
            // lblTool_Counts
            // 
            this.lblTool_Counts.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool_Counts.ForeColor = System.Drawing.Color.Black;
            this.lblTool_Counts.Location = new System.Drawing.Point(6, 169);
            this.lblTool_Counts.Name = "lblTool_Counts";
            this.lblTool_Counts.Size = new System.Drawing.Size(55, 35);
            this.lblTool_Counts.TabIndex = 531;
            this.lblTool_Counts.Text = "888";
            this.lblTool_Counts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarTool_Offset
            // 
            this.hsbarTool_Offset.LargeChange = 1;
            this.hsbarTool_Offset.Location = new System.Drawing.Point(64, 85);
            this.hsbarTool_Offset.Maximum = 255;
            this.hsbarTool_Offset.Name = "hsbarTool_Offset";
            this.hsbarTool_Offset.Size = new System.Drawing.Size(256, 30);
            this.hsbarTool_Offset.TabIndex = 528;
            this.hsbarTool_Offset.Value = 20;
            this.hsbarTool_Offset.ValueChanged += new System.EventHandler(this.hsbarTool_Offset_ValueChanged);
            // 
            // lblTool_Offset
            // 
            this.lblTool_Offset.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool_Offset.ForeColor = System.Drawing.Color.Black;
            this.lblTool_Offset.Location = new System.Drawing.Point(6, 82);
            this.lblTool_Offset.Name = "lblTool_Offset";
            this.lblTool_Offset.Size = new System.Drawing.Size(55, 35);
            this.lblTool_Offset.TabIndex = 529;
            this.lblTool_Offset.Text = "888";
            this.lblTool_Offset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbarRight
            // 
            this.pbarRight.Location = new System.Drawing.Point(171, 6);
            this.pbarRight.Maximum = 50;
            this.pbarRight.Name = "pbarRight";
            this.pbarRight.Size = new System.Drawing.Size(159, 10);
            this.pbarRight.TabIndex = 330;
            // 
            // pbarLeft
            // 
            this.pbarLeft.Location = new System.Drawing.Point(11, 6);
            this.pbarLeft.Maximum = 50;
            this.pbarLeft.Name = "pbarLeft";
            this.pbarLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbarLeft.RightToLeftLayout = true;
            this.pbarLeft.Size = new System.Drawing.Size(159, 10);
            this.pbarLeft.TabIndex = 329;
            // 
            // lblActualSteerAngleUpper
            // 
            this.lblActualSteerAngleUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActualSteerAngleUpper.AutoSize = true;
            this.lblActualSteerAngleUpper.BackColor = System.Drawing.Color.Transparent;
            this.lblActualSteerAngleUpper.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualSteerAngleUpper.ForeColor = System.Drawing.Color.Black;
            this.lblActualSteerAngleUpper.Location = new System.Drawing.Point(-38, 19);
            this.lblActualSteerAngleUpper.Name = "lblActualSteerAngleUpper";
            this.lblActualSteerAngleUpper.Size = new System.Drawing.Size(39, 19);
            this.lblActualSteerAngleUpper.TabIndex = 324;
            this.lblActualSteerAngleUpper.Text = "255";
            this.lblActualSteerAngleUpper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabGain
            // 
            this.tabGain.AutoScroll = true;
            this.tabGain.BackColor = System.Drawing.Color.Gainsboro;
            this.tabGain.BackgroundImage = global::AgOpenGPS.Properties.Resources.Sf_GainTab;
            this.tabGain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabGain.Controls.Add(this.label1);
            this.tabGain.Controls.Add(this.label160);
            this.tabGain.Controls.Add(this.label5);
            this.tabGain.Controls.Add(this.label153);
            this.tabGain.Controls.Add(this.hsbarTool_P);
            this.tabGain.Controls.Add(this.lblTool_P);
            this.tabGain.Controls.Add(this.hsbarTool_HighPWM);
            this.tabGain.Controls.Add(this.lblTool_HighPWM);
            this.tabGain.Controls.Add(this.hsbarTool_LowPWM);
            this.tabGain.Controls.Add(this.lblTool_LowPWM);
            this.tabGain.Controls.Add(this.hsbarTool_MinPWM);
            this.tabGain.Controls.Add(this.lblTool_MinPWM);
            this.tabGain.ImageIndex = 1;
            this.tabGain.Location = new System.Drawing.Point(4, 52);
            this.tabGain.Name = "tabGain";
            this.tabGain.Size = new System.Drawing.Size(348, 323);
            this.tabGain.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 536;
            this.label1.Text = "P";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.ForeColor = System.Drawing.Color.Black;
            this.label160.Location = new System.Drawing.Point(87, 87);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(55, 23);
            this.label160.TabIndex = 535;
            this.label160.Text = "High";
            this.label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(87, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 534;
            this.label5.Text = "Low";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.ForeColor = System.Drawing.Color.Black;
            this.label153.Location = new System.Drawing.Point(87, 239);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(45, 23);
            this.label153.TabIndex = 533;
            this.label153.Text = "Min";
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarTool_P
            // 
            this.hsbarTool_P.LargeChange = 1;
            this.hsbarTool_P.Location = new System.Drawing.Point(56, 35);
            this.hsbarTool_P.Maximum = 255;
            this.hsbarTool_P.Name = "hsbarTool_P";
            this.hsbarTool_P.Size = new System.Drawing.Size(213, 30);
            this.hsbarTool_P.TabIndex = 531;
            this.hsbarTool_P.Value = 20;
            this.hsbarTool_P.ValueChanged += new System.EventHandler(this.hsbarTool_P_ValueChanged);
            // 
            // lblTool_P
            // 
            this.lblTool_P.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool_P.ForeColor = System.Drawing.Color.Black;
            this.lblTool_P.Location = new System.Drawing.Point(3, 32);
            this.lblTool_P.Name = "lblTool_P";
            this.lblTool_P.Size = new System.Drawing.Size(55, 35);
            this.lblTool_P.TabIndex = 532;
            this.lblTool_P.Text = "888";
            this.lblTool_P.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarTool_HighPWM
            // 
            this.hsbarTool_HighPWM.LargeChange = 1;
            this.hsbarTool_HighPWM.Location = new System.Drawing.Point(56, 110);
            this.hsbarTool_HighPWM.Maximum = 255;
            this.hsbarTool_HighPWM.Name = "hsbarTool_HighPWM";
            this.hsbarTool_HighPWM.Size = new System.Drawing.Size(213, 30);
            this.hsbarTool_HighPWM.TabIndex = 529;
            this.hsbarTool_HighPWM.Value = 20;
            this.hsbarTool_HighPWM.ValueChanged += new System.EventHandler(this.hsbarTool_HighPWM_ValueChanged);
            // 
            // lblTool_HighPWM
            // 
            this.lblTool_HighPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool_HighPWM.ForeColor = System.Drawing.Color.Black;
            this.lblTool_HighPWM.Location = new System.Drawing.Point(3, 108);
            this.lblTool_HighPWM.Name = "lblTool_HighPWM";
            this.lblTool_HighPWM.Size = new System.Drawing.Size(55, 35);
            this.lblTool_HighPWM.TabIndex = 530;
            this.lblTool_HighPWM.Text = "888";
            this.lblTool_HighPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarTool_LowPWM
            // 
            this.hsbarTool_LowPWM.LargeChange = 1;
            this.hsbarTool_LowPWM.Location = new System.Drawing.Point(56, 187);
            this.hsbarTool_LowPWM.Maximum = 255;
            this.hsbarTool_LowPWM.Name = "hsbarTool_LowPWM";
            this.hsbarTool_LowPWM.Size = new System.Drawing.Size(213, 30);
            this.hsbarTool_LowPWM.TabIndex = 527;
            this.hsbarTool_LowPWM.Value = 20;
            this.hsbarTool_LowPWM.ValueChanged += new System.EventHandler(this.hsbarTool_LowPWM_ValueChanged);
            // 
            // lblTool_LowPWM
            // 
            this.lblTool_LowPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool_LowPWM.ForeColor = System.Drawing.Color.Black;
            this.lblTool_LowPWM.Location = new System.Drawing.Point(3, 184);
            this.lblTool_LowPWM.Name = "lblTool_LowPWM";
            this.lblTool_LowPWM.Size = new System.Drawing.Size(55, 35);
            this.lblTool_LowPWM.TabIndex = 528;
            this.lblTool_LowPWM.Text = "888";
            this.lblTool_LowPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarTool_MinPWM
            // 
            this.hsbarTool_MinPWM.LargeChange = 1;
            this.hsbarTool_MinPWM.Location = new System.Drawing.Point(56, 262);
            this.hsbarTool_MinPWM.Maximum = 255;
            this.hsbarTool_MinPWM.Name = "hsbarTool_MinPWM";
            this.hsbarTool_MinPWM.Size = new System.Drawing.Size(213, 30);
            this.hsbarTool_MinPWM.TabIndex = 525;
            this.hsbarTool_MinPWM.Value = 20;
            this.hsbarTool_MinPWM.ValueChanged += new System.EventHandler(this.hsbarTool_MinPWM_ValueChanged);
            // 
            // lblTool_MinPWM
            // 
            this.lblTool_MinPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool_MinPWM.ForeColor = System.Drawing.Color.Black;
            this.lblTool_MinPWM.Location = new System.Drawing.Point(3, 260);
            this.lblTool_MinPWM.Name = "lblTool_MinPWM";
            this.lblTool_MinPWM.Size = new System.Drawing.Size(55, 35);
            this.lblTool_MinPWM.TabIndex = 526;
            this.lblTool_MinPWM.Text = "888";
            this.lblTool_MinPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabStan
            // 
            this.tabStan.BackColor = System.Drawing.Color.Gainsboro;
            this.tabStan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabStan.Controls.Add(this.label161);
            this.tabStan.Controls.Add(this.label159);
            this.tabStan.Controls.Add(this.nudToolAntennaHeight);
            this.tabStan.Controls.Add(this.nudToolAntennaOffset);
            this.tabStan.Controls.Add(this.label25);
            this.tabStan.ImageIndex = 2;
            this.tabStan.Location = new System.Drawing.Point(4, 52);
            this.tabStan.Name = "tabStan";
            this.tabStan.Size = new System.Drawing.Size(348, 323);
            this.tabStan.TabIndex = 15;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.ForeColor = System.Drawing.Color.Black;
            this.label161.Location = new System.Drawing.Point(124, 186);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(115, 19);
            this.label161.TabIndex = 536;
            this.label161.Text = "Antenna Offset";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.ForeColor = System.Drawing.Color.Black;
            this.label159.Location = new System.Drawing.Point(124, 63);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(119, 19);
            this.label159.TabIndex = 535;
            this.label159.Text = "Antenna Height";
            // 
            // nudToolAntennaHeight
            // 
            this.nudToolAntennaHeight.BackColor = System.Drawing.Color.AliceBlue;
            this.nudToolAntennaHeight.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudToolAntennaHeight.InterceptArrowKeys = false;
            this.nudToolAntennaHeight.Location = new System.Drawing.Point(102, 83);
            this.nudToolAntennaHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudToolAntennaHeight.Name = "nudToolAntennaHeight";
            this.nudToolAntennaHeight.ReadOnly = true;
            this.nudToolAntennaHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudToolAntennaHeight.Size = new System.Drawing.Size(144, 52);
            this.nudToolAntennaHeight.TabIndex = 534;
            this.nudToolAntennaHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudToolAntennaHeight.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudToolAntennaHeight.Click += new System.EventHandler(this.nudToolAntennaHeight_Click);
            // 
            // nudToolAntennaOffset
            // 
            this.nudToolAntennaOffset.BackColor = System.Drawing.Color.AliceBlue;
            this.nudToolAntennaOffset.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudToolAntennaOffset.InterceptArrowKeys = false;
            this.nudToolAntennaOffset.Location = new System.Drawing.Point(102, 207);
            this.nudToolAntennaOffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudToolAntennaOffset.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nudToolAntennaOffset.Name = "nudToolAntennaOffset";
            this.nudToolAntennaOffset.ReadOnly = true;
            this.nudToolAntennaOffset.Size = new System.Drawing.Size(144, 52);
            this.nudToolAntennaOffset.TabIndex = 533;
            this.nudToolAntennaOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudToolAntennaOffset.Click += new System.EventHandler(this.nudToolAntennaOffset_Click);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.SandyBrown;
            this.label25.Location = new System.Drawing.Point(117, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 31);
            this.label25.TabIndex = 347;
            this.label25.Text = "Stanley";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabInt
            // 
            this.tabInt.BackColor = System.Drawing.Color.Gainsboro;
            this.tabInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabInt.Controls.Add(this.label157);
            this.tabInt.Controls.Add(this.label156);
            this.tabInt.Controls.Add(this.btnConvertToToolOnly);
            this.tabInt.Controls.Add(this.cboxGPSToolOnlyOnOff);
            this.tabInt.Controls.Add(this.label154);
            this.tabInt.Controls.Add(this.label105);
            this.tabInt.Controls.Add(this.cboxGPSNormal);
            this.tabInt.Controls.Add(this.cboxGPSToolOnOff);
            this.tabInt.Controls.Add(this.label20);
            this.tabInt.Controls.Add(this.label18);
            this.tabInt.ForeColor = System.Drawing.Color.Black;
            this.tabInt.ImageIndex = 3;
            this.tabInt.Location = new System.Drawing.Point(4, 52);
            this.tabInt.Name = "tabInt";
            this.tabInt.Size = new System.Drawing.Size(348, 323);
            this.tabInt.TabIndex = 16;
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.ForeColor = System.Drawing.Color.Black;
            this.label157.Location = new System.Drawing.Point(166, 173);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(123, 19);
            this.label157.TabIndex = 528;
            this.label157.Text = "Change Settings";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.ForeColor = System.Drawing.Color.Black;
            this.label156.Location = new System.Drawing.Point(56, 173);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(79, 19);
            this.label156.TabIndex = 527;
            this.label156.Text = "Tool Only";
            // 
            // btnConvertToToolOnly
            // 
            this.btnConvertToToolOnly.BackColor = System.Drawing.Color.Transparent;
            this.btnConvertToToolOnly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnConvertToToolOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertToToolOnly.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToToolOnly.ForeColor = System.Drawing.Color.Black;
            this.btnConvertToToolOnly.Location = new System.Drawing.Point(175, 194);
            this.btnConvertToToolOnly.Name = "btnConvertToToolOnly";
            this.btnConvertToToolOnly.Size = new System.Drawing.Size(82, 70);
            this.btnConvertToToolOnly.TabIndex = 526;
            this.btnConvertToToolOnly.Text = "Set To Tool";
            this.btnConvertToToolOnly.UseVisualStyleBackColor = false;
            this.btnConvertToToolOnly.Click += new System.EventHandler(this.btnConvertToToolOnly_Click);
            // 
            // cboxGPSToolOnlyOnOff
            // 
            this.cboxGPSToolOnlyOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxGPSToolOnlyOnOff.AutoCheck = false;
            this.cboxGPSToolOnlyOnOff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxGPSToolOnlyOnOff.BackgroundImage = global::AgOpenGPS.Properties.Resources.GPS_Tool;
            this.cboxGPSToolOnlyOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cboxGPSToolOnlyOnOff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxGPSToolOnlyOnOff.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxGPSToolOnlyOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxGPSToolOnlyOnOff.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGPSToolOnlyOnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxGPSToolOnlyOnOff.Location = new System.Drawing.Point(36, 192);
            this.cboxGPSToolOnlyOnOff.Name = "cboxGPSToolOnlyOnOff";
            this.cboxGPSToolOnlyOnOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxGPSToolOnlyOnOff.Size = new System.Drawing.Size(115, 72);
            this.cboxGPSToolOnlyOnOff.TabIndex = 525;
            this.cboxGPSToolOnlyOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxGPSToolOnlyOnOff.UseVisualStyleBackColor = false;
            this.cboxGPSToolOnlyOnOff.Click += new System.EventHandler(this.cboxGPSToolOnlyOnOff_Click);
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.ForeColor = System.Drawing.Color.Black;
            this.label154.Location = new System.Drawing.Point(182, 47);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(113, 19);
            this.label154.TabIndex = 524;
            this.label154.Text = "Vehicle + Tool";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.ForeColor = System.Drawing.Color.Black;
            this.label105.Location = new System.Drawing.Point(45, 46);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(97, 19);
            this.label105.TabIndex = 523;
            this.label105.Text = "Vehicle Only";
            // 
            // cboxGPSNormal
            // 
            this.cboxGPSNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxGPSNormal.AutoCheck = false;
            this.cboxGPSNormal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxGPSNormal.BackgroundImage = global::AgOpenGPS.Properties.Resources.GPS_Vehicle;
            this.cboxGPSNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cboxGPSNormal.Checked = true;
            this.cboxGPSNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxGPSNormal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxGPSNormal.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxGPSNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxGPSNormal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGPSNormal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxGPSNormal.Location = new System.Drawing.Point(31, 66);
            this.cboxGPSNormal.Name = "cboxGPSNormal";
            this.cboxGPSNormal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxGPSNormal.Size = new System.Drawing.Size(115, 72);
            this.cboxGPSNormal.TabIndex = 522;
            this.cboxGPSNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxGPSNormal.UseVisualStyleBackColor = false;
            this.cboxGPSNormal.Click += new System.EventHandler(this.cboxGPSNormal_Click);
            // 
            // cboxGPSToolOnOff
            // 
            this.cboxGPSToolOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxGPSToolOnOff.AutoCheck = false;
            this.cboxGPSToolOnOff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxGPSToolOnOff.BackgroundImage = global::AgOpenGPS.Properties.Resources.GPS_ToolVehicle;
            this.cboxGPSToolOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cboxGPSToolOnOff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxGPSToolOnOff.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxGPSToolOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxGPSToolOnOff.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGPSToolOnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxGPSToolOnOff.Location = new System.Drawing.Point(164, 66);
            this.cboxGPSToolOnOff.Name = "cboxGPSToolOnOff";
            this.cboxGPSToolOnOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxGPSToolOnOff.Size = new System.Drawing.Size(115, 72);
            this.cboxGPSToolOnOff.TabIndex = 521;
            this.cboxGPSToolOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxGPSToolOnOff.UseVisualStyleBackColor = false;
            this.cboxGPSToolOnOff.Click += new System.EventHandler(this.cboxGPSToolOnOff_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(579, 228);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(204, 30);
            this.label20.TabIndex = 302;
            this.label20.Text = "Look Ahead Min";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(561, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(204, 30);
            this.label18.TabIndex = 300;
            this.label18.Text = "Look Ahead";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ST_SteerTab.png");
            this.imageList1.Images.SetKeyName(1, "ST_GainTab.png");
            this.imageList1.Images.SetKeyName(2, "ST_StanleyTab.png");
            this.imageList1.Images.SetKeyName(3, "Sf_PPTab.png");
            // 
            // pboxSendToolSteer
            // 
            this.pboxSendToolSteer.BackgroundImage = global::AgOpenGPS.Properties.Resources.ConSt_Mandatory1;
            this.pboxSendToolSteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxSendToolSteer.Location = new System.Drawing.Point(275, 14);
            this.pboxSendToolSteer.Name = "pboxSendToolSteer";
            this.pboxSendToolSteer.Size = new System.Drawing.Size(68, 55);
            this.pboxSendToolSteer.TabIndex = 509;
            this.pboxSendToolSteer.TabStop = false;
            this.pboxSendToolSteer.Visible = false;
            this.pboxSendToolSteer.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.pboxSendSteer_HelpRequested);
            // 
            // btnSendToolSteer
            // 
            this.btnSendToolSteer.BackColor = System.Drawing.Color.Transparent;
            this.btnSendToolSteer.FlatAppearance.BorderSize = 0;
            this.btnSendToolSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToolSteer.Image = global::AgOpenGPS.Properties.Resources.ToolAcceptChange;
            this.btnSendToolSteer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSendToolSteer.Location = new System.Drawing.Point(170, 14);
            this.btnSendToolSteer.Name = "btnSendToolSteer";
            this.btnSendToolSteer.Size = new System.Drawing.Size(103, 55);
            this.btnSendToolSteer.TabIndex = 501;
            this.btnSendToolSteer.UseVisualStyleBackColor = false;
            this.btnSendToolSteer.Click += new System.EventHandler(this.btnSendToolSteer_Click);
            this.btnSendToolSteer.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.pboxSendSteer_HelpRequested);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblSteerAngle);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblSteerAngleActual);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(4, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 34);
            this.panel2.TabIndex = 324;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnSteerAngleUp);
            this.panel1.Controls.Add(this.pboxSendToolSteer);
            this.panel1.Controls.Add(this.btnFreeDrive);
            this.panel1.Controls.Add(this.btnSteerAngleDown);
            this.panel1.Controls.Add(this.btnSendToolSteer);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblPWMDisplay);
            this.panel1.Location = new System.Drawing.Point(4, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 78);
            this.panel1.TabIndex = 323;
            // 
            // lblPWMDisplay
            // 
            this.lblPWMDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblPWMDisplay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWMDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPWMDisplay.Location = new System.Drawing.Point(69, 17);
            this.lblPWMDisplay.Name = "lblPWMDisplay";
            this.lblPWMDisplay.Size = new System.Drawing.Size(64, 23);
            this.lblPWMDisplay.TabIndex = 316;
            this.lblPWMDisplay.Text = "255";
            this.lblPWMDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormToolSteer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 663);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(381, 545);
            this.Name = "FormToolSteer";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tool Steer Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSteer_FormClosing);
            this.Load += new System.EventHandler(this.FormSteer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSteer.ResumeLayout(false);
            this.tabSteer.PerformLayout();
            this.tabGain.ResumeLayout(false);
            this.tabGain.PerformLayout();
            this.tabStan.ResumeLayout(false);
            this.tabStan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToolAntennaHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToolAntennaOffset)).EndInit();
            this.tabInt.ResumeLayout(false);
            this.tabInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendToolSteer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Label lblSteerAngleActual;
        private System.Windows.Forms.Label lblError;
        private ProXoft.WinForms.RepeatButton btnSteerAngleDown;
        private ProXoft.WinForms.RepeatButton btnSteerAngleUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGain;
        private System.Windows.Forms.TabPage tabStan;
        private System.Windows.Forms.TabPage tabInt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabSteer;
        private System.Windows.Forms.ProgressBar pbarRight;
        private System.Windows.Forms.ProgressBar pbarLeft;
        private System.Windows.Forms.Label lblActualSteerAngleUpper;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pboxSendToolSteer;
        private System.Windows.Forms.Button btnSendToolSteer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.CheckBox cboxGPSNormal;
        private System.Windows.Forms.CheckBox cboxGPSToolOnOff;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Button btnConvertToToolOnly;
        private System.Windows.Forms.CheckBox cboxGPSToolOnlyOnOff;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.NumericUpDown nudToolAntennaHeight;
        private System.Windows.Forms.NumericUpDown nudToolAntennaOffset;
        private System.Windows.Forms.HScrollBar hsbarTool_HighPWM;
        private System.Windows.Forms.Label lblTool_HighPWM;
        private System.Windows.Forms.HScrollBar hsbarTool_LowPWM;
        private System.Windows.Forms.Label lblTool_LowPWM;
        private System.Windows.Forms.HScrollBar hsbarTool_MinPWM;
        private System.Windows.Forms.Label lblTool_MinPWM;
        private System.Windows.Forms.HScrollBar hsbarTool_P;
        private System.Windows.Forms.Label lblTool_P;
        private System.Windows.Forms.HScrollBar hsbarTool_Offset;
        private System.Windows.Forms.Label lblTool_Offset;
        private System.Windows.Forms.HScrollBar hsbarTool_Counts;
        private System.Windows.Forms.Label lblTool_Counts;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hsbarTool_I;
        private System.Windows.Forms.Label lblTool_I;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label lblPWMDisplay;
    }
}