﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIO_Remote
{
    public partial class Form2 : Form
    {
        SerialPort serialPort;
        Thread RecivedThread;

        public Form2(SerialPort Port)
        {
            InitializeComponent();
            serialPort = Port;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] Ports = SerialPort.GetPortNames();
            string[] Speed = { "115200", "57600", "38400", "19200", "9600" };
            string[] Data = { "8 bits", "7 bits" };
            string[] Parity = { "None", "Odd", "Even", "Mark", "Space" };
            string[] StopBits = { "None", "One", "Two", "OnePointFive" };
            string[] FlowCtrl = { "Xon/Xoff", "hardware", "none" };

            Array.Sort(Ports);

#if SCAN_PORT
            SerialPort detectPort = new SerialPort();
            foreach (string val in Ports)
            {
                detectPort.PortName = val;

                try
                {
                    detectPort.Open();
                    comboBoxPort.Items.Add(val);
                    detectPort.Close();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
#else
            comboBoxPort.Items.AddRange(Ports);
            comboBoxPort.SelectedIndex = comboBoxPort.Items.Count > 0 ? 0 : -1;
#endif // DEBUG
            comboBoxSpeed.Items.AddRange(Speed);
            comboBoxSpeed.SelectedIndex = 0;

            comboBoxData.Items.AddRange(Data);
            comboBoxData.SelectedIndex = 0;

            comboBoxParity.Items.AddRange(Parity);
            comboBoxParity.SelectedIndex = 0;

            comboBoxStopBits.Items.AddRange(StopBits);
            comboBoxStopBits.SelectedIndex = 1;

            comboBoxFlowControl.Items.AddRange(FlowCtrl);
            comboBoxFlowControl.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (false == serialPort.IsOpen)
                {
                    serialPort.PortName = comboBoxPort.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(comboBoxSpeed.SelectedItem.ToString());
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.SelectedIndex.ToString(), true);
                    serialPort.DataBits = comboBoxData.SelectedIndex == 0 ? 8 : 7;
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.SelectedIndex.ToString(), true); ;
                    serialPort.Open();

                    MessageBox.Show("Open OK!");

                    Close();
                }
                else
                {
                    MessageBox.Show("Choose Another Port!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
