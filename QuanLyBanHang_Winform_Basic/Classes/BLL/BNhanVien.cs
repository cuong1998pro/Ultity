using QuanLyBanHang_Winform_Basic.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_Winform_Basic.Classes.BLL
{
    public class BNhanVien
    {
        public static DataTable LayDanhSach()
        {
            var sql = "NhanVien_SelectAll";
            return DataAccess.excuteDataTable(sql, CommandType.StoredProcedure);
        }

        public static bool Them(ENhanVien newNhanVien)
        {
            var sql = "NhanVien_Insert";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@TenNhanVien", newNhanVien.TenNhanVien),
                    new SqlParameter("@GioiTinh", newNhanVien.GioiTinh),
                    new SqlParameter("@DiaChi", newNhanVien.DiaChi),
                    new SqlParameter("@DienThoai", newNhanVien.DienThoai),
                    new SqlParameter("@NgaySinh", newNhanVien.NgaySinh),
                }
                );
        }

        public static bool Sua(ENhanVien nhanVien)
        {
            var sql = "NhanVien_Update";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaNhanVien", nhanVien.MaNhanVien),
                    new SqlParameter("@TenNhanVien", nhanVien.TenNhanVien),
                    new SqlParameter("@GioiTinh", nhanVien.GioiTinh),
                    new SqlParameter("@DiaChi", nhanVien.DiaChi),
                    new SqlParameter("@DienThoai", nhanVien.DienThoai),
                    new SqlParameter("@NgaySinh", nhanVien.NgaySinh),
                }
                );
        }

        public static bool Xoa(string key)
        {
            var sql = "NhanVien_Delete";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaNhanVien", key),
                }
                );
        }
    }
}