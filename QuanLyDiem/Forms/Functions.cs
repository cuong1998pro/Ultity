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
    }
}