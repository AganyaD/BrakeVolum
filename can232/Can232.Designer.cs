namespace CAN232_Monitor
{
    partial class Can232
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.grpboxComPort = new System.Windows.Forms.GroupBox();
            this.btnComClose = new System.Windows.Forms.Button();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.lblComSpeed = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cmbComSpeed = new System.Windows.Forms.ComboBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.grpboxCanCommands = new System.Windows.Forms.GroupBox();
            this.btnAutoOff = new System.Windows.Forms.Button();
            this.btnAutoOn = new System.Windows.Forms.Button();
            this.btnTimeStampOff = new System.Windows.Forms.Button();
            this.btnTimeStampOn = new System.Windows.Forms.Button();
            this.btnPollAll = new System.Windows.Forms.Button();
            this.btnPollOne = new System.Windows.Forms.Button();
            this.btnSerNo = new System.Windows.Forms.Button();
            this.btnCanVersion = new System.Windows.Forms.Button();
            this.btnCanFlags = new System.Windows.Forms.Button();
            this.btnCanClose = new System.Windows.Forms.Button();
            this.btnCanOpen = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCanBitrate = new System.Windows.Forms.ComboBox();
            this.grpboxCanFrameTransmit = new System.Windows.Forms.GroupBox();
            this.lblDataBytes = new System.Windows.Forms.Label();
            this.lblDlc = new System.Windows.Forms.Label();
            this.lblCanId = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.btnSendFrame = new System.Windows.Forms.Button();
            this.tbxHex1 = new System.Windows.Forms.TextBox();
            this.cboxRtr = new System.Windows.Forms.CheckBox();
            this.tbxHex2 = new System.Windows.Forms.TextBox();
            this.cboxExt = new System.Windows.Forms.CheckBox();
            this.numDlc = new System.Windows.Forms.NumericUpDown();
            this.tbxHex3 = new System.Windows.Forms.TextBox();
            this.tbxHex8 = new System.Windows.Forms.TextBox();
            this.tbxHex4 = new System.Windows.Forms.TextBox();
            this.tbxHex7 = new System.Windows.Forms.TextBox();
            this.tbxHex5 = new System.Windows.Forms.TextBox();
            this.tbxHex6 = new System.Windows.Forms.TextBox();
            this.grpboxCanFrameReceive = new System.Windows.Forms.GroupBox();
            this.rtboxReceive = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpboxComPort.SuspendLayout();
            this.grpboxCanCommands.SuspendLayout();
            this.grpboxCanFrameTransmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDlc)).BeginInit();
            this.grpboxCanFrameReceive.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // grpboxComPort
            // 
            this.grpboxComPort.Controls.Add(this.btnComClose);
            this.grpboxComPort.Controls.Add(this.btnComOpen);
            this.grpboxComPort.Controls.Add(this.lblComSpeed);
            this.grpboxComPort.Controls.Add(this.lblComPort);
            this.grpboxComPort.Controls.Add(this.cmbComSpeed);
            this.grpboxComPort.Controls.Add(this.cmbComPort);
            this.grpboxComPort.Location = new System.Drawing.Point(353, 12);
            this.grpboxComPort.Name = "grpboxComPort";
            this.grpboxComPort.Size = new System.Drawing.Size(173, 93);
            this.grpboxComPort.TabIndex = 1;
            this.grpboxComPort.TabStop = false;
            this.grpboxComPort.Text = "COM Port Settings";
            // 
            // btnComClose
            // 
            this.btnComClose.Enabled = false;
            this.btnComClose.Location = new System.Drawing.Point(92, 64);
            this.btnComClose.Name = "btnComClose";
            this.btnComClose.Size = new System.Drawing.Size(75, 23);
            this.btnComClose.TabIndex = 18;
            this.btnComClose.Text = "Close";
            this.btnComClose.UseVisualStyleBackColor = true;
            this.btnComClose.Click += new System.EventHandler(this.btnComClose_Click);
            // 
            // btnComOpen
            // 
            this.btnComOpen.Location = new System.Drawing.Point(6, 64);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(75, 23);
            this.btnComOpen.TabIndex = 17;
            this.btnComOpen.Text = "Open";
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // lblComSpeed
            // 
            this.lblComSpeed.AutoSize = true;
            this.lblComSpeed.Location = new System.Drawing.Point(89, 21);
            this.lblComSpeed.Name = "lblComSpeed";
            this.lblComSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblComSpeed.TabIndex = 16;
            this.lblComSpeed.Text = "Speed";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(3, 21);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(26, 13);
            this.lblComPort.TabIndex = 15;
            this.lblComPort.Text = "Port";
            // 
            // cmbComSpeed
            // 
            this.cmbComSpeed.FormattingEnabled = true;
            this.cmbComSpeed.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbComSpeed.Location = new System.Drawing.Point(92, 37);
            this.cmbComSpeed.Name = "cmbComSpeed";
            this.cmbComSpeed.Size = new System.Drawing.Size(75, 21);
            this.cmbComSpeed.TabIndex = 14;
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(6, 37);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(75, 21);
            this.cmbComPort.TabIndex = 0;
            // 
            // grpboxCanCommands
            // 
            this.grpboxCanCommands.Controls.Add(this.btnAutoOff);
            this.grpboxCanCommands.Controls.Add(this.btnAutoOn);
            this.grpboxCanCommands.Controls.Add(this.btnTimeStampOff);
            this.grpboxCanCommands.Controls.Add(this.btnTimeStampOn);
            this.grpboxCanCommands.Controls.Add(this.btnPollAll);
            this.grpboxCanCommands.Controls.Add(this.btnPollOne);
            this.grpboxCanCommands.Controls.Add(this.btnSerNo);
            this.grpboxCanCommands.Controls.Add(this.btnCanVersion);
            this.grpboxCanCommands.Controls.Add(this.btnCanFlags);
            this.grpboxCanCommands.Controls.Add(this.btnCanClose);
            this.grpboxCanCommands.Controls.Add(this.btnCanOpen);
            this.grpboxCanCommands.Controls.Add(this.btnSetup);
            this.grpboxCanCommands.Controls.Add(this.label1);
            this.grpboxCanCommands.Controls.Add(this.cmbCanBitrate);
            this.grpboxCanCommands.Enabled = false;
            this.grpboxCanCommands.Location = new System.Drawing.Point(353, 110);
            this.grpboxCanCommands.Name = "grpboxCanCommands";
            this.grpboxCanCommands.Size = new System.Drawing.Size(173, 301);
            this.grpboxCanCommands.TabIndex = 2;
            this.grpboxCanCommands.TabStop = false;
            this.grpboxCanCommands.Text = "CAN232 Commands";
            // 
            // btnAutoOff
            // 
            this.btnAutoOff.Location = new System.Drawing.Point(92, 267);
            this.btnAutoOff.Name = "btnAutoOff";
            this.btnAutoOff.Size = new System.Drawing.Size(75, 23);
            this.btnAutoOff.TabIndex = 29;
            this.btnAutoOff.Text = "Auto Off";
            this.btnAutoOff.UseVisualStyleBackColor = true;
            this.btnAutoOff.Click += new System.EventHandler(this.btnAutoOff_Click);
            // 
            // btnAutoOn
            // 
            this.btnAutoOn.Location = new System.Drawing.Point(6, 267);
            this.btnAutoOn.Name = "btnAutoOn";
            this.btnAutoOn.Size = new System.Drawing.Size(75, 23);
            this.btnAutoOn.TabIndex = 28;
            this.btnAutoOn.Text = "Auto On";
            this.btnAutoOn.UseVisualStyleBackColor = true;
            this.btnAutoOn.Click += new System.EventHandler(this.btnAutoOn_Click);
            // 
            // btnTimeStampOff
            // 
            this.btnTimeStampOff.Location = new System.Drawing.Point(92, 223);
            this.btnTimeStampOff.Name = "btnTimeStampOff";
            this.btnTimeStampOff.Size = new System.Drawing.Size(75, 23);
            this.btnTimeStampOff.TabIndex = 27;
            this.btnTimeStampOff.Text = "Time Off";
            this.btnTimeStampOff.UseVisualStyleBackColor = true;
            this.btnTimeStampOff.Click += new System.EventHandler(this.btnTimeStampOff_Click);
            // 
            // btnTimeStampOn
            // 
            this.btnTimeStampOn.Location = new System.Drawing.Point(6, 223);
            this.btnTimeStampOn.Name = "btnTimeStampOn";
            this.btnTimeStampOn.Size = new System.Drawing.Size(75, 23);
            this.btnTimeStampOn.TabIndex = 26;
            this.btnTimeStampOn.Text = "Time On";
            this.btnTimeStampOn.UseVisualStyleBackColor = true;
            this.btnTimeStampOn.Click += new System.EventHandler(this.btnTimeStampOn_Click);
            // 
            // btnPollAll
            // 
            this.btnPollAll.Location = new System.Drawing.Point(92, 180);
            this.btnPollAll.Name = "btnPollAll";
            this.btnPollAll.Size = new System.Drawing.Size(75, 23);
            this.btnPollAll.TabIndex = 25;
            this.btnPollAll.Text = "Poll All";
            this.btnPollAll.UseVisualStyleBackColor = true;
            this.btnPollAll.Click += new System.EventHandler(this.btnPollAll_Click);
            // 
            // btnPollOne
            // 
            this.btnPollOne.Location = new System.Drawing.Point(6, 180);
            this.btnPollOne.Name = "btnPollOne";
            this.btnPollOne.Size = new System.Drawing.Size(75, 23);
            this.btnPollOne.TabIndex = 24;
            this.btnPollOne.Text = "Poll One";
            this.btnPollOne.UseVisualStyleBackColor = true;
            this.btnPollOne.Click += new System.EventHandler(this.btnPollOne_Click);
            // 
            // btnSerNo
            // 
            this.btnSerNo.Location = new System.Drawing.Point(6, 136);
            this.btnSerNo.Name = "btnSerNo";
            this.btnSerNo.Size = new System.Drawing.Size(75, 23);
            this.btnSerNo.TabIndex = 23;
            this.btnSerNo.Text = "S/No";
            this.btnSerNo.UseVisualStyleBackColor = true;
            this.btnSerNo.Click += new System.EventHandler(this.btnSerNo_Click);
            // 
            // btnCanVersion
            // 
            this.btnCanVersion.Location = new System.Drawing.Point(6, 107);
            this.btnCanVersion.Name = "btnCanVersion";
            this.btnCanVersion.Size = new System.Drawing.Size(75, 23);
            this.btnCanVersion.TabIndex = 22;
            this.btnCanVersion.Text = "Version";
            this.btnCanVersion.UseVisualStyleBackColor = true;
            this.btnCanVersion.Click += new System.EventHandler(this.btnCanVersion_Click);
            // 
            // btnCanFlags
            // 
            this.btnCanFlags.Location = new System.Drawing.Point(92, 136);
            this.btnCanFlags.Name = "btnCanFlags";
            this.btnCanFlags.Size = new System.Drawing.Size(75, 23);
            this.btnCanFlags.TabIndex = 21;
            this.btnCanFlags.Text = "Flags";
            this.btnCanFlags.UseVisualStyleBackColor = true;
            this.btnCanFlags.Click += new System.EventHandler(this.btnCanFlags_Click);
            // 
            // btnCanClose
            // 
            this.btnCanClose.Location = new System.Drawing.Point(92, 63);
            this.btnCanClose.Name = "btnCanClose";
            this.btnCanClose.Size = new System.Drawing.Size(75, 23);
            this.btnCanClose.TabIndex = 20;
            this.btnCanClose.Text = "Close";
            this.btnCanClose.UseVisualStyleBackColor = true;
            this.btnCanClose.Click += new System.EventHandler(this.btnCanClose_Click);
            // 
            // btnCanOpen
            // 
            this.btnCanOpen.Location = new System.Drawing.Point(6, 63);
            this.btnCanOpen.Name = "btnCanOpen";
            this.btnCanOpen.Size = new System.Drawing.Size(75, 23);
            this.btnCanOpen.TabIndex = 19;
            this.btnCanOpen.Text = "Open";
            this.btnCanOpen.UseVisualStyleBackColor = true;
            this.btnCanOpen.Click += new System.EventHandler(this.btnCanOpen_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(92, 34);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 18;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bitrate";
            // 
            // cmbCanBitrate
            // 
            this.cmbCanBitrate.FormattingEnabled = true;
            this.cmbCanBitrate.Items.AddRange(new object[] {
            "10Kbit",
            "20Kbit",
            "50Kbit",
            "100Kbit",
            "125Kbit",
            "250Kbit",
            "500Kbit",
            "800Kbit",
            "1Mbit"});
            this.cmbCanBitrate.Location = new System.Drawing.Point(6, 36);
            this.cmbCanBitrate.Name = "cmbCanBitrate";
            this.cmbCanBitrate.Size = new System.Drawing.Size(75, 21);
            this.cmbCanBitrate.TabIndex = 16;
            // 
            // grpboxCanFrameTransmit
            // 
            this.grpboxCanFrameTransmit.Controls.Add(this.lblDataBytes);
            this.grpboxCanFrameTransmit.Controls.Add(this.lblDlc);
            this.grpboxCanFrameTransmit.Controls.Add(this.lblCanId);
            this.grpboxCanFrameTransmit.Controls.Add(this.lblResult);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxID);
            this.grpboxCanFrameTransmit.Controls.Add(this.btnSendFrame);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex1);
            this.grpboxCanFrameTransmit.Controls.Add(this.cboxRtr);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex2);
            this.grpboxCanFrameTransmit.Controls.Add(this.cboxExt);
            this.grpboxCanFrameTransmit.Controls.Add(this.numDlc);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex3);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex8);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex4);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex7);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex5);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex6);
            this.grpboxCanFrameTransmit.Enabled = false;
            this.grpboxCanFrameTransmit.Location = new System.Drawing.Point(12, 271);
            this.grpboxCanFrameTransmit.Name = "grpboxCanFrameTransmit";
            this.grpboxCanFrameTransmit.Size = new System.Drawing.Size(335, 141);
            this.grpboxCanFrameTransmit.TabIndex = 14;
            this.grpboxCanFrameTransmit.TabStop = false;
            this.grpboxCanFrameTransmit.Text = "CAN Transmit Frame (HEX)";
            // 
            // lblDataBytes
            // 
            this.lblDataBytes.AutoSize = true;
            this.lblDataBytes.Location = new System.Drawing.Point(106, 25);
            this.lblDataBytes.Name = "lblDataBytes";
            this.lblDataBytes.Size = new System.Drawing.Size(82, 13);
            this.lblDataBytes.TabIndex = 16;
            this.lblDataBytes.Text = "Databytes (1-8):";
            // 
            // lblDlc
            // 
            this.lblDlc.AutoSize = true;
            this.lblDlc.Location = new System.Drawing.Point(69, 25);
            this.lblDlc.Name = "lblDlc";
            this.lblDlc.Size = new System.Drawing.Size(31, 13);
            this.lblDlc.TabIndex = 15;
            this.lblDlc.Text = "DLC:";
            // 
            // lblCanId
            // 
            this.lblCanId.AutoSize = true;
            this.lblCanId.Location = new System.Drawing.Point(6, 25);
            this.lblCanId.Name = "lblCanId";
            this.lblCanId.Size = new System.Drawing.Size(46, 13);
            this.lblCanId.TabIndex = 14;
            this.lblCanId.Text = "CAN ID:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 120);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(250, 13);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "Resulting command: t10080000000000000000[CR]";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(6, 41);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(60, 20);
            this.tbxID.TabIndex = 0;
            this.tbxID.Text = "7DF";
            this.tbxID.TextChanged += new System.EventHandler(this.tbxID_TextChanged);
            this.tbxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxID_KeyPress);
            this.tbxID.Leave += new System.EventHandler(this.tbxID_Leave);
            // 
            // btnSendFrame
            // 
            this.btnSendFrame.Location = new System.Drawing.Point(251, 84);
            this.btnSendFrame.Name = "btnSendFrame";
            this.btnSendFrame.Size = new System.Drawing.Size(75, 23);
            this.btnSendFrame.TabIndex = 12;
            this.btnSendFrame.Text = "Send Frame";
            this.btnSendFrame.UseVisualStyleBackColor = true;
            this.btnSendFrame.Click += new System.EventHandler(this.btnSendFrame_Click);
            // 
            // tbxHex1
            // 
            this.tbxHex1.Location = new System.Drawing.Point(108, 41);
            this.tbxHex1.Name = "tbxHex1";
            this.tbxHex1.Size = new System.Drawing.Size(22, 20);
            this.tbxHex1.TabIndex = 2;
            this.tbxHex1.Text = "01";
            this.tbxHex1.TextChanged += new System.EventHandler(this.tbxHex1_TextChanged);
            this.tbxHex1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex1_KeyPress);
            this.tbxHex1.Leave += new System.EventHandler(this.tbxHex1_Leave);
            // 
            // cboxRtr
            // 
            this.cboxRtr.AutoSize = true;
            this.cboxRtr.Location = new System.Drawing.Point(6, 90);
            this.cboxRtr.Name = "cboxRtr";
            this.cboxRtr.Size = new System.Drawing.Size(81, 17);
            this.cboxRtr.TabIndex = 11;
            this.cboxRtr.Text = "RTR Frame";
            this.cboxRtr.UseVisualStyleBackColor = true;
            this.cboxRtr.CheckedChanged += new System.EventHandler(this.cboxRtr_CheckedChanged);
            // 
            // tbxHex2
            // 
            this.tbxHex2.Location = new System.Drawing.Point(136, 41);
            this.tbxHex2.Name = "tbxHex2";
            this.tbxHex2.Size = new System.Drawing.Size(22, 20);
            this.tbxHex2.TabIndex = 3;
            this.tbxHex2.Text = "00";
            this.tbxHex2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex2_KeyPress);
            this.tbxHex2.Leave += new System.EventHandler(this.tbxHex2_Leave);
            // 
            // cboxExt
            // 
            this.cboxExt.AutoSize = true;
            this.cboxExt.Location = new System.Drawing.Point(6, 67);
            this.cboxExt.Name = "cboxExt";
            this.cboxExt.Size = new System.Drawing.Size(120, 17);
            this.cboxExt.TabIndex = 10;
            this.cboxExt.Text = "Extended ID (29 bit)";
            this.cboxExt.UseVisualStyleBackColor = true;
            this.cboxExt.CheckedChanged += new System.EventHandler(this.cboxExt_CheckedChanged);
            // 
            // numDlc
            // 
            this.numDlc.Location = new System.Drawing.Point(72, 42);
            this.numDlc.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numDlc.Name = "numDlc";
            this.numDlc.ReadOnly = true;
            this.numDlc.Size = new System.Drawing.Size(30, 20);
            this.numDlc.TabIndex = 1;
            this.numDlc.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDlc.ValueChanged += new System.EventHandler(this.numDlc_ValueChanged);
            // 
            // tbxHex3
            // 
            this.tbxHex3.Location = new System.Drawing.Point(164, 41);
            this.tbxHex3.Name = "tbxHex3";
            this.tbxHex3.Size = new System.Drawing.Size(22, 20);
            this.tbxHex3.TabIndex = 4;
            this.tbxHex3.Text = "00";
            this.tbxHex3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex3_KeyPress);
            this.tbxHex3.Leave += new System.EventHandler(this.tbxHex3_Leave);
            // 
            // tbxHex8
            // 
            this.tbxHex8.Location = new System.Drawing.Point(304, 41);
            this.tbxHex8.Name = "tbxHex8";
            this.tbxHex8.Size = new System.Drawing.Size(22, 20);
            this.tbxHex8.TabIndex = 9;
            this.tbxHex8.Text = "00";
            this.tbxHex8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex8_KeyPress);
            this.tbxHex8.Leave += new System.EventHandler(this.tbxHex8_Leave);
            // 
            // tbxHex4
            // 
            this.tbxHex4.Location = new System.Drawing.Point(192, 41);
            this.tbxHex4.Name = "tbxHex4";
            this.tbxHex4.Size = new System.Drawing.Size(22, 20);
            this.tbxHex4.TabIndex = 5;
            this.tbxHex4.Text = "00";
            this.tbxHex4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex4_KeyPress);
            this.tbxHex4.Leave += new System.EventHandler(this.tbxHex4_Leave);
            // 
            // tbxHex7
            // 
            this.tbxHex7.Location = new System.Drawing.Point(276, 41);
            this.tbxHex7.Name = "tbxHex7";
            this.tbxHex7.Size = new System.Drawing.Size(22, 20);
            this.tbxHex7.TabIndex = 8;
            this.tbxHex7.Text = "00";
            this.tbxHex7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex7_KeyPress);
            this.tbxHex7.Leave += new System.EventHandler(this.tbxHex7_Leave);
            // 
            // tbxHex5
            // 
            this.tbxHex5.Location = new System.Drawing.Point(220, 41);
            this.tbxHex5.Name = "tbxHex5";
            this.tbxHex5.Size = new System.Drawing.Size(22, 20);
            this.tbxHex5.TabIndex = 6;
            this.tbxHex5.Text = "00";
            this.tbxHex5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex5_KeyPress);
            this.tbxHex5.Leave += new System.EventHandler(this.tbxHex5_Leave);
            // 
            // tbxHex6
            // 
            this.tbxHex6.Location = new System.Drawing.Point(248, 41);
            this.tbxHex6.Name = "tbxHex6";
            this.tbxHex6.Size = new System.Drawing.Size(22, 20);
            this.tbxHex6.TabIndex = 7;
            this.tbxHex6.Text = "00";
            this.tbxHex6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex6_KeyPress);
            this.tbxHex6.Leave += new System.EventHandler(this.tbxHex6_Leave);
            // 
            // grpboxCanFrameReceive
            // 
            this.grpboxCanFrameReceive.Controls.Add(this.rtboxReceive);
            this.grpboxCanFrameReceive.Location = new System.Drawing.Point(12, 12);
            this.grpboxCanFrameReceive.Name = "grpboxCanFrameReceive";
            this.grpboxCanFrameReceive.Size = new System.Drawing.Size(335, 253);
            this.grpboxCanFrameReceive.TabIndex = 15;
            this.grpboxCanFrameReceive.TabStop = false;
            this.grpboxCanFrameReceive.Text = "CAN Receive Frames (HEX)";
            // 
            // rtboxReceive
            // 
            this.rtboxReceive.Location = new System.Drawing.Point(6, 19);
            this.rtboxReceive.Name = "rtboxReceive";
            this.rtboxReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtboxReceive.Size = new System.Drawing.Size(320, 239);
            this.rtboxReceive.TabIndex = 1;
            this.rtboxReceive.Text = "";
            this.rtboxReceive.TextChanged += new System.EventHandler(this.rtboxReceive_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelComPort,
            this.toolStripStatusLabelSpeed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 24);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabelComPort
            // 
            this.toolStripStatusLabelComPort.AutoSize = false;
            this.toolStripStatusLabelComPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelComPort.Name = "toolStripStatusLabelComPort";
            this.toolStripStatusLabelComPort.Size = new System.Drawing.Size(100, 19);
            this.toolStripStatusLabelComPort.Text = "Closed";
            this.toolStripStatusLabelComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelSpeed
            // 
            this.toolStripStatusLabelSpeed.AutoSize = false;
            this.toolStripStatusLabelSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelSpeed.Name = "toolStripStatusLabelSpeed";
            this.toolStripStatusLabelSpeed.Size = new System.Drawing.Size(100, 19);
            this.toolStripStatusLabelSpeed.Text = "-";
            this.toolStripStatusLabelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Get Speed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Get Rpm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(545, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(626, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "PrintSend";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 55);
            this.label3.TabIndex = 24;
            this.label3.Text = "122";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(681, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 55);
            this.label4.TabIndex = 26;
            this.label4.Text = "-3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Breke";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Can232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpboxCanFrameReceive);
            this.Controls.Add(this.grpboxCanFrameTransmit);
            this.Controls.Add(this.grpboxCanCommands);
            this.Controls.Add(this.grpboxComPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Can232";
            this.Text = "CAN232 Monitor Lite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Can232_FormClosed);
            this.Load += new System.EventHandler(this.Can232_Load);
            this.grpboxComPort.ResumeLayout(false);
            this.grpboxComPort.PerformLayout();
            this.grpboxCanCommands.ResumeLayout(false);
            this.grpboxCanCommands.PerformLayout();
            this.grpboxCanFrameTransmit.ResumeLayout(false);
            this.grpboxCanFrameTransmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDlc)).EndInit();
            this.grpboxCanFrameReceive.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox grpboxComPort;
        private System.Windows.Forms.Button btnComClose;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.Label lblComSpeed;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cmbComSpeed;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.GroupBox grpboxCanCommands;
        private System.Windows.Forms.Button btnCanClose;
        private System.Windows.Forms.Button btnCanOpen;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCanBitrate;
        private System.Windows.Forms.GroupBox grpboxCanFrameTransmit;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button btnSendFrame;
        private System.Windows.Forms.TextBox tbxHex1;
        private System.Windows.Forms.CheckBox cboxRtr;
        private System.Windows.Forms.TextBox tbxHex2;
        private System.Windows.Forms.CheckBox cboxExt;
        private System.Windows.Forms.NumericUpDown numDlc;
        private System.Windows.Forms.TextBox tbxHex3;
        private System.Windows.Forms.TextBox tbxHex8;
        private System.Windows.Forms.TextBox tbxHex4;
        private System.Windows.Forms.TextBox tbxHex7;
        private System.Windows.Forms.TextBox tbxHex5;
        private System.Windows.Forms.TextBox tbxHex6;
        private System.Windows.Forms.GroupBox grpboxCanFrameReceive;
        private System.Windows.Forms.RichTextBox rtboxReceive;
        private System.Windows.Forms.Button btnCanFlags;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelComPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpeed;
        private System.Windows.Forms.Button btnSerNo;
        private System.Windows.Forms.Button btnCanVersion;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDataBytes;
        private System.Windows.Forms.Label lblDlc;
        private System.Windows.Forms.Label lblCanId;
        private System.Windows.Forms.Button btnTimeStampOff;
        private System.Windows.Forms.Button btnTimeStampOn;
        private System.Windows.Forms.Button btnPollAll;
        private System.Windows.Forms.Button btnPollOne;
        private System.Windows.Forms.Button btnAutoOff;
        private System.Windows.Forms.Button btnAutoOn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

