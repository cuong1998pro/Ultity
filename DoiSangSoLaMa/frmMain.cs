using System;
using System.Windows.Forms;

namespace DoiSangSoLaMa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string[] ArrLama = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        private int[] ArrNumber = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            int decNumber = int.Parse(txtSoCanDoi.Text);
            string res = string.Empty;
            bool flag = true;
            int i = 0;
            while (flag)
            {
                int number = ArrNumber[i];
                string lama = ArrLama[i];
                while (decNumber > number)
                {
                    decNumber -= number;
                    res += lama;
                    if (decNumber <= 1)
                    {
                        flag = false;
                    }
                }
                i++;
            }
            txtKetQua.Text = res;
        }
    }
}