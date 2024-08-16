namespace PanTilt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboPortName2 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.gbLive = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveNormalImage = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.gbZoom = new System.Windows.Forms.GroupBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnHorizontalFlip = new System.Windows.Forms.Button();
            this.btnVerticalFlip = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbConnect.SuspendLayout();
            this.gbLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.gbZoom.SuspendLayout();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.btnDisconnect);
            this.gbConnect.Controls.Add(this.btnConnect);
            this.gbConnect.Controls.Add(this.cboPortName2);
            this.gbConnect.Controls.Add(this.btnClose);
            this.gbConnect.Controls.Add(this.cboPortName);
            this.gbConnect.Controls.Add(this.btnOpen);
            this.gbConnect.Location = new System.Drawing.Point(12, 12);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(341, 93);
            this.gbConnect.TabIndex = 0;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connectivity";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(245, 59);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(149, 61);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboPortName2
            // 
            this.cboPortName2.FormattingEnabled = true;
            this.cboPortName2.Location = new System.Drawing.Point(24, 59);
            this.cboPortName2.Name = "cboPortName2";
            this.cboPortName2.Size = new System.Drawing.Size(82, 21);
            this.cboPortName2.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(245, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(24, 19);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(81, 21);
            this.cboPortName.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(149, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Connect";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gbLive
            // 
            this.gbLive.Controls.Add(this.button1);
            this.gbLive.Controls.Add(this.btnSaveNormalImage);
            this.gbLive.Controls.Add(this.imageBox2);
            this.gbLive.Controls.Add(this.imageBox1);
            this.gbLive.Controls.Add(this.Start_btn);
            this.gbLive.Location = new System.Drawing.Point(1, 111);
            this.gbLive.Name = "gbLive";
            this.gbLive.Size = new System.Drawing.Size(554, 283);
            this.gbLive.TabIndex = 1;
            this.gbLive.TabStop = false;
            this.gbLive.Text = "Camera Visual";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save GrayScale Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveNormalImage
            // 
            this.btnSaveNormalImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNormalImage.Location = new System.Drawing.Point(92, 19);
            this.btnSaveNormalImage.Name = "btnSaveNormalImage";
            this.btnSaveNormalImage.Size = new System.Drawing.Size(143, 23);
            this.btnSaveNormalImage.TabIndex = 4;
            this.btnSaveNormalImage.Text = "Save Normal Image";
            this.btnSaveNormalImage.UseVisualStyleBackColor = true;
            this.btnSaveNormalImage.Click += new System.EventHandler(this.btnSaveNormalImage_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(281, 48);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(262, 229);
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(6, 48);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(269, 229);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Start_btn
            // 
            this.Start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.Location = new System.Drawing.Point(11, 19);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // gbZoom
            // 
            this.gbZoom.Controls.Add(this.btnZoomOut);
            this.gbZoom.Controls.Add(this.btnZoomIn);
            this.gbZoom.Location = new System.Drawing.Point(561, 111);
            this.gbZoom.Name = "gbZoom";
            this.gbZoom.Size = new System.Drawing.Size(90, 256);
            this.gbZoom.TabIndex = 1;
            this.gbZoom.TabStop = false;
            this.gbZoom.Text = "Zoom";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(9, 155);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 10;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(6, 61);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 9;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM23";
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(6, 19);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(211, 17);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(6, 61);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(211, 64);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.btnRight);
            this.gbControl.Controls.Add(this.btnLeft);
            this.gbControl.Controls.Add(this.btnDown);
            this.gbControl.Controls.Add(this.btnUp);
            this.gbControl.Location = new System.Drawing.Point(359, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(292, 93);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Operating";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(110, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(7, 427);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Open\r\n";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 218);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnGray
            // 
            this.btnGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.Location = new System.Drawing.Point(7, 465);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(97, 23);
            this.btnGray.TabIndex = 4;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobel.Location = new System.Drawing.Point(7, 504);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(97, 23);
            this.btnSobel.TabIndex = 6;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnHorizontalFlip
            // 
            this.btnHorizontalFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorizontalFlip.Location = new System.Drawing.Point(7, 544);
            this.btnHorizontalFlip.Name = "btnHorizontalFlip";
            this.btnHorizontalFlip.Size = new System.Drawing.Size(97, 23);
            this.btnHorizontalFlip.TabIndex = 7;
            this.btnHorizontalFlip.Text = "Horizontal Flip";
            this.btnHorizontalFlip.UseVisualStyleBackColor = true;
            this.btnHorizontalFlip.Click += new System.EventHandler(this.btnHorizontalFlip_Click);
            // 
            // btnVerticalFlip
            // 
            this.btnVerticalFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerticalFlip.Location = new System.Drawing.Point(7, 583);
            this.btnVerticalFlip.Name = "btnVerticalFlip";
            this.btnVerticalFlip.Size = new System.Drawing.Size(97, 23);
            this.btnVerticalFlip.TabIndex = 8;
            this.btnVerticalFlip.Text = "Vertical Flip";
            this.btnVerticalFlip.UseVisualStyleBackColor = true;
            this.btnVerticalFlip.Click += new System.EventHandler(this.btnVerticalFlip_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(431, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 218);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 677);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVerticalFlip);
            this.Controls.Add(this.btnHorizontalFlip);
            this.Controls.Add(this.btnSobel);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.gbZoom);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbLive);
            this.Controls.Add(this.gbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConnect.ResumeLayout(false);
            this.gbLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.gbZoom.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox gbLive;
        private System.Windows.Forms.GroupBox gbZoom;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Button btnClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboPortName2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button btnSaveNormalImage;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnHorizontalFlip;
        private System.Windows.Forms.Button btnVerticalFlip;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

