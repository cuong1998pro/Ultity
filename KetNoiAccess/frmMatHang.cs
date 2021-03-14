using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiAccess
{
    public partial class frmMatHang : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public frmMatHang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LayDanhSachMatHang();
        }

        private void Connect()
        {
            string connectionString = Properties.Resources.connectionString;
            con.ConnectionString = connectionString;
            con.Open();
        }

        private void Disconnect()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private DataTable LayDanhSachMatHang()
        {
            DataSet dsHienThi = new DataSet();
            string sql = "select * from dl_mathang";
            Connect();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(dsHienThi);
            Disconnect();
            return dsHienThi.Tables[0];
        }
    }
}