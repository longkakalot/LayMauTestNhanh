using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNhanhCovid.Models;

namespace TestNhanhCovid.Repository
{
    public interface ILayMauTestNhanhRepo
    {
        Task<IList<LayMauTestNhanh>> GetAll();
        Task<IList<LayMauTestNhanh>> GetListChuaLayMau(string tuNgay, string denNgay);
        Task<IList<LayMauTestNhanh>> GetListDaLayMau(string tuNgay, string denNgay);


        Task<IList<LayMauTestNhanh>> GetListChuaKetQua(string tuNgay, string denNgay);
        Task<IList<LayMauTestNhanh>> GetListDaKetQua(string tuNgay, string denNgay);



        Task<IList<LayMauTestNhanh>> GetListCoKetQuaChuaNhapLis(string tuNgay, string denNgay);
        Task<IList<LayMauTestNhanh>> GetListCoKetQuaDaNhapLis(string tuNgay, string denNgay);

        Task<int> Insert(int Id, string NguoiLayMau, string CodeXn, string ThoiGianLayMau);

        Task<int> InsertKetQua(int Id, bool KetQua, string NguoiKetQua, string ThoiGianKetQua);


        Task<int> GetCodeXnMax();

    }
}
