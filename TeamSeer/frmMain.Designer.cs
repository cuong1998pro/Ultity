
namespace TeamSeer
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
            this.btnMoNotePad = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.RichTextBox();
            this.btnCmd = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.chkMouseLeft = new System.Windows.Forms.CheckBox();
            this.chkMouseRight = new System.Windows.Forms.CheckBox();
            this.chkDoubleClick = new System.Windows.Forms.CheckBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.txtWindowName = new System.Windows.Forms.TextBox();
            this.txtControlClassName = new System.Windows.Forms.TextBox();
            this.btnClickVaoControl = new System.Windows.Forms.Button();
            this.txtTextSend = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSendMultikey = new System.Windows.Forms.Button();
            this.btnSetText = new System.Windows.Forms.Button();
            this.btnSendClickOnControl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClickToaDo = new System.Windows.Forms.Button();
            this.btnSendKeyNgam = new System.Windows.Forms.Button();
            this.btnFindImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoNotePad
            // 
            this.btnMoNotePad.Location = new System.Drawing.Point(58, 80);
            this.btnMoNotePad.Name = "btnMoNotePad";
            this.btnMoNotePad.Size = new System.Drawing.Size(113, 23);
            this.btnMoNotePad.TabIndex = 0;
            this.btnMoNotePad.Text = "Mở nodepad";
            this.btnMoNotePad.UseVisualStyleBackColor = true;
            this.btnMoNotePad.Click += new System.EventHandler(this.btnMoNotePad_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(107, 37);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(186, 37);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.Text = "ping google.com";
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(180, 80);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(113, 23);
            this.btnCmd.TabIndex = 2;
            this.btnCmd.Text = "Chạy lệnh cmd";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(89, 162);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(84, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(211, 162);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(81, 20);
            this.txtY.TabIndex = 5;
            this.txtY.Text = "0";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkMouseLeft
            // 
            this.chkMouseLeft.AutoSize = true;
            this.chkMouseLeft.Location = new System.Drawing.Point(58, 185);
            this.chkMouseLeft.Name = "chkMouseLeft";
            this.chkMouseLeft.Size = new System.Drawing.Size(71, 17);
            this.chkMouseLeft.TabIndex = 6;
            this.chkMouseLeft.Text = "Chuột trái";
            this.chkMouseLeft.UseVisualStyleBackColor = true;
            // 
            // chkMouseRight
            // 
            this.chkMouseRight.AutoSize = true;
            this.chkMouseRight.Location = new System.Drawing.Point(133, 185);
            this.chkMouseRight.Name = "chkMouseRight";
            this.chkMouseRight.Size = new System.Drawing.Size(77, 17);
            this.chkMouseRight.TabIndex = 7;
            this.chkMouseRight.Text = "Chuột phải";
            this.chkMouseRight.UseVisualStyleBackColor = true;
            // 
            // chkDoubleClick
            // 
            this.chkDoubleClick.AutoSize = true;
            this.chkDoubleClick.Location = new System.Drawing.Point(211, 185);
            this.chkDoubleClick.Name = "chkDoubleClick";
            this.chkDoubleClick.Size = new System.Drawing.Size(85, 17);
            this.chkDoubleClick.TabIndex = 8;
            this.chkDoubleClick.Text = "Double click";
            this.chkDoubleClick.UseVisualStyleBackColor = true;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(58, 208);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(114, 23);
            this.btnClick.TabIndex = 9;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtWindowName
            // 
            this.txtWindowName.Location = new System.Drawing.Point(107, 112);
            this.txtWindowName.Name = "txtWindowName";
            this.txtWindowName.Size = new System.Drawing.Size(185, 20);
            this.txtWindowName.TabIndex = 10;
            this.txtWindowName.Text = "Remote Desktop Connection";
            // 
            // txtControlClassName
            // 
            this.txtControlClassName.Location = new System.Drawing.Point(107, 136);
            this.txtControlClassName.Name = "txtControlClassName";
            this.txtControlClassName.Size = new System.Drawing.Size(186, 20);
            this.txtControlClassName.TabIndex = 11;
            this.txtControlClassName.Text = "ToolbarWindow32";
            // 
            // btnClickVaoControl
            // 
            this.btnClickVaoControl.Location = new System.Drawing.Point(180, 208);
            this.btnClickVaoControl.Name = "btnClickVaoControl";
            this.btnClickVaoControl.Size = new System.Drawing.Size(112, 23);
            this.btnClickVaoControl.TabIndex = 12;
            this.btnClickVaoControl.Text = "Click vào control";
            this.btnClickVaoControl.UseVisualStyleBackColor = true;
            this.btnClickVaoControl.Click += new System.EventHandler(this.btnClickVaoControl_Click);
            // 
            // txtTextSend
            // 
            this.txtTextSend.Location = new System.Drawing.Point(95, 267);
            this.txtTextSend.Name = "txtTextSend";
            this.txtTextSend.Size = new System.Drawing.Size(196, 20);
            this.txtTextSend.TabIndex = 13;
            this.txtTextSend.Text = "text sended";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Send key Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSendMultikey
            // 
            this.btnSendMultikey.Location = new System.Drawing.Point(179, 298);
            this.btnSendMultikey.Name = "btnSendMultikey";
            this.btnSendMultikey.Size = new System.Drawing.Size(112, 23);
            this.btnSendMultikey.TabIndex = 15;
            this.btnSendMultikey.Text = "Send multikey";
            this.btnSendMultikey.UseVisualStyleBackColor = true;
            this.btnSendMultikey.Click += new System.EventHandler(this.btnSendMultikey_Click);
            // 
            // btnSetText
            // 
            this.btnSetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetText.Location = new System.Drawing.Point(179, 328);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(109, 23);
            this.btnSetText.TabIndex = 16;
            this.btnSetText.Text = "Set text";
            this.btnSetText.UseVisualStyleBackColor = true;
            this.btnSetText.Click += new System.EventHandler(this.btnSetText_Click);
            // 
            // btnSendClickOnControl
            // 
            this.btnSendClickOnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendClickOnControl.Location = new System.Drawing.Point(58, 237);
            this.btnSendClickOnControl.Name = "btnSendClickOnControl";
            this.btnSendClickOnControl.Size = new System.Drawing.Size(135, 23);
            this.btnSendClickOnControl.TabIndex = 17;
            this.btnSendClickOnControl.Text = "SendClickOnControl";
            this.btnSendClickOnControl.UseVisualStyleBackColor = true;
            this.btnSendClickOnControl.Click += new System.EventHandler(this.btnSendClickOnControl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Control:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Window:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "CMD:";
            // 
            // btnClickToaDo
            // 
            this.btnClickToaDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickToaDo.Location = new System.Drawing.Point(199, 238);
            this.btnClickToaDo.Name = "btnClickToaDo";
            this.btnClickToaDo.Size = new System.Drawing.Size(92, 23);
            this.btnClickToaDo.TabIndex = 25;
            this.btnClickToaDo.Text = "Click toạ độ";
            this.btnClickToaDo.UseVisualStyleBackColor = true;
            this.btnClickToaDo.Click += new System.EventHandler(this.btnClickToaDo_Click);
            // 
            // btnSendKeyNgam
            // 
            this.btnSendKeyNgam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendKeyNgam.Location = new System.Drawing.Point(61, 327);
            this.btnSendKeyNgam.Name = "btnSendKeyNgam";
            this.btnSendKeyNgam.Size = new System.Drawing.Size(109, 23);
            this.btnSendKeyNgam.TabIndex = 26;
            this.btnSendKeyNgam.Text = "Send key ngầm";
            this.btnSendKeyNgam.UseVisualStyleBackColor = true;
            this.btnSendKeyNgam.Click += new System.EventHandler(this.btnSendKeyNgam_Click);
            // 
            // btnFindImage
            // 
            this.btnFindImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindImage.Location = new System.Drawing.Point(61, 357);
            this.btnFindImage.Name = "btnFindImage";
            this.btnFindImage.Size = new System.Drawing.Size(227, 23);
            this.btnFindImage.TabIndex = 27;
            this.btnFindImage.Text = "Tìm toạ độ = ảnh";
            this.btnFindImage.UseVisualStyleBackColor = true;
            this.btnFindImage.Click += new System.EventHandler(this.btnFindImage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 403);
            this.Controls.Add(this.btnFindImage);
            this.Controls.Add(this.btnSendKeyNgam);
            this.Controls.Add(this.btnClickToaDo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendClickOnControl);
            this.Controls.Add(this.txtTextSend);
            this.Controls.Add(this.btnSetText);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnSendMultikey);
            this.Controls.Add(this.btnMoNotePad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnClickVaoControl);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.txtControlClassName);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtWindowName);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.chkMouseLeft);
            this.Controls.Add(this.chkDoubleClick);
            this.Controls.Add(this.chkMouseRight);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeemSeer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoNotePad;
        private System.Windows.Forms.RichTextBox txtCommand;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.CheckBox chkMouseLeft;
        private System.Windows.Forms.CheckBox chkMouseRight;
        private System.Windows.Forms.CheckBox chkDoubleClick;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtWindowName;
        private System.Windows.Forms.TextBox txtControlClassName;
        private System.Windows.Forms.Button btnClickVaoControl;
        private System.Windows.Forms.TextBox txtTextSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSendMultikey;
        private System.Windows.Forms.Button btnSetText;
        private System.Windows.Forms.Button btnSendClickOnControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClickToaDo;
        private System.Windows.Forms.Button btnSendKeyNgam;
        private System.Windows.Forms.Button btnFindImage;
    }
}

