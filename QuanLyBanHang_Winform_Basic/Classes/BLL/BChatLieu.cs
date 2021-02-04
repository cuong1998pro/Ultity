using QuanLyBanHang_Winform_Basic.Classes.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang_Winform_Basic.Classes.BLL
{
    public static class BChatLieu
    {
        public static DataTable LayDanhSach()
        {
            var sql = "ChatLieu_SelectAll";
            return DataAccess.excuteDataTable(sql, CommandType.StoredProcedure);
        }

        public static bool Them(EChatLieu newChatLieu)
        {
            var sql = "ChatLieu_Insert";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@TenChatLieu", newChatLieu.TenChatLieu)
                }
                );
        }

        public static bool Sua(EChatLieu chatLieu)
        {
            var sql = "ChatLieu_Update";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaChatLieu", chatLieu.MaChatLieu),
                    new SqlParameter("@TenChatLieu", chatLieu.TenChatLieu)
                }
                );
        }

        public static bool Xoa(string key)
        {
            var sql = "ChatLieu_Delete";
            return DataAccess.executeNoneQuery(sql, CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@MaChatLieu", key),
                }
                );
        }
    }
}