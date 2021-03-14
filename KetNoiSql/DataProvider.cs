using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KetNoiSql
{
    public class DataProvider
    {
        public static SqlConnection con;

        public static void OpenConnect()
        {
            try
            {
                string connectString = Properties.Resources.connectionString;
                con = new SqlConnection(connectString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch
            {
                MessageBox.Show("Loi ket noi csdl");
            }
        }

        public static void CloseConnect()
        {
            con.Close();
        }

        public static bool ExecStoreProcedure(string storeName, SqlParameter[] sqlParams = null)
        {
            try
            {
                OpenConnect();
                using (SqlCommand command = new SqlCommand(storeName, con))
                {
                    command.CommandTimeout = 0;
                    command.CommandType = CommandType.StoredProcedure;
                    if (sqlParams != null)
                    {
                        foreach (SqlParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Sao chep toan bo dong cua datatable len table cua sql
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool ExecBulkCopy(DataTable dt, string tableName)
        {
            try
            {
                if (string.IsNullOrEmpty(tableName)) return false;
                OpenConnect();
                using (SqlBulkCopy bulk = new SqlBulkCopy(con))
                {
                    bulk.DestinationTableName = tableName;
                    bulk.WriteToServer(dt);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool ImportExcel(string dataPath, string sql, string tableNameDB)
        {
            try
            {
                DataTable dt = new DataTable();
                using (OleDbConnection olecon = new OleDbConnection())
                {
                    olecon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataPath + ";Extended Properties=Excel 8.0";
                    olecon.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, olecon);
                    da.Fill(dt);
                    con.Close();
                }
                if (ExecBulkCopy(dt, tableNameDB))
                {
                    MessageBox.Show("Import thanh cong");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}