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
        static SerialPort _serialPort;
        public static readonly bool _isOpen = false;
        Dictionary<string, string> myDic = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

            ToolTip1.SetToolTip(this.buttonUp, "W");
            ToolTip1.SetToolTip(this.buttonDown, "S");
            ToolTip1.SetToolTip(this.buttonLeft, "A");
            ToolTip1.SetToolTip(this.buttonRight, "D");
            ToolTip1.SetToolTip(this.buttonEnter, "E");
            ToolTip1.SetToolTip(this.buttonMenu, "Q");
            ToolTip1.SetToolTip(this.buttonInput, "R");
            ToolTip1.SetToolTip(this.buttonPower, "P");

            myDic.Add("W", "func osd_key_up\r\n");
            myDic.Add("S", "func osd_key_down\r\n");
            myDic.Add("A", "func osd_key_left\r\n");
            myDic.Add("D", "func osd_key_right\r\n");
            myDic.Add("Q", "func osd_key_menu\r\n");
            myDic.Add("E", "func osd_key_enter\r\n");
            myDic.Add("R", "func osd_key_input\r\n");
            myDic.Add("P", "set icea_boot\r\n");

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            Form2 formSerial = new Form2(_serialPort);
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
                MessageBox.Show(EX.Message);
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
                MessageBox.Show(EX.Message);
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
            CommandWrite(kc.ConvertToString(e.KeyCode));
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            CommandWrite("R");
        }

        public static void DataReceive()
        {
            char[] ReceiveData = new char[1024];

            while(true)
            {
                Int32 length = _serialPort.Read(ReceiveData, 0, ReceiveData.Length);
                Console.Write(ReceiveData);
            }
        }
    }
}
