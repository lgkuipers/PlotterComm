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
using System.Windows.Forms;

namespace PlotterComm
{
    public partial class Form1 : Form
    {
        AutoResetEvent mre = new AutoResetEvent(false);
        TimeSpan responseTimeout = TimeSpan.FromSeconds(60);

        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        SerialPort ivSerialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();

            ivCbPorts.Items.AddRange(ports);
            ivCbPorts.Items.Add("test");

            this.myDelegate = new AddDataDelegate(AddDataMethod);

            ivSerialPort.DataReceived += new SerialDataReceivedEventHandler(mySerialPort_DataReceived);
        }
        public void AddDataMethod(String myString)
        {
            textBox1.AppendText(myString);
        }

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            textBox1.Invoke(this.myDelegate, new Object[] { indata });

            if (indata.Contains("OK"))
            {
                mre.Set(); //allow loop to continue
            }
        }
        private void ivBtnCommand_Click(object sender, EventArgs e)
        {
            string cmd = ivTbCommand.Text;
            Thread thr = new Thread(DoWork2);
            thr.Start(cmd);
        }

        private void ivBtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Allow the user to set the appropriate properties.
                ivSerialPort.PortName = (string)ivCbPorts.SelectedItem;
                ivSerialPort.BaudRate = 115200;
                ivSerialPort.Parity = Parity.None;
                ivSerialPort.DataBits = 8;
                ivSerialPort.StopBits = StopBits.One;
                ivSerialPort.Handshake = Handshake.None;

                // Set the read/write timeouts
                ivSerialPort.ReadTimeout = 500;
                ivSerialPort.WriteTimeout = 500;

                ivSerialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ivBtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                ivSerialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ivBtnCAN_Click(object sender, EventArgs e)
        {
            try
            {
                ivSerialPort.Write(((char)0x18).ToString());
                if (!mre.WaitOne(responseTimeout))
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoWork()
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\comm.cnc");
            foreach (var l in lines)
            {
                try
                {
                    mre = new AutoResetEvent(false);
                    ivSerialPort.Write(l + "\r\n");
                    if (!mre.WaitOne(responseTimeout))
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }
        private void DoWork2(object cmd)
        {
            ivSerialPort.Write((string)cmd + "\r\n");
            if (!mre.WaitOne(responseTimeout))
            {
            }
        }

        private void ivBtnCnc_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(DoWork);
            thr.Start();
        }
    }
}
