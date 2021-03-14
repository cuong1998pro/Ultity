using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KetNoiSql
{
    public partial class frmKetNoiSql : Form
    {
        private SqlConnection con = new SqlConnection();

        public frmKetNoiSql()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            con.ConnectionString = Properties.Resources.connectionString;
            con.Open();
        }

        private void Disconnect()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private DataTable LoadData()
        {
            Connect();
            string sql = "select * from production.product";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            Disconnect();
            return ds.Tables[0];
        }

        private void frmKetNoiSql_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadData();
        }
    }
}