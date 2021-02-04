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
    public static class BKhachHang
    {
        public static DataTable LayDanhSach()
        {
            var sql = "Khach_SelectAll";
            return DataAccess.excuteDataTable(sql, CommandType.StoredProcedure);
        }

        public static bool Them(EKhachHang khachHang)
        {
            var sql = "Khach_Insert";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@TenKhach", khachHang.TenKhach),
                    new SqlParameter("@DiaChi", khachHang.DiaChi),
                    new SqlParameter("@DienThoai", khachHang.DienThoai),
                }
                );
        }

        public static bool Sua(EKhachHang khachHang)
        {
            var sql = "Khach_Update";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaKhach", khachHang.MaKhach),
                    new SqlParameter("@TenKhach", khachHang.TenKhach),
                    new SqlParameter("@DiaChi", khachHang.DiaChi),
                    new SqlParameter("@DienThoai", khachHang.DienThoai),
                }
                );
        }

        public static bool Xoa(string key)
        {
            var sql = "Khach_Delete";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaKhach", key),
                }
                );
        }
    }
}