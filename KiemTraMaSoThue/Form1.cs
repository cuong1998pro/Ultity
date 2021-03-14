using System;
using System.Windows.Forms;

namespace KiemTraMaSoThue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTraMaSoThue_Click(object sender, EventArgs e)
        {
            bool result = KiemTraMaSoThue(txtMaSoThue.Text);
            if (result)
            {
                MessageBox.Show("ok");
            }
        }

        /// <summary>
        /// Test: 0303683242
        /// </summary>
        /// <param name="maSoThue"></param>
        /// <returns></returns>
        private bool KiemTraMaSoThue(string maSoThue)
        {
            if (maSoThue.Length < 10)
            {
                MessageBox.Show("Nho hon 10 ky tu");
                return false;
            }
            else
            {
                maSoThue = maSoThue.Substring(0, 10);
            }
            if (!IsNumber(maSoThue))
            {
                MessageBox.Show("Phai la so");
                return false;
            }
            int[] arrayCheck = { 31, 29, 23, 19, 17, 13, 7, 5, 3 };
            int checkNumber = 0;
            try
            {
                for (int i = 0; i < maSoThue.Length - 1; i++)
                {
                    checkNumber += int.Parse(maSoThue[i].ToString()) * arrayCheck[i];
                }
                if (int.Parse(maSoThue[9].ToString()) != 10 - checkNumber % 11)
                {
                    MessageBox.Show("Ma so thue khong hop le");
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Loi");
                return false;
            }
        }

        private bool IsNumber(string textCanConvert)
        {
            try
            {
                double Check;
                return double.TryParse(textCanConvert, out Check);
            }
            catch
            {
                return false;
            }
        }
    }
}