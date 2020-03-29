using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlotterComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();

            ivCbPorts.Items.AddRange(ports);
        }

        private void ivBtnCommand_Click(object sender, EventArgs e)
        {
            var _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = ivCbPorts.SelectedText;
            _serialPort.BaudRate = 115200;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();

            _serialPort.Write(ivTbCommand.Text + "\r\n");

            _serialPort.Close();

        }
    }
}
