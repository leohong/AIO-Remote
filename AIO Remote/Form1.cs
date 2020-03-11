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
        //BroadcastBlock<string> broadcaster = new BroadcastBlock<string>(null);

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

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write("func osd_key_up\r\n");
            }

            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write("func osd_key_enter\r\n");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write("func osd_key_down\r\n");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write("func osd_key_left\r\n");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write("func osd_key_right\r\n");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write("set icea_boot\r\n");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
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
            try
            {
                _serialPort.Write("func osd_key_menu\r\n");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    try
                    {
                        _serialPort.Write("func osd_key_up\r\n");
                    }

                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                    break;

                case Keys.D:
                    try
                    {
                        _serialPort.Write("func osd_key_right\r\n");
                    }

                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                    break;

                case Keys.S:
                    try
                    {
                        _serialPort.Write("func osd_key_down\r\n");
                    }

                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                    break;

                case Keys.A:
                    try
                    {
                        _serialPort.Write("func osd_key_left\r\n");
                    }

                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                    break;

                case Keys.E:
                    try
                    {
                        _serialPort.Write("func osd_key_enter\r\n");
                    }

                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                    break;

                case Keys.Q:
                    try
                    {
                        _serialPort.Write("func osd_key_menu\r\n");
                    }

                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                    break;

                case Keys.R:
                    try
                    {
                        _serialPort.Write("func osd_key_input\r\n");
                    }

                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                    break;
            }
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

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write("func osd_key_input\r\n");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
