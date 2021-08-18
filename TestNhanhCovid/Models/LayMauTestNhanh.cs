using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNhanhCovid.Models
{
    public class LayMauTestNhanh
    {
        //Lấy mẫu test nhanh tạm
        //Kết quả test nhanh tạm
        public int Id { get; set; }
        public int YeuCauChiTiet_Id { get; set; }
        public string TenBenhNhan { get; set; }
        public string MaYTe { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
        public string DoiTuong { get; set; }
        public string DichVu { get; set; }
        public DateTime ThoiGian { get; set; }
        public bool KetQua { get; set; }
        public int CodeXn { get; set; }
        public string NguoiLayMau { get; set; }

        public DateTime ThoiGianIn { get; set; }
        public int ThanhToan { get; set; }
        public string TenCongTy { get; set; }
        public string GhiChu { get; set; }

    }
}
