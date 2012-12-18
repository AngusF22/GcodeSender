namespace GrblOutput {
	partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rowsInFileLbl = new System.Windows.Forms.Label();
            this.sentRowsLbl = new System.Windows.Forms.Label();
            this.stopPrintBtn = new System.Windows.Forms.Button();
            this.serialResponseList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.speedOverrideNumber = new System.Windows.Forms.NumericUpDown();
            this.overrideSpeedChkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollOutputChkbox = new System.Windows.Forms.CheckBox();
            this.XNbutton = new System.Windows.Forms.Button();
            this.YPbutton = new System.Windows.Forms.Button();
            this.XPbutton = new System.Windows.Forms.Button();
            this.YNbutton = new System.Windows.Forms.Button();
            this.zeroMachine = new System.Windows.Forms.Button();
            this.Xoffset = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Yoffset = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Zoffset = new System.Windows.Forms.NumericUpDown();
            this.Jog = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.feedRate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ZPbutton = new System.Windows.Forms.Button();
            this.ZNbutton = new System.Windows.Forms.Button();
            this.returnToZero = new System.Windows.Forms.Button();
            this.stepSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.feedResume = new System.Windows.Forms.Button();
            this.feedHold = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedOverrideNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yoffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoffset)).BeginInit();
            this.Jog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(231, 32);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 24);
            this.BrowseBtn.TabIndex = 0;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(102, 61);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 24);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Open";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 2;
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(183, 61);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 24);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "Close";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(252, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(6, 59);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(52, 24);
            this.PrintBtn.TabIndex = 8;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // rowsInFileLbl
            // 
            this.rowsInFileLbl.AutoSize = true;
            this.rowsInFileLbl.Location = new System.Drawing.Point(112, 93);
            this.rowsInFileLbl.Name = "rowsInFileLbl";
            this.rowsInFileLbl.Size = new System.Drawing.Size(46, 13);
            this.rowsInFileLbl.TabIndex = 12;
            this.rowsInFileLbl.Text = "Rows: 0";
            // 
            // sentRowsLbl
            // 
            this.sentRowsLbl.AutoSize = true;
            this.sentRowsLbl.Location = new System.Drawing.Point(6, 93);
            this.sentRowsLbl.Name = "sentRowsLbl";
            this.sentRowsLbl.Size = new System.Drawing.Size(66, 13);
            this.sentRowsLbl.TabIndex = 13;
            this.sentRowsLbl.Text = "Sent rows: 0";
            // 
            // stopPrintBtn
            // 
            this.stopPrintBtn.Enabled = false;
            this.stopPrintBtn.Location = new System.Drawing.Point(64, 59);
            this.stopPrintBtn.Name = "stopPrintBtn";
            this.stopPrintBtn.Size = new System.Drawing.Size(52, 24);
            this.stopPrintBtn.TabIndex = 14;
            this.stopPrintBtn.Text = "Stop";
            this.stopPrintBtn.UseVisualStyleBackColor = true;
            this.stopPrintBtn.Click += new System.EventHandler(this.stopPrintBtn_Click);
            // 
            // serialResponseList
            // 
            this.serialResponseList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.serialResponseList.FormattingEnabled = true;
            this.serialResponseList.Location = new System.Drawing.Point(13, 285);
            this.serialResponseList.Name = "serialResponseList";
            this.serialResponseList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.serialResponseList.Size = new System.Drawing.Size(584, 251);
            this.serialResponseList.TabIndex = 15;
            this.serialResponseList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.serialResponseList_DrawItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.ReloadBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(214, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "\\r\\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(164, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "\\n\\r";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Command";
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Image = global::GrblOutput.Properties.Resources.reload_icon1;
            this.ReloadBtn.Location = new System.Drawing.Point(73, 61);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(24, 24);
            this.ReloadBtn.TabIndex = 11;
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.speedOverrideNumber);
            this.groupBox2.Controls.Add(this.overrideSpeedChkbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.BrowseBtn);
            this.groupBox2.Controls.Add(this.PrintBtn);
            this.groupBox2.Controls.Add(this.stopPrintBtn);
            this.groupBox2.Controls.Add(this.rowsInFileLbl);
            this.groupBox2.Controls.Add(this.sentRowsLbl);
            this.groupBox2.Location = new System.Drawing.Point(283, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 114);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File transfer";
            // 
            // speedOverrideNumber
            // 
            this.speedOverrideNumber.Location = new System.Drawing.Point(122, 61);
            this.speedOverrideNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speedOverrideNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedOverrideNumber.Name = "speedOverrideNumber";
            this.speedOverrideNumber.Size = new System.Drawing.Size(66, 20);
            this.speedOverrideNumber.TabIndex = 18;
            this.speedOverrideNumber.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // overrideSpeedChkbox
            // 
            this.overrideSpeedChkbox.AutoSize = true;
            this.overrideSpeedChkbox.Location = new System.Drawing.Point(194, 64);
            this.overrideSpeedChkbox.Name = "overrideSpeedChkbox";
            this.overrideSpeedChkbox.Size = new System.Drawing.Size(98, 17);
            this.overrideSpeedChkbox.TabIndex = 17;
            this.overrideSpeedChkbox.Text = "Override speed";
            this.overrideSpeedChkbox.UseVisualStyleBackColor = true;
            this.overrideSpeedChkbox.CheckedChanged += new System.EventHandler(this.overrideSpeedChkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "File";
            // 
            // scrollOutputChkbox
            // 
            this.scrollOutputChkbox.AutoSize = true;
            this.scrollOutputChkbox.Checked = true;
            this.scrollOutputChkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollOutputChkbox.Location = new System.Drawing.Point(18, 109);
            this.scrollOutputChkbox.Name = "scrollOutputChkbox";
            this.scrollOutputChkbox.Size = new System.Drawing.Size(124, 17);
            this.scrollOutputChkbox.TabIndex = 18;
            this.scrollOutputChkbox.Text = "Scroll output window";
            this.scrollOutputChkbox.UseVisualStyleBackColor = true;
            // 
            // XNbutton
            // 
            this.XNbutton.Location = new System.Drawing.Point(9, 45);
            this.XNbutton.Name = "XNbutton";
            this.XNbutton.Size = new System.Drawing.Size(42, 23);
            this.XNbutton.TabIndex = 19;
            this.XNbutton.Text = "X-";
            this.XNbutton.UseVisualStyleBackColor = true;
            this.XNbutton.Click += new System.EventHandler(this.XNbutton_Click);
            // 
            // YPbutton
            // 
            this.YPbutton.Location = new System.Drawing.Point(34, 16);
            this.YPbutton.Name = "YPbutton";
            this.YPbutton.Size = new System.Drawing.Size(42, 23);
            this.YPbutton.TabIndex = 20;
            this.YPbutton.Text = "Y+";
            this.YPbutton.UseVisualStyleBackColor = true;
            this.YPbutton.Click += new System.EventHandler(this.YPbutton_Click);
            // 
            // XPbutton
            // 
            this.XPbutton.Location = new System.Drawing.Point(57, 45);
            this.XPbutton.Name = "XPbutton";
            this.XPbutton.Size = new System.Drawing.Size(42, 23);
            this.XPbutton.TabIndex = 21;
            this.XPbutton.Text = "X+";
            this.XPbutton.UseVisualStyleBackColor = true;
            this.XPbutton.Click += new System.EventHandler(this.XPbutton_Click);
            // 
            // YNbutton
            // 
            this.YNbutton.Location = new System.Drawing.Point(34, 74);
            this.YNbutton.Name = "YNbutton";
            this.YNbutton.Size = new System.Drawing.Size(42, 23);
            this.YNbutton.TabIndex = 22;
            this.YNbutton.Text = "Y-";
            this.YNbutton.UseVisualStyleBackColor = true;
            this.YNbutton.Click += new System.EventHandler(this.YNbutton_Click);
            // 
            // zeroMachine
            // 
            this.zeroMachine.Location = new System.Drawing.Point(157, 19);
            this.zeroMachine.Name = "zeroMachine";
            this.zeroMachine.Size = new System.Drawing.Size(75, 70);
            this.zeroMachine.TabIndex = 23;
            this.zeroMachine.Text = "Set Zero";
            this.zeroMachine.UseVisualStyleBackColor = true;
            this.zeroMachine.Click += new System.EventHandler(this.zeroMachine_Click);
            // 
            // Xoffset
            // 
            this.Xoffset.DecimalPlaces = 1;
            this.Xoffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Xoffset.Location = new System.Drawing.Point(30, 19);
            this.Xoffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Xoffset.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.Xoffset.Name = "Xoffset";
            this.Xoffset.Size = new System.Drawing.Size(62, 20);
            this.Xoffset.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "X offset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Y offset";
            // 
            // Yoffset
            // 
            this.Yoffset.DecimalPlaces = 1;
            this.Yoffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Yoffset.Location = new System.Drawing.Point(30, 45);
            this.Yoffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Yoffset.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.Yoffset.Name = "Yoffset";
            this.Yoffset.Size = new System.Drawing.Size(62, 20);
            this.Yoffset.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Z offset";
            // 
            // Zoffset
            // 
            this.Zoffset.DecimalPlaces = 1;
            this.Zoffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Zoffset.Location = new System.Drawing.Point(30, 74);
            this.Zoffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Zoffset.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.Zoffset.Name = "Zoffset";
            this.Zoffset.Size = new System.Drawing.Size(62, 20);
            this.Zoffset.TabIndex = 28;
            // 
            // Jog
            // 
            this.Jog.Controls.Add(this.label7);
            this.Jog.Controls.Add(this.feedRate);
            this.Jog.Controls.Add(this.label6);
            this.Jog.Controls.Add(this.ZPbutton);
            this.Jog.Controls.Add(this.ZNbutton);
            this.Jog.Controls.Add(this.returnToZero);
            this.Jog.Controls.Add(this.stepSize);
            this.Jog.Controls.Add(this.YPbutton);
            this.Jog.Controls.Add(this.XNbutton);
            this.Jog.Controls.Add(this.XPbutton);
            this.Jog.Controls.Add(this.YNbutton);
            this.Jog.Location = new System.Drawing.Point(283, 132);
            this.Jog.Name = "Jog";
            this.Jog.Size = new System.Drawing.Size(314, 109);
            this.Jog.TabIndex = 30;
            this.Jog.TabStop = false;
            this.Jog.Text = "Jog";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Feedrate";
            // 
            // feedRate
            // 
            this.feedRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.feedRate.Location = new System.Drawing.Point(154, 43);
            this.feedRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.feedRate.Name = "feedRate";
            this.feedRate.Size = new System.Drawing.Size(52, 20);
            this.feedRate.TabIndex = 34;
            this.feedRate.ThousandsSeparator = true;
            this.feedRate.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Step size (mm)";
            // 
            // ZPbutton
            // 
            this.ZPbutton.Location = new System.Drawing.Point(105, 27);
            this.ZPbutton.Name = "ZPbutton";
            this.ZPbutton.Size = new System.Drawing.Size(42, 23);
            this.ZPbutton.TabIndex = 31;
            this.ZPbutton.Text = "Z+";
            this.ZPbutton.UseVisualStyleBackColor = true;
            this.ZPbutton.Click += new System.EventHandler(this.ZPbutton_Click);
            // 
            // ZNbutton
            // 
            this.ZNbutton.Location = new System.Drawing.Point(105, 61);
            this.ZNbutton.Name = "ZNbutton";
            this.ZNbutton.Size = new System.Drawing.Size(42, 23);
            this.ZNbutton.TabIndex = 32;
            this.ZNbutton.Text = "Z-";
            this.ZNbutton.UseVisualStyleBackColor = true;
            this.ZNbutton.Click += new System.EventHandler(this.ZNbutton_Click);
            // 
            // returnToZero
            // 
            this.returnToZero.Location = new System.Drawing.Point(154, 74);
            this.returnToZero.Name = "returnToZero";
            this.returnToZero.Size = new System.Drawing.Size(154, 30);
            this.returnToZero.TabIndex = 30;
            this.returnToZero.Text = "Seek to Zero";
            this.returnToZero.UseVisualStyleBackColor = true;
            this.returnToZero.Click += new System.EventHandler(this.returnToZero_Click);
            // 
            // stepSize
            // 
            this.stepSize.DecimalPlaces = 1;
            this.stepSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.stepSize.Location = new System.Drawing.Point(153, 16);
            this.stepSize.Name = "stepSize";
            this.stepSize.Size = new System.Drawing.Size(53, 20);
            this.stepSize.TabIndex = 29;
            this.stepSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Zoffset);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Yoffset);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Xoffset);
            this.groupBox3.Controls.Add(this.zeroMachine);
            this.groupBox3.Location = new System.Drawing.Point(19, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 100);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zero adjust";
            // 
            // feedResume
            // 
            this.feedResume.Location = new System.Drawing.Point(21, 246);
            this.feedResume.Name = "feedResume";
            this.feedResume.Size = new System.Drawing.Size(275, 33);
            this.feedResume.TabIndex = 34;
            this.feedResume.Text = "Feed Resume";
            this.feedResume.UseVisualStyleBackColor = true;
            this.feedResume.Click += new System.EventHandler(this.feedResume_Click);
            // 
            // feedHold
            // 
            this.feedHold.Location = new System.Drawing.Point(302, 246);
            this.feedHold.Name = "feedHold";
            this.feedHold.Size = new System.Drawing.Size(275, 33);
            this.feedHold.TabIndex = 35;
            this.feedHold.Text = "Feed Hold";
            this.feedHold.UseVisualStyleBackColor = true;
            this.feedHold.Click += new System.EventHandler(this.feedHold_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 548);
            this.Controls.Add(this.feedHold);
            this.Controls.Add(this.feedResume);
            this.Controls.Add(this.scrollOutputChkbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.serialResponseList);
            this.Controls.Add(this.Jog);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "G-code sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedOverrideNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yoffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoffset)).EndInit();
            this.Jog.ResumeLayout(false);
            this.Jog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button BrowseBtn;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button StopBtn;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button PrintBtn;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button ReloadBtn;
		private System.Windows.Forms.Label rowsInFileLbl;
		private System.Windows.Forms.Label sentRowsLbl;
		private System.Windows.Forms.Button stopPrintBtn;
		private System.Windows.Forms.ListBox serialResponseList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.CheckBox scrollOutputChkbox;
		private System.Windows.Forms.CheckBox overrideSpeedChkbox;
		private System.Windows.Forms.NumericUpDown speedOverrideNumber;
        private System.Windows.Forms.Button XNbutton;
        private System.Windows.Forms.Button YPbutton;
        private System.Windows.Forms.Button XPbutton;
        private System.Windows.Forms.Button YNbutton;
        private System.Windows.Forms.Button zeroMachine;
        private System.Windows.Forms.NumericUpDown Xoffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Yoffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Zoffset;
        private System.Windows.Forms.GroupBox Jog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown stepSize;
        private System.Windows.Forms.Button returnToZero;
        private System.Windows.Forms.Button ZPbutton;
        private System.Windows.Forms.Button ZNbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button feedResume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown feedRate;
        private System.Windows.Forms.Button feedHold;
	}
}

