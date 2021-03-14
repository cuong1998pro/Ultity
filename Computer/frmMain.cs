using System;
using System.Windows.Forms;

namespace Computer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private double resultValue = 0;
        private string operatorPerform = "";
        private bool IsOperator = false;

        private void btnSo_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtSo.Text == "0" || IsOperator)
            {
                txtSo.Clear();
            }
            IsOperator = false;
            txtSo.Text += button.Text;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (txtSo.Text.Contains("."))
                return;
            txtSo.Text += ".";
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                btnDauBang_Click(null, null);
            }
            operatorPerform = button.Text;
            resultValue = double.Parse(txtSo.Text);
            IsOperator = true;
        }

        /// <summary>
        /// thuc hien phep tinh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDauBang_Click(object sender, EventArgs e)
        {
            switch (operatorPerform)
            {
                case "+":
                    txtSo.Text = resultValue + double.Parse(txtSo.Text) + "";
                    break;

                case "-":
                    txtSo.Text = resultValue - double.Parse(txtSo.Text) + "";
                    break;

                case "*":
                    txtSo.Text = resultValue * double.Parse(txtSo.Text) + "";
                    break;

                case "/":
                    txtSo.Text = resultValue / double.Parse(txtSo.Text) + "";
                    break;

                default:
                    break;
            }
            resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtSo.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSo.Text = "0";
            resultValue = 0;
        }
    }
}