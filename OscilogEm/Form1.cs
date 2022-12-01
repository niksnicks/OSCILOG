using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace OscilogEm
{
    public partial class Form1 : Form
    {
        private SerialPort mPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Count() > 0)
            {
                Array.Sort(ports);
                cbPort.Items.AddRange(ports);
                cbPort.SelectedIndex = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1];
            Random rnd = new Random();
            rnd.NextBytes(bytes);
            mPort.Write(bytes, 0, 1);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            mPort = new SerialPort(cbPort.Text, 9600, Parity.None, 8, StopBits.One);
            mPort.Open();
            timer1.Start();
            btStart.Enabled = false;
            btStop.Enabled = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            mPort.Close();
            btStart.Enabled = true;
            btStop.Enabled = false;
        }
    }
}
