using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyBanHang_Winform_Basic.Classes
{
    public class DataAccess
    {
        private static SqlConnection con;

        public static void Connect()
        {
            string connectionString = Properties.Settings.Default.QLBHConnectionString;
            con = new SqlConnection(connectionString);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        public static DataTable excuteDataTable(string sql, CommandType type, params SqlParameter[] prs)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.CommandType = type;
                foreach (var item in prs)
                {
                    command.Parameters.Add(item);
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    //"Đã xảy ra lỗi. Kiểm tra dữ liệu nhập vào và thử lại sau."
                    e.ToString()
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }

        public static bool executeNoneQuery(string sql, CommandType type, params SqlParameter[] prs)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.CommandType = type;
                foreach (var item in prs)
                {
                    command.Parameters.Add(item);
                }
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    /*"Đã xảy ra lỗi. Kiểm tra dữ liệu nhập vào và thử lại sau."*/
                    e.ToString()
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static object executeScalar(string sql, CommandType type, params SqlParameter[] prs)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.CommandType = type;
                foreach (var item in prs)
                {
                    command.Parameters.Add(item);
                }
                return command.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    /*"Đã xảy ra lỗi. Kiểm tra dữ liệu nhập vào và thử lại sau."*/
                    e.ToString()
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable ConvertListOjbectToDataTable<T>(List<T> objectClass, string table_name = "Table")
        {
            DataTable dt = new DataTable();
            try
            {
                dt.TableName = table_name;

                foreach (PropertyInfo property in objectClass[0].GetType().GetProperties())
                {
                    dt.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                }

                foreach (var vehicle in objectClass)
                {
                    DataRow newRow = dt.NewRow();
                    foreach (PropertyInfo property in vehicle.GetType().GetProperties())
                    {
                        newRow[property.Name] = vehicle.GetType().GetProperty(property.Name).GetValue(vehicle, null);
                    }
                    dt.Rows.Add(newRow);
                }
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
                    }
                }
                return objT;
            }).ToList();
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}