//
//
//  CAN232 Monitor Lite, a simple demo on how to use LAWICEL CAN232 together with C#
//  All commands and featuers are not implemented and it is a quick and dirty approach.
//  There is no check if commands can be sent or not, but result will be shown.
//
//  This demo will also work with CANUSB (not all commands though) when using the
//  FTDI VCP driver. CANUSB do not have the following commands:
//  Poll One        - P[CR]
//  Poll All        - A[CR]
//  Auto Poll Flag  - X0[CR] and X1[CR]
//
//  For more information we refer to the ASCII manual for each product.
//
//  (C) 2013 LAWICEL AB, Sweden, Lars Wictorsson
//
//  Version: 1.0.0, Released 27th of February 2013
//
//  http://www.can232.com
//
//  Disclaimer:
//  This software is provided "as is" and may be used and changed to suit your own
//  needs without royalties as long as it is used with products from LAWICEL only! 
//
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAN232_Monitor
{
    public partial class Can232 : Form
    {
        private static string receiveBuffer = "";
        string mesage = "";
        bool sendSpeedQury = false;
        double lastSpeed = 0;
        double lastSpeedTime = 0;
        double acc = 0.0;
        List<string> inFramList = new List<string>();

        public Can232()
        {
            InitializeComponent();
        }


        private void CheckHexValue(object sender, KeyPressEventArgs e, int maxLen)
        {
            if ((sender as TextBox).TextLength < maxLen)
            {
                if (char.IsDigit(e.KeyChar) || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar == '\b'))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar == '\b')  // Backspace?
                {
                    e.Handled = false;
                }
                else if ((sender as TextBox).SelectionLength > 0)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void UpdateDataBoxes()
        {
            if (numDlc.Value < 8)
            {
                tbxHex8.Visible = false;
            }
            else
            {
                tbxHex8.Visible = true;
            }

            if (numDlc.Value < 7)
            {
                tbxHex7.Visible = false;
            }
            else
            {
                tbxHex7.Visible = true;
            }

            if (numDlc.Value < 6)
            {
                tbxHex6.Visible = false;
            }
            else
            {
                tbxHex6.Visible = true;
            }

            if (numDlc.Value < 5)
            {
                tbxHex5.Visible = false;
            }
            else
            {
                tbxHex5.Visible = true;
            }

            if (numDlc.Value < 4)
            {
                tbxHex4.Visible = false;
            }
            else
            {
                tbxHex4.Visible = true;
            }

            if (numDlc.Value < 3)
            {
                tbxHex3.Visible = false;
            }
            else
            {
                tbxHex3.Visible = true;
            }

            if (numDlc.Value < 2)
            {
                tbxHex2.Visible = false;
            }
            else
            {
                tbxHex2.Visible = true;
            }

            if (numDlc.Value < 1)
            {
                tbxHex1.Visible = false;
            }
            else
            {
                tbxHex1.Visible = true;
            }
        }

        private void Can232_Load(object sender, EventArgs e)
        {
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbComPort.Items.Add(portName);
            }
            cmbComPort.SelectedIndex = 0;
            cmbComSpeed.SelectedIndex = 4;
            cmbCanBitrate.SelectedIndex = 6;

        }

        private void btnComOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    // Open Port
                    serialPort.PortName = cmbComPort.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(cmbComSpeed.SelectedItem.ToString());
                    serialPort.Open();

                    cmbComPort.Enabled = false;
                    cmbComSpeed.Enabled = false;
                    grpboxCanCommands.Enabled = true;
                    grpboxCanFrameTransmit.Enabled = true;
                    btnComOpen.Enabled = false;
                    btnComClose.Enabled = true;

                    // Set status
                    toolStripStatusLabelComPort.Text = serialPort.PortName;
                    toolStripStatusLabelSpeed.Text = serialPort.BaudRate.ToString();

                     
                     new System.Threading.Thread(() => 
                    {
                        System.Threading.Thread.CurrentThread.IsBackground = true;

                        ReadSerial();
                         
                    }).Start();
                }
                else
                {
                    rtboxReceive.Text = "Failed to open COM port";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        void ReadSerial()
        {
            string temp = "";

            while (serialPort.IsOpen)
            {
                receiveBuffer += serialPort.ReadExisting();

                if (receiveBuffer != "")
                {
                    receiveBuffer = temp + receiveBuffer;

                    mesage = receiveBuffer;
                    temp = "";
                    if (receiveBuffer.Contains("\r"))
                    {
                        string[] split = receiveBuffer.Split('\r');
                        char[] chararry = receiveBuffer.ToArray();

                        if(chararry[chararry.Count() -1 ] != '\r')
                        {
                            temp = split[split.Count() - 1];
                        }

                        int limit = split.Count();

                        if (temp != "")
                        {
                            limit--;
                            receiveBuffer = receiveBuffer.Substring(0, receiveBuffer.Length - temp.Length);
                        }
                            

                        for (int i = 0; i < limit; i++)
                        {
                            string mess = split[i];
                            if (mess.Contains("t7E"))
                            {
                                inFramList.Add(mess);
                                //t7E8803410D0055555555
                                string t = mess.Substring(9, 2);
                                if (mess.Substring(9, 2) == "0D")
                                {
                                    double speedDataKmPerH = Convert.ToInt16(mess.Substring(11, 2), 16);
                                    t = mess.Substring(mess.Length - 4, 4);
                                    double speedDataTitmeS = (double)Convert.ToInt16(mess.Substring(mess.Length - 4, 4), 16) / 1000;
                                    string toText = speedDataKmPerH.ToString();

                                    label3.Invoke(new Action(() => label3.Text = toText));

                                    double temp_speedDataTitmeS = speedDataTitmeS;

                                    if(speedDataTitmeS<lastSpeedTime)
                                    {
                                        temp_speedDataTitmeS += 60;
                                    }

                                    acc = (double)(speedDataKmPerH - lastSpeed) / (double)(temp_speedDataTitmeS - lastSpeedTime);
                                    acc = (double)acc;
                                    label4.Invoke(new Action(() => label4.Text = acc.ToString("F3")));

                                    this.Invoke(new EventHandler(DisplayPics));

                                    lastSpeedTime = speedDataTitmeS;
                                    lastSpeed = speedDataKmPerH;
                                }

                                //this.Invoke(new EventHandler(DisplayText));

                            }
                        }

                    }
                    else
                    {

                    }

                    //7E8h
                    //7E9h
                    //7EAh
                    //7EBh
                    //if(receiveBuffer.Contains("t7E"))
                        //this.Invoke(new EventHandler(DisplayText));

                    //string va = "7D";
                    //byte hex = Convert.ToByte(va, 16);

                    string recive = "";
                    //if (receiveBuffer.ToUpper().Contains("7E8") 
                    //    || receiveBuffer.ToUpper().Contains("7E9") 
                    //    || receiveBuffer.ToUpper().Contains("7EA") 
                    //    || receiveBuffer.ToUpper().Contains("7EB")
                    //    || receiveBuffer.ToUpper().Contains("7EC")
                    //    || receiveBuffer.ToUpper().Contains("7ED")
                    //    || receiveBuffer.ToUpper().Contains("7EE")
                    //    || receiveBuffer.ToUpper().Contains("04410C")
                    //    || receiveBuffer.ToUpper().Contains("7EF"))
                    this.Invoke(new EventHandler(DisplayText));





                    //string[] msgs = receiveBuffer.Split('\r');

                    //foreach (string msg in msgs)
                    //{
                    //    mesage = msg;
                    //    if (msg.Contains("7E"))
                    //        this.Invoke(new EventHandler(DisplayText));
                    //}

                    receiveBuffer = "";


                }

            }
            
        }




        private void btnComClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                toolStripStatusLabelComPort.Text = "Closed";
                toolStripStatusLabelSpeed.Text = "-";
                grpboxCanCommands.Enabled = false;
                grpboxCanFrameTransmit.Enabled = false;
                btnComClose.Enabled = false;
                btnComOpen.Enabled = true;
                cmbComPort.Enabled = true;
                cmbComSpeed.Enabled = true;
            }
        }

        private void Can232_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void btnCanOpen_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("O\r");
            }
        }

        private void btnCanClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("C\r");
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("S");
                serialPort.Write(cmbCanBitrate.SelectedIndex.ToString());
                serialPort.Write("\r");
            }
        }

        private void btnCanVersion_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("V\r");
            }
        }

        private void btnCanFlags_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("F\r");
            }
        }

        private void btnSerNo_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("N\r");
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //receiveBuffer = serialPort.ReadExisting();

                ////////7E8h
                ////////7E9h
                ////////7EAh
                ////////7EBh
                //////this.Invoke(new EventHandler(DisplayText));
            }
            catch (System.TimeoutException)
            {
            }
        }

        private void DisplayPics(object s, EventArgs e)
        {
            double temp = 0;

            temp = Convert.ToDouble(textBox1.Text);
            if( acc<temp)
                pictureBox1.Visible = true;
            else
                pictureBox1.Visible = false;

            temp = Convert.ToDouble(textBox2.Text);
            if (acc < temp)
                pictureBox2.Visible = true;
            else
                pictureBox2.Visible = false;

            temp = Convert.ToDouble(textBox3.Text);
            if (acc < temp)
                pictureBox3.Visible = true;
            else
                pictureBox3.Visible = false;

            temp = Convert.ToDouble(textBox4.Text);
            if (acc < temp)
                pictureBox4.Visible = true;
            else
                pictureBox4.Visible = false;

            temp = Convert.ToDouble(textBox5.Text);
            if (acc < temp)
                pictureBox5.Visible = true;
            else
                pictureBox5.Visible = false;

            temp = Convert.ToDouble(textBox6.Text);
            if (acc < temp)
                pictureBox6.Visible = true;
            else
                pictureBox6.Visible = false;

            temp = Convert.ToDouble(textBox7.Text);
            if (acc < temp)
                pictureBox7.Visible = true;
            else
                pictureBox7.Visible = false;

            temp = Convert.ToDouble(textBox8.Text);
            if (acc < temp)
                pictureBox8.Visible = true;
            else
                pictureBox8.Visible = false;


            




        }

        private void DisplayText(object s, EventArgs e )
        {
            int buffLen = mesage.Length;
            int buffPos = -1;
            int c = ' ';
            if (buffLen > 1)
            {
                // More than one character

                if (receiveBuffer.ToUpper().Contains("7E8")
                       || receiveBuffer.ToUpper().Contains("7E9")
                       || receiveBuffer.ToUpper().Contains("7EA")
                       || receiveBuffer.ToUpper().Contains("7EB")
                       || receiveBuffer.ToUpper().Contains("7EC")
                       || receiveBuffer.ToUpper().Contains("7ED")
                       || receiveBuffer.ToUpper().Contains("7EE")
                       || receiveBuffer.ToUpper().Contains("7EF"))
                {
                    if ((buffPos = mesage.IndexOf("\r")) >= 0)
                    {
                        rtboxReceive.AppendText(mesage.Substring(0, buffPos));
                        rtboxReceive.AppendText("[CR]");
                        rtboxReceive.AppendText(mesage.Substring(buffPos, (buffLen - buffPos)));
                    }
                    else
                    {
                        rtboxReceive.AppendText(mesage);
                    }
                }
            }
            else
            {
                // Only one character
                c = mesage[0];
                if (c == 13)
                {
                    rtboxReceive.AppendText("[CR]");
                    rtboxReceive.AppendText(mesage);
                }
                else if (c == 7)
                {
                    rtboxReceive.AppendText("[BELL]\n");
                }
            }
        }

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxExt.Checked == true)
            {
                CheckHexValue(sender, e, 8);
            }
            else
            {
                CheckHexValue(sender, e, 3);
            }
        }

        private void tbxHex1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex4_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex5_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex6_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex7_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex8_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxID_Leave(object sender, EventArgs e)
        {
            if (cboxExt.Checked == true)
            {
                if (tbxID.TextLength == 0)
                {
                    tbxID.Text = "00000000";
                }
                else if (tbxID.TextLength == 1)
                {
                    tbxID.Text = "0000000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 2)
                {
                    tbxID.Text = "000000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 3)
                {
                    tbxID.Text = "00000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 4)
                {
                    tbxID.Text = "0000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 5)
                {
                    tbxID.Text = "000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 6)
                {
                    tbxID.Text = "00" + tbxID.Text;
                }
                else if (tbxID.TextLength == 7)
                {
                    tbxID.Text = "0" + tbxID.Text;
                }
            }
            else
            {
                if (tbxID.TextLength == 0)
                {
                    tbxID.Text = "000";
                }
                else if (tbxID.TextLength == 1)
                {
                    tbxID.Text = "00" + tbxID.Text;
                }
                else if (tbxID.TextLength == 2)
                {
                    tbxID.Text = "0" + tbxID.Text;
                }
            }
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex1_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex2_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex3_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex4_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex5_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex6_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex7_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex8_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void numDlc_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataBoxes();
        }

        private void cboxExt_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxExt.Checked == true)
            {
                tbxID.Text = "00000" + tbxID.Text;
            }
            else
            {
                tbxID.Text = tbxID.Text.Substring(tbxID.Text.Length - 3);
            }
        }

        private void cboxRtr_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxRtr.Checked == true)
            {
                tbxHex1.Visible = false;
                tbxHex2.Visible = false;
                tbxHex3.Visible = false;
                tbxHex4.Visible = false;
                tbxHex5.Visible = false;
                tbxHex6.Visible = false;
                tbxHex7.Visible = false;
                tbxHex8.Visible = false;
            }
            else
            {
                UpdateDataBoxes();
            }
        }

        private void btnSendFrame_Click(object sender, EventArgs e)
        {
            string canFrameData = "";

            if (cboxRtr.Checked == true)        // RTR Frame
            {
                if (cboxExt.Checked == true)    // 29bit Frame
                {
                    canFrameData += "R";
                }
                else                            // 11bit frame
                {
                    canFrameData += "r";
                }
                canFrameData += tbxID.Text + numDlc.Value.ToString();
            }
            else                                // Normal Frame
            {
                if (cboxExt.Checked == true)    // 29bit Frame
                {
                    canFrameData += "T";
                }
                else                            // 11bit frame
                {
                    canFrameData += "t";
                }
                canFrameData += tbxID.Text + numDlc.Value.ToString();
                if (numDlc.Value >= 1)
                {
                    canFrameData += tbxHex1.Text;
                }
                if (numDlc.Value >= 2)
                {
                    canFrameData += tbxHex2.Text;
                }
                if (numDlc.Value >= 3)
                {
                    canFrameData += tbxHex3.Text;
                }
                if (numDlc.Value >= 4)
                {
                    canFrameData += tbxHex4.Text;
                }
                if (numDlc.Value >= 5)
                {
                    canFrameData += tbxHex5.Text;
                }
                if (numDlc.Value >= 6)
                {
                    canFrameData += tbxHex6.Text;
                }
                if (numDlc.Value >= 7)
                {
                    canFrameData += tbxHex7.Text;
                }
                if (numDlc.Value >= 8)
                {
                    canFrameData += tbxHex8.Text;
                }
            }
            if (serialPort.IsOpen)
            {
                serialPort.Write(canFrameData);
                serialPort.Write("\r");
            }
            lblResult.Text = "Resulting command: " + canFrameData + "[CR]";

            rtboxReceive.AppendText("Send: " + canFrameData + "\r");
        }

        private void btnTimeStampOn_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("Z1\r");
            }
        }

        private void btnTimeStampOff_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("Z0\r");
            }
        }

        private void btnAutoOn_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("X1\r");
            }
        }

        private void btnAutoOff_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("X0\r");
            }
        }

        private void btnPollOne_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("P\r");
            }
        }

        private void btnPollAll_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("A\r");
            }
        }

        private void rtboxReceive_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxHex1_TextChanged(object sender, EventArgs e)
        {

        }

        string ID = "7DF";
        string DLC = "8";
        string by1 = "55";
        string by2 = "55";
        string by3 = "55";
        string by4 = "55";
        string by5 = "55";
        string by6 = "55";
        string by7 = "55";
        string by8 = "55";

        void SetFrame(object s, EventArgs e)
        {
            tbxID.Text = ID;// "7DF";
            numDlc.Text = DLC;// "8";
            tbxHex1.Text = by1;// "02";
            tbxHex2.Text = by2;//"01";
            tbxHex3.Text = by3;//"0D";
            tbxHex4.Text = by4;//"55";
            tbxHex5.Text = by5;//"55";
            tbxHex6.Text = by6;//"55";
            tbxHex7.Text = by7;//"55";
            tbxHex8.Text = by8;//"55";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {


            //tbxID.Text = "7DF";
            //numDlc.Text = "8";
            //tbxHex1.Text = "02";
            //tbxHex2.Text = "01";
            //tbxHex3.Text = "0D";
            //tbxHex4.Text = "55";
            //tbxHex5.Text = "55";
            //tbxHex6.Text = "55";
            //tbxHex7.Text = "55";
            //tbxHex8.Text = "55";
            button1.Text = "Stop";
            if (sendSpeedQury)
            {
                sendSpeedQury = false;
                button1.Text = "Get Speed";
            }
            else
            {
                sendSpeedQury = true;
                btnSendFrame.Enabled = false;
                new System.Threading.Thread(() =>
                {
                    System.Threading.Thread.CurrentThread.IsBackground = true;

                    while (sendSpeedQury)
                    {
                        ID = "7DF";
                        DLC = "8";
                        by1 = "02";
                        by2 = "01";
                        by3 = "0D";
                        by4 = "55";
                        by5 = "55";
                        by6 = "55";
                        by7 = "55";
                        by8 = "55";
                        this.Invoke(new EventHandler(SetFrame));
                        this.Invoke(new EventHandler(btnSendFrame_Click));
                        //this.btnSendFrame_Click(new object(), new EventArgs());
                        System.Threading.Thread.Sleep(100);
                    }

                    btnSendFrame.Invoke(new Action(() => btnSendFrame.Enabled = true));

                }).Start();

            }
            
            //test

        }

        private void button2_Click(object sender, EventArgs e)
        {
            acc = Convert.ToDouble(textBox9.Text);
            this.Invoke(new EventHandler(DisplayPics));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
