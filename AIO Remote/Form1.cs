using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace AIO_Remote
{
    public partial class Form1 : Form
    {
        private Thread readThread = null;
        public SerialPort _serialPort;
        public bool _isOpen = false;
        Dictionary<string, string> myDic = new Dictionary<string, string>();
        delegate void Display(Byte[] buffer);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            toolTip.SetToolTip(this.buttonUp, "W");
            toolTip.SetToolTip(this.buttonDown, "S");
            toolTip.SetToolTip(this.buttonLeft, "A");
            toolTip.SetToolTip(this.buttonRight, "D");
            toolTip.SetToolTip(this.buttonEnter, "E");
            toolTip.SetToolTip(this.buttonMenu, "Q");
            toolTip.SetToolTip(this.buttonInput, "R");
            toolTip.SetToolTip(this.buttonPower, "P");

            myDic.Add("W", "func osd_key_up\r\n");
            myDic.Add("S", "func osd_key_down\r\n");
            myDic.Add("A", "func osd_key_left\r\n");
            myDic.Add("D", "func osd_key_right\r\n");
            myDic.Add("Q", "func osd_key_menu\r\n");
            myDic.Add("E", "func osd_key_enter\r\n");
            myDic.Add("R", "func osd_key_input\r\n");
            myDic.Add("P", "set icea_boot\r\n");

            readThread = new Thread(new ThreadStart(this.serialRead));
            readThread.Start();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            Form2 formSerial = new Form2();
            formSerial.Owner = this;
            formSerial.Show();
        }

        public void CloseSerialPort()
        {
            try
            {
                _serialPort.Close();
            }

            catch(Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
        }

        private void DisplayText(Byte[] buffer)
        {
            MessageBox.Text += System.Text.Encoding.Default.GetString(buffer);
            MessageBox.SelectionStart = MessageBox.Text.Length;
            MessageBox.ScrollToCaret();
            //MessageBox.Refresh();
        }

        public void serialRead()
        {
            Byte[] buffer = new Byte[1024];
            while (true)
            {
                if (true == _isOpen)
                {
                    if (_serialPort.BytesToRead > 0)
                    {
                        Int32 length = _serialPort.Read(buffer, 0, buffer.Length);
                        Array.Resize(ref buffer, length);
                        Display d = new Display(DisplayText);
                        this.Invoke(d, new Object[] { buffer });
                        Array.Resize(ref buffer, 1024);
                    }
                }
                Thread.Sleep(16);
            }
        }

        private void CommandWrite(string cmdString)
        {
            try
            {
                if (true == (myDic.ContainsKey(cmdString)))
                {
                    _serialPort.Write(myDic[cmdString]);
                }
            }

            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            CommandWrite("W");
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            CommandWrite("E");
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            CommandWrite("S");
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            CommandWrite("A");
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            CommandWrite("D");
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            CommandWrite("P");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(true == _isOpen)
            {
                readThread.Abort();
                CloseSerialPort();
            }
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            CommandWrite("Q");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeysConverter kc = new KeysConverter();
            if(TxBox.Focused == false)
            {
                CommandWrite(kc.ConvertToString(e.KeyCode));
            }
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            CommandWrite("R");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (true == _isOpen) 
                _serialPort.Write(TxBox.Text + '\r');
        }
    }
}
