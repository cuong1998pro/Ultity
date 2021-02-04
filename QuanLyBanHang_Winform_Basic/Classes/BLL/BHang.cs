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
    public static class BHang
    {
        public static DataTable LayDanhSach()
        {
            var sql = "Hang_SelectAll";
            return DataAccess.excuteDataTable(sql, CommandType.StoredProcedure);
        }

        public static DataTable TimKiem(string maHang, string tenHang, string maChatLieu)
        {
            var sql = "Hang_Search";
            return DataAccess.excuteDataTable(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaHang", maHang),
                    new SqlParameter("@TenHang", tenHang),
                    new SqlParameter("@MaChatLieu", maChatLieu),
                });
        }

        public static bool Them(EHang newHang)
        {
            var sql = "Hang_Insert";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@TenHang", newHang.TenHang),
                    new SqlParameter("@MaChatLieu", newHang.MaChatLieu),
                    new SqlParameter("@SoLuong", newHang.SoLuong),
                    new SqlParameter("@DonGiaNhap", newHang.DonGiaNhap),
                    new SqlParameter("@DonGiaBan", newHang.DonGiaBan),
                    new SqlParameter("@Anh", newHang.Anh),
                    new SqlParameter("@GhiChu", newHang.GhiChu),
                }
                );
        }

        public static bool Sua(EHang hang)
        {
            var sql = "Hang_Update";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                   new SqlParameter("@MaHang", hang.MaHang),
                   new SqlParameter("@TenHang", hang.TenHang),
                    new SqlParameter("@MaChatLieu", hang.MaChatLieu),
                    new SqlParameter("@SoLuong", hang.SoLuong),
                    new SqlParameter("@DonGiaNhap", hang.DonGiaNhap),
                    new SqlParameter("@DonGiaBan", hang.DonGiaBan),
                    new SqlParameter("@Anh", hang.Anh),
                    new SqlParameter("@GhiChu", hang.GhiChu),
                }
                );
        }

        public static bool Xoa(string key)
        {
            var sql = "Hang_Delete";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaHang", key),
                }
                );
        }
    }
}