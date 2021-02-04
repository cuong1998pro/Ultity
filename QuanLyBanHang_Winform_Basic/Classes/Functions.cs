using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic.Classes
{
    public static class Functions
    {
        public static void ResetValue(Control control, params string[] excepts)
        {
            if (excepts.Contains(control.Name))
            {
                return;
            }
            if (control is TextBox || control is NumericUpDown || control is DateTimePicker ||
                control is MaskedTextBox)
            {
                control.ResetText();
            }
            else if (control is CheckBox)
            {
                (control as CheckBox).Checked = false;
            }
            else if (control is RadioButton)
            {
                (control as RadioButton).Checked = false;
            }
            else if (control is PictureBox)
            {
                (control as PictureBox).Image = null;
            }

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ResetValue(child);
                }
            }
        }

        public static bool KiemTraDuLieuDauVao(Control container, params string[] excepts)
        {
            foreach (Control child in container.Controls)
            {
                if (excepts.Contains(child.Name))
                {
                    continue;
                }
                switch (child.GetType().Name.ToString())
                {
                    case "TextBox":
                    case "MaskedTextBox":
                    case "ComboBox":
                        if (child.Text == string.Empty)
                        {
                            MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            child.Focus();
                            return false;
                        }
                        break;

                    case "NumericUpDown":
                        var item = child as NumericUpDown;
                        if (item.Value == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            child.Focus();
                            return false;
                        }
                        break;
                }
            }
            return true;
        }

        public static void LoadCombobox(DataTable data, ComboBox cbo, string displayMember, string valueMember)
        {
            cbo.DataSource = data;
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
            cbo.SelectedIndex = -1;
        }
    }
}