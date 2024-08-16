using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace PanTilt
{
    public partial class Form1 : Form
    {
        int count = 1;

        byte[] x1 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x7a, 0x22 };
        byte[] x2 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x12, 0x3c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x68, 0x75 };
        byte[] x3 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x12, 0xec, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0xD6, 0xB7 };
        byte[] x4 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x13, 0x4C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0xD6, 0xB7 };
        byte[] x5 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x13, 0x8C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0xD7, 0x35 };
        byte[] x6 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x13, 0xd0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x07, 0xE5 };
        byte[] x7 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x14, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0xee, 0x3c };
        byte[] x8 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x14, 0x38, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x61, 0x8d };
        byte[] x9 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x14, 0x50, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x3e, 0xec };
        byte[] x10 = new byte[] { 0x02, 0x21, 0x45, 0x00, 0x14, 0x59, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x22, 0xf0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();
            cboPortName.Items.AddRange(ports);
            cboPortName.SelectedIndex = 0;
            btnClose.Enabled = false;

            string[] ports2 = SerialPort.GetPortNames();
            cboPortName2.Items.AddRange(ports);
            cboPortName2.SelectedIndex = 0;
            btnDisconnect.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            try
            {
                serialPort1.PortName = cboPortName.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "unable to connect serial port 1 connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            try
            {
                serialPort1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "unable to disconnect serial port 1 connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string ch = "TO05\r\n";
            serialPort2.WriteLine(ch);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string ch = "TO-05\r\n";
            serialPort2.WriteLine(ch);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            string ch = "PO-05\r\n";
            serialPort2.WriteLine(ch);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            string ch = "PO05\r\n";
            serialPort2.WriteLine(ch);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ch = "R\r\n";
            serialPort2.WriteLine(ch);
        }
         
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            try
            {
                serialPort2.PortName = cboPortName2.Text;
                serialPort2.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to connect Serial Port 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            try
            {
                serialPort2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to disconnect Serial Port 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            if (serialPort1.IsOpen)
                serialPort2.Close();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                serialPort2.Write(x1, 0, x1.Length);
            }
            if (count == 2)
            {
                serialPort2.Write(x2, 0, x2.Length);
            }
            if (count == 3)
            {
                serialPort2.Write(x3, 0, x3.Length);
            }
            if (count == 4)
            {
                serialPort2.Write(x4, 0, x4.Length);
            }
            if (count == 5)
            {
                serialPort2.Write(x5, 0, x5.Length);
            }
            if (count == 6)
            {
                serialPort2.Write(x6, 0, x6.Length);
            }
            if (count == 7)
            {
                serialPort2.Write(x7, 0, x7.Length);
            }
            if (count == 8)
            {
                serialPort2.Write(x8, 0, x8.Length);
            }
            if (count == 9)
            {
                serialPort2.Write(x9, 0, x9.Length);

            }
            if (count == 10)
            {
                serialPort2.Write(x10, 0, x10.Length);
            }
            count += 1;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {

            if (count == 10)
            {
                serialPort2.Write(x10, 0, x10.Length);
            }
            if (count == 9)
            {
                serialPort2.Write(x9, 0, x9.Length);
            }
            if (count == 8)
            {
                serialPort2.Write(x8, 0, x8.Length);
            }
            if (count == 7)
            {
                serialPort2.Write(x7, 0, x7.Length);
            }
            if (count == 6)
            {
                serialPort2.Write(x6, 0, x6.Length);

            }
            if (count == 5)
            {
                serialPort2.Write(x5, 0, x5.Length);
            }
            if (count == 4)
            {
                serialPort2.Write(x4, 0, x4.Length);
            }
            if (count == 3)
            {
                serialPort2.Write(x3, 0, x3.Length);
            }
            if (count == 2)
            {
                serialPort2.Write(x2, 0, x2.Length);

            }
            if (count == 1)
            {
                serialPort2.Write(x1, 0, x1.Length);
            }
            count -= 1;
        }
    }
}