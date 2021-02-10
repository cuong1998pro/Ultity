using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.Forms
{
    public static class Functions
    {
        public static void Binding(Control control, string propName, object dataSource, string dataMember)
        {
            control.DataBindings.Clear();
            Binding binding = new Binding(propName, dataSource, dataMember, true, DataSourceUpdateMode.Never);
            control.DataBindings.Add(binding);
        }

        public static int DiemSo(double diem)
        {
            int d;
            if (diem >= 8.5)
            {
                d = 4;
            }
            else if (diem >= 7)
            {
                d = 3;
            }
            else if (diem >= 5.5)
            {
                d = 2;
            }
            else if (diem >= 4)
            {
                d = 1;
            }
            else
            {
                d = 0;
            }
            return d;
        }

        public static string DiemChu(double diem)
        {
            string d;
            if (diem >= 8.5)
            {
                d = "A";
            }
            else if (diem >= 7)
            {
                d = "B";
            }
            else if (diem >= 5.5)
            {
                d = "C";
            }
            else if (diem >= 4)
            {
                d = "D";
            }
            else
            {
                d = "F";
            }
            return d;
        }

        public static string XepLoaiToanKhoa(double a)
        {
            string d;
            if (a >= 3.6)
            {
                d = "Xuất sắc";
            }
            else if (a >= 3.2)
            {
                d = "Giỏi";
            }
            else if (a >= 2.5)
            {
                d = "Khá";
            }
            else if (a >= 2)
            {
                d = "TB";
            }
            else
            {
                d = "Yếu";
            }
            return d;
        }
    }
}