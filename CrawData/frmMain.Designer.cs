
namespace CrawData
{
    partial class frmMain
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnGetDataCookie = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtCookie = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtChonFile = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.RichTextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblDownloadLink = new System.Windows.Forms.Label();
            this.txtDownloadLink = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetDataThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(93, 357);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(118, 23);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Get data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnGetDataCookie
            // 
            this.btnGetDataCookie.Location = new System.Drawing.Point(217, 357);
            this.btnGetDataCookie.Name = "btnGetDataCookie";
            this.btnGetDataCookie.Size = new System.Drawing.Size(143, 23);
            this.btnGetDataCookie.TabIndex = 1;
            this.btnGetDataCookie.Text = "Get data  with cookie";
            this.btnGetDataCookie.UseVisualStyleBackColor = true;
            this.btnGetDataCookie.Click += new System.EventHandler(this.btnGetDataCookie_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(560, 87);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Dang ky";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(87, 35);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(273, 20);
            this.txtURL.TabIndex = 4;
            // 
            // txtCookie
            // 
            this.txtCookie.Location = new System.Drawing.Point(87, 84);
            this.txtCookie.Name = "txtCookie";
            this.txtCookie.Size = new System.Drawing.Size(273, 259);
            this.txtCookie.TabIndex = 5;
            this.txtCookie.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cookie:";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(497, 35);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(193, 20);
            this.txtTendangnhap.TabIndex = 8;
            this.txtTendangnhap.Text = "cengdapchai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ten dang nhap:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(497, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "123456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mat khau:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(411, 87);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(143, 23);
            this.btnDangNhap.TabIndex = 11;
            this.btnDangNhap.Text = "Dang nhap";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(411, 238);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(279, 23);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload file";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtChonFile
            // 
            this.txtChonFile.Enabled = false;
            this.txtChonFile.Location = new System.Drawing.Point(411, 151);
            this.txtChonFile.Name = "txtChonFile";
            this.txtChonFile.Size = new System.Drawing.Size(230, 20);
            this.txtChonFile.TabIndex = 13;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(647, 150);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(43, 23);
            this.btnChooseFile.TabIndex = 14;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(412, 180);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(278, 52);
            this.txtKetQua.TabIndex = 15;
            this.txtKetQua.Text = "";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(412, 116);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(278, 23);
            this.btnVerify.TabIndex = 23;
            this.btnVerify.Text = "Verify email";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblDownloadLink
            // 
            this.lblDownloadLink.AutoSize = true;
            this.lblDownloadLink.Location = new System.Drawing.Point(411, 270);
            this.lblDownloadLink.Name = "lblDownloadLink";
            this.lblDownloadLink.Size = new System.Drawing.Size(30, 13);
            this.lblDownloadLink.TabIndex = 28;
            this.lblDownloadLink.Text = "Link:";
            // 
            // txtDownloadLink
            // 
            this.txtDownloadLink.Location = new System.Drawing.Point(476, 267);
            this.txtDownloadLink.Name = "txtDownloadLink";
            this.txtDownloadLink.Size = new System.Drawing.Size(214, 76);
            this.txtDownloadLink.TabIndex = 29;
            this.txtDownloadLink.Text = "https://thienmochuong.com/wp-content/uploads/2020/03/may-man.jpg";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(814, 58);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(193, 20);
            this.txtPort.TabIndex = 34;
            this.txtPort.Text = "8080";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Port:";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(814, 32);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(193, 20);
            this.txtHostname.TabIndex = 32;
            this.txtHostname.Text = "91.133.0.229";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hostname:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Ket noi proxy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGetDataThread
            // 
            this.btnGetDataThread.Location = new System.Drawing.Point(93, 386);
            this.btnGetDataThread.Name = "btnGetDataThread";
            this.btnGetDataThread.Size = new System.Drawing.Size(267, 23);
            this.btnGetDataThread.TabIndex = 36;
            this.btnGetDataThread.Text = "Get data multi thread";
            this.btnGetDataThread.UseVisualStyleBackColor = true;
            this.btnGetDataThread.Click += new System.EventHandler(this.btnGetDataThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 433);
            this.Controls.Add(this.btnGetDataThread);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDownloadLink);
            this.Controls.Add(this.lblDownloadLink);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtChonFile);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCookie);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnGetDataCookie);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form1";
            this.Text = "Ket noi proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnGetDataCookie;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.RichTextBox txtCookie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtChonFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.RichTextBox txtKetQua;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblDownloadLink;
        private System.Windows.Forms.RichTextBox txtDownloadLink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGetDataThread;
    }
}

