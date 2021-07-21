using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNhanhCovid.Models;

namespace TestNhanhCovid.Repository
{
    public interface IKetQuaTestNhanhRepo
    {
        Task<IList<LayMauTestNhanh>> GetListCoKqChuaIn(string tuNgay, string denNgay);
        Task<IList<LayMauTestNhanh>> GetListCoKqDaIn(string tuNgay, string denNgay);
        Task<int> UpdateDaIn(int id);

    }
}
