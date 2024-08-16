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
            this.pictureBox = new System.Windows.Forms.PictureBox();
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
            this.gbConnect.SuspendLayout();
            this.gbLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbZoom.SuspendLayout();
            this.gbControl.SuspendLayout();
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
            this.gbConnect.Location = new System.Drawing.Point(1, 12);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(284, 93);
            this.gbConnect.TabIndex = 0;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connectivity";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(203, 61);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(111, 61);
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
            this.cboPortName2.Location = new System.Drawing.Point(6, 59);
            this.cboPortName2.Name = "cboPortName2";
            this.cboPortName2.Size = new System.Drawing.Size(82, 21);
            this.cboPortName2.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(6, 32);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(81, 21);
            this.cboPortName.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(111, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Connect";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gbLive
            // 
            this.gbLive.Controls.Add(this.pictureBox);
            this.gbLive.Location = new System.Drawing.Point(1, 111);
            this.gbLive.Name = "gbLive";
            this.gbLive.Size = new System.Drawing.Size(301, 246);
            this.gbLive.TabIndex = 1;
            this.gbLive.TabStop = false;
            this.gbLive.Text = "Camera Visual";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(289, 193);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // gbZoom
            // 
            this.gbZoom.Controls.Add(this.btnZoomOut);
            this.gbZoom.Controls.Add(this.btnZoomIn);
            this.gbZoom.Location = new System.Drawing.Point(308, 178);
            this.gbZoom.Name = "gbZoom";
            this.gbZoom.Size = new System.Drawing.Size(278, 66);
            this.gbZoom.TabIndex = 1;
            this.gbZoom.TabStop = false;
            this.gbZoom.Text = "Zoom";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(197, 28);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 10;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(6, 28);
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
            this.btnUp.Location = new System.Drawing.Point(97, 19);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(97, 120);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(6, 70);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(197, 70);
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
            this.gbControl.Location = new System.Drawing.Point(308, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(278, 160);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Operating";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(97, 70);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 379);
            this.Controls.Add(this.gbZoom);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbLive);
            this.Controls.Add(this.gbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConnect.ResumeLayout(false);
            this.gbLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbZoom.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cboPortName2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
    }
}

