using System;

namespace QuanLyBanHang_Winform_Basic.Classes.DTO
{
    public class EHDBan
    {
        public string MaHDBan { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string MaKhach { get; set; }
        public DateTime NgayBan { get; set; }
        public float TongTien { get; set; }
    }
}