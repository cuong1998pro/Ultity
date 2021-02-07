using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang_Winform_Basic.Classes.DTO;

namespace QuanLyBanHang_Winform_Basic.Classes.BLL
{
    public class BHoaDon
    {
        public static DataTable LayDanhSach()
        {
            var sql = "HDBan_SelectAll";
            return DataAccess.excuteDataTable(sql, CommandType.StoredProcedure);
        }

        public static EHDBan LayHoaDon(string maHD)
        {
            var sql = "HDBan_Get";
            var dt = DataAccess.excuteDataTable(sql, CommandType.StoredProcedure, new SqlParameter("@MaHDBan", maHD));
            EHDBan result = DataAccess.ConvertToObject<EHDBan>(dt);
            return result;
        }

        public static bool ThemHoaDon(EHDBan hd)
        {
            var sql = "HDBan_Insert";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter("@MaHDBan", hd.MaHDBan),
                new SqlParameter("@MaKhach", hd.MaKhach),
                new SqlParameter("@MaNhanVien", hd.MaNhanVien),
                new SqlParameter("@NgayBan", hd.NgayBan),
                new SqlParameter("@TongTien", hd.TongTien)
                );
        }

        public static bool XoaHoaDon(string maHD)
        {
            var sql = "HDBan_Delete";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure, new SqlParameter("maHDBan", maHD));
        }

        public static DataTable LayDanhSachChiTiet(string maHDBan)
        {
            var sql = "ChiTietHDBan_SelectAll";
            return DataAccess.excuteDataTable(sql, CommandType.StoredProcedure, new SqlParameter("@MaHD", maHDBan));
        }

        public static bool ThemChiTietHoaDon(EChiTietHDBan ct)
        {
            var sql = "ChiTietHDBan_Insert";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter("@MaHDBan", ct.MaHDBan),
                new SqlParameter("@MaHang", ct.MaHang),
                new SqlParameter("@SoLuong", ct.SoLuong),
                new SqlParameter("@DonGia", ct.DonGia),
                new SqlParameter("@GiamGia", ct.GiamGia),
                new SqlParameter("@ThanhTien", ct.ThanhTien)
                );
        }

        public static bool SuaChiTietHoaDon(EChiTietHDBan ct)
        {
            var sql = "ChiTietHDBan_Update";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter("@MaHDBan", ct.MaHDBan),
                new SqlParameter("@MaHang", ct.MaHang),
                new SqlParameter("@SoLuong", ct.SoLuong),
                new SqlParameter("@DonGia", ct.DonGia),
                new SqlParameter("@GiamGia", ct.GiamGia),
                new SqlParameter("@ThanhTien", ct.ThanhTien)
                );
        }

        public static bool XoaChiTietHoaDon(string maHD, string maHang)
        {
            var sql = "ChiTietHDBan_Delete";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter("@MaHDBan", maHD),
                new SqlParameter("@MaHang", maHang)
                );
        }
    }
}