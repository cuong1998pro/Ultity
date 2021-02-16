
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
            this.SuspendLayout();
            // 
            // btnMoNotePad
            // 
            this.btnMoNotePad.Location = new System.Drawing.Point(12, 55);
            this.btnMoNotePad.Name = "btnMoNotePad";
            this.btnMoNotePad.Size = new System.Drawing.Size(113, 23);
            this.btnMoNotePad.TabIndex = 0;
            this.btnMoNotePad.Text = "Mở nodepad";
            this.btnMoNotePad.UseVisualStyleBackColor = true;
            this.btnMoNotePad.Click += new System.EventHandler(this.btnMoNotePad_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 12);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(232, 37);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.Text = "ping google.com";
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(131, 55);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(113, 23);
            this.btnCmd.TabIndex = 2;
            this.btnCmd.Text = "Chạy lệnh cmd";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(13, 92);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(112, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "113";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(132, 92);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(112, 20);
            this.txtY.TabIndex = 5;
            this.txtY.Text = "600";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkMouseLeft
            // 
            this.chkMouseLeft.AutoSize = true;
            this.chkMouseLeft.Location = new System.Drawing.Point(13, 118);
            this.chkMouseLeft.Name = "chkMouseLeft";
            this.chkMouseLeft.Size = new System.Drawing.Size(71, 17);
            this.chkMouseLeft.TabIndex = 6;
            this.chkMouseLeft.Text = "Chuột trái";
            this.chkMouseLeft.UseVisualStyleBackColor = true;
            // 
            // chkMouseRight
            // 
            this.chkMouseRight.AutoSize = true;
            this.chkMouseRight.Location = new System.Drawing.Point(85, 118);
            this.chkMouseRight.Name = "chkMouseRight";
            this.chkMouseRight.Size = new System.Drawing.Size(77, 17);
            this.chkMouseRight.TabIndex = 7;
            this.chkMouseRight.Text = "Chuột phải";
            this.chkMouseRight.UseVisualStyleBackColor = true;
            // 
            // chkDoubleClick
            // 
            this.chkDoubleClick.AutoSize = true;
            this.chkDoubleClick.Location = new System.Drawing.Point(163, 118);
            this.chkDoubleClick.Name = "chkDoubleClick";
            this.chkDoubleClick.Size = new System.Drawing.Size(85, 17);
            this.chkDoubleClick.TabIndex = 8;
            this.chkDoubleClick.Text = "Double click";
            this.chkDoubleClick.UseVisualStyleBackColor = true;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(12, 141);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(113, 23);
            this.btnClick.TabIndex = 9;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 427);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.chkDoubleClick);
            this.Controls.Add(this.chkMouseRight);
            this.Controls.Add(this.chkMouseLeft);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnMoNotePad);
            this.Name = "frmMain";
            this.Text = "TeamSeer";
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
    }
}

