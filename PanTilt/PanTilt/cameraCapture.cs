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
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PanTilt
{
    public partial class Form1 : Form
    {
        private Bitmap Image, Image2;
        private BitmapData ImageData, ImageData2, ImageData3, ImageData4;
        private byte[] buffer, buffer2, buffer3, buffer4;
        private int b, g, r, r_x, g_x, b_x, r_y, g_y, b_y, grayscale, location, location2;
        private sbyte weight_x, weight_y;
        private sbyte[,] weights_x;
        private sbyte[,] weights_y;
        private IntPtr pointer, pointer2, pointer3, pointer4;
        private int location3, location4;

        private Size _pictureOriginal;

        private Capture _capture;
        private bool _captureInProgress;
       
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
            _pictureOriginal = pictureBox1.Size;


            weights_x = new sbyte[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            weights_y = new sbyte[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };


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
            if (serialPort2.IsOpen)
                serialPort2.Close();
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

         private void pictureBox_Click(object sender, EventArgs e)
           {
           
           }
      

        private void Start_btn_Click(object sender, EventArgs e)
        {

            if (_capture == null)
            {
                try
                {
                    _capture = new Capture();

                }
                catch (NullReferenceException expt)
                {
                    MessageBox.Show(expt.Message);

                }
            }
                if (_capture != null)
                {
                    if (_captureInProgress)
                    {
                        Start_btn.Text = "Start";
                        Application.Idle -= ProcessFrame;

                    }
                    else
                    {
                       Start_btn.Text = "Capture";
                        Application.Idle += ProcessFrame;

                    }
                    _captureInProgress = !_captureInProgress;
                }
            

        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> OriginalFrame = _capture.QueryFrame();
            imageBox1.Image = OriginalFrame;

            Image<Gray, Byte> grayFrame = _capture.QueryFrame().Convert<Gray, Byte>();
            imageBox2.Image = grayFrame;
        }

        private void btnSaveNormalImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG(*.JPG|*.jpg";

            if (save.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(imageBox1.Width);
                int height = Convert.ToInt32(imageBox1.Height);

                Bitmap bmp = new Bitmap(width, height);
                imageBox1.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));

                bmp.Save(save.FileName, ImageFormat.Jpeg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG(*.JPG|*.jpg";

            if (save.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(imageBox2.Width);
                int height = Convert.ToInt32(imageBox2.Height);

                Bitmap bmp = new Bitmap(width, height);
                imageBox2.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));

                bmp.Save(save.FileName, ImageFormat.Jpeg);

               
            }
        }


        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Bitmap bit = new Bitmap(ofd.FileName);
                //pictureBox1.Image = bit;
                //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                Image = new Bitmap(ofd.FileName);
                Image2 = new Bitmap(Image.Width, Image.Height);
            }
            pictureBox1.Image = Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

      
       
       

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copyBitmap = new Bitmap((Bitmap)pictureBox1.Image);
            processImage(copyBitmap);
            pictureBox2.Image = copyBitmap;

        }

        public bool processImage(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int gray = (byte)(.299 * red + .587 * green + .114 * blue);
                    red = gray;
                    green = gray;
                    blue = gray;
                    bmp.SetPixel(i, j, Color.FromArgb(red, green, blue));

                }
            }
            return true;
        }

       

        private void btnSobel_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            ImageData2 = Image2.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer = new byte[ImageData.Stride * Image.Height];
            buffer2 = new byte[ImageData.Stride * Image.Height];
            pointer = ImageData.Scan0;
            pointer2 = ImageData2.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Height * 3; x += 3)
                {
                    r_x = g_x = b_x = 0;
                    r_y = g_y = b_y = 0;
                    location = x + y * ImageData.Stride;

                    for (int yy = -(int)Math.Floor(weights_y.GetLength(0) / 2.0d), yyy = 0; yy <= (int)Math.Floor(weights_y.GetLength(0) / 2.0d); yy++, yyy++)
                    {
                        if (y + yy >= 0 && y + yy < Image.Height)
                        {
                            for (int xx = -(int)Math.Floor(weights_x.GetLength(1) / 2.0d) * 3, xxx = 0; xx <= (int)Math.Floor(weights_x.GetLength(1) / 2.0d) * 3; xx += 3, xxx++)
                            {
                                if (x + xx >= 0 && x + xx <= Image.Width * 3 - 3)
                                {
                                    location2 = x + xx + (yy + y) * ImageData.Stride;
                                    weight_x = weights_x[yyy, xxx];
                                    weight_y = weights_y[yyy, xxx];

                                    b_x += buffer[location2] * weight_x;
                                    g_x += buffer[location2 + 1] * weight_x;
                                    r_x += buffer[location2 + 2] * weight_x;
                                    b_y += buffer[location2] * weight_y;
                                    g_y += buffer[location2 + 1] * weight_y;
                                    r_y += buffer[location2 + 2] * weight_y;
                                }
                            }
                            
                        }
                    }
                    b = (int)Math.Sqrt(Math.Pow(b_x, 2) + Math.Pow(b_y, 2));
                    g = (int)Math.Sqrt(Math.Pow(g_x, 2) + Math.Pow(g_y, 2));
                    r = (int)Math.Sqrt(Math.Pow(r_x, 2) + Math.Pow(r_y, 2));

                    if (b > 255) b = 255;
                    if (g > 255) g = 255;
                    if (r > 255) r = 255;

                    grayscale=(b + g + r) / 3;

                    buffer2[location] = (byte)grayscale;
                    buffer2[location + 1] = (byte)grayscale;
                    buffer2[location + 2] = (byte)grayscale;
                }

            }
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            Image.UnlockBits(ImageData);
            Image2.UnlockBits(ImageData2);
            pictureBox2.Image = Image2;

        }

        private void btnHorizontalFlip_Click(object sender, EventArgs e)
        {
            ImageData3 = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            ImageData4 = Image2.LockBits(new Rectangle(0, 0, Image2.Width, Image2.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer3 = new byte[ImageData3.Stride * Image.Height];
            buffer4 = new byte[ImageData4.Stride * Image2.Height];
            pointer3 = ImageData3.Scan0;
            pointer4 = ImageData4.Scan0;
            Marshal.Copy(pointer3, buffer3, 0, buffer3.Length);
            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0, xx = Image.Width * 3 - 3; x < Image.Width * 3; x += 3, xx -= 3)
                {
                    location3 = x + y * ImageData3.Stride;
                    location4 = xx + y * ImageData4.Stride;
                    buffer4[location4] = buffer3[location3];
                    buffer4[location4 + 1] = buffer3[location3 + 1];
                    buffer4[location4 + 2] = buffer3[location3 + 2];
                }
            }

            Marshal.Copy(buffer4, 0, pointer4, buffer3.Length);
            Image.UnlockBits(ImageData3);
            Image2.UnlockBits(ImageData4);
            pictureBox2.Image = Image2;
            
        }

        private void btnVerticalFlip_Click(object sender, EventArgs e)
        {
            ImageData3 = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            ImageData4 = Image2.LockBits(new Rectangle(0, 0, Image2.Width, Image2.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer3 = new byte[ImageData3.Stride * Image.Height];
            buffer4 = new byte[ImageData4.Stride * Image2.Height];
            pointer3 = ImageData3.Scan0;
            pointer4 = ImageData4.Scan0;
            Marshal.Copy(pointer3, buffer3, 0, buffer3.Length);
            for (int y = 0, yy=Image.Height-1;y < Image.Height; y++,yy--)
            {
                for (int x = 0;x < Image.Width * 3; x += 3)
                {
                    location3 = x + y * ImageData3.Stride;
                    location4 = x + yy * ImageData4.Stride;
                    buffer4[location4] = buffer3[location3];
                    buffer4[location4 + 1] = buffer3[location3 + 1];
                    buffer4[location4 + 2] = buffer3[location3 + 2];
                }
            }

            Marshal.Copy(buffer4, 0, pointer4, buffer3.Length);
            Image.UnlockBits(ImageData3);
            Image2.UnlockBits(ImageData4);
            pictureBox2.Image = Image2;
        }


    }
}   