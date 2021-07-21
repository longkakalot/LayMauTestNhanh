using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNhanhCovid.Models
{
    public class ThongTinKetQuaTestNhanh
    {
        //HOVATEN	SODIENTHOAI	NAMSINH	CMND_CCCD	
        //GIOITINH	DIACHI	KETQUA	KYTHUATXETNGHIEM	
        //LYDOXETNGHIEM	LOAIMAU	THOIGIANLAYMAU	THOIGIANKETQUA	MAXETNGHIEM	MACSKCB
        public string HoVaTen { get; set; }
        public string SoDienThoai { get; set; }
        public string NamSinh { get; set; }
        public string CMND_CCCD { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int KetQua { get; set; }
        public int KyThuatXetNghiem { get; set; }
        public int LyDoXetNghiem { get; set; }
        public int LoaiMau { get; set; }
        public DateTime ThoiGianLayMau { get; set; }
        public DateTime ThoiGianKetQua { get; set; }
        public string MaXetNghiem { get; set; }
        public string MaCSKCB { get; set; }
        public int DaIn { get; set; }

    }
}
