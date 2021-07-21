using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TestNhanhCovid.Models;
using TestNhanhCovid.Services;

namespace TestNhanhCovid.Repository
{
    public class KetQuaTestNhanhRepo : IKetQuaTestNhanhRepo
    {
        private readonly IDapperService _dapper;
        private readonly ILogger<KetQuaTestNhanhRepo> _logger;
        public KetQuaTestNhanhRepo(IDapperService dapper, ILogger<KetQuaTestNhanhRepo> logger, ILoggerFactory logFactory)
        {
            _logger = logger;
            _dapper = dapper;
            _logger = logFactory.CreateLogger<KetQuaTestNhanhRepo>();
        }

        public async Task<IList<LayMauTestNhanh>> GetListCoKqChuaIn(string tuNgay, string denNgay)
        {
            try
            {
                var sql =
                    @$"select  STT = ROW_NUMBER() over (order by chitiet.TenBenhNhan),*
	from (
	select distinct
		bn.TenBenhNhan		
		,bn.MaYTe
		,bn.DiaChi
		,bn.SoDienThoai
		,GioiTinh  =  case when bn.GioiTinh = 'T' then N'M' else N'F' end		
		,NamSinh = bn.NamSinh
		,DoiTuong = dt.TenDoiTuong
		,DichVu = dv.TenDichVu
		,ThoiGian = sl.tgketqua	
        ,Id = yc.CLSYeuCau_Id
        ,KetQua = sl.KetQua
        ,CodeXn = sl.CodeXn
		,ThanhToan = case when hd.HoaDon_Id is not null and hd.HuyHoaDon = 0 and hd.HoanTra = 0 then 0 else 1 end

	from CLSYeuCau yc
		left join CLSYeuCauChiTiet ct on ct.CLSYeuCau_Id = yc.CLSYeuCau_Id
		left join DM_DichVu dv on dv.DichVu_Id = ct.DichVu_Id
		left join TiepNhan tn on tn.TiepNhan_Id = yc.TiepNhan_Id
		left join DM_DoiTuong dt on dt.DoiTuong_Id = tn.DoiTuong_Id
		left join DM_BenhNhan bn on bn.BenhNhan_Id = yc.BenhNhan_Id	
left join HoaDonChiTiet hdct on hdct.YeuCauChiTiet_Id = ct.YeuCauChiTiet_Id
		left join HoaDon hd on hd.HoaDon_Id = hdct.HoaDon_Id
        left join SoLanIn sl on sl.IDRef = yc.CLSYeuCau_Id
	where yc.ThoiGianYeuCau between '{tuNgay}' and '{denNgay}'
		and ct.DichVu_Id in (1410,1413)
        and yc.CLSYeuCau_Id in (select IDRef from SoLanIn where IDRef = yc.CLSYeuCau_Id)
        and sl.LayMau = 1
        and sl.ketqua is not null
        and sl.DaIn is null and sl.tgin is null
	) chitiet";


                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListCoKqChuaIn KetQuaTestNhanhRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<LayMauTestNhanh>> GetListCoKqDaIn(string tuNgay, string denNgay)
        {
            try
            {
                var sql =
                    @$"select  STT = ROW_NUMBER() over (order by chitiet.TenBenhNhan),*
	from (
	select distinct
		bn.TenBenhNhan		
		,bn.MaYTe
		,bn.DiaChi
		,bn.SoDienThoai
		,GioiTinh  =  case when bn.GioiTinh = 'T' then N'M' else N'F' end		
		,NamSinh = bn.NamSinh
		,DoiTuong = dt.TenDoiTuong
		,DichVu = dv.TenDichVu
		,ThoiGian = sl.tgketqua	
        ,Id = yc.CLSYeuCau_Id
        ,KetQua = sl.KetQua
        ,CodeXn = sl.CodeXn
        ,ThoiGianIn = sl.tgin
	from CLSYeuCau yc
		left join CLSYeuCauChiTiet ct on ct.CLSYeuCau_Id = yc.CLSYeuCau_Id
		left join DM_DichVu dv on dv.DichVu_Id = ct.DichVu_Id
		left join TiepNhan tn on tn.TiepNhan_Id = yc.TiepNhan_Id
		left join DM_DoiTuong dt on dt.DoiTuong_Id = tn.DoiTuong_Id
		left join DM_BenhNhan bn on bn.BenhNhan_Id = yc.BenhNhan_Id	
        left join SoLanIn sl on sl.IDRef = yc.CLSYeuCau_Id
	where yc.ThoiGianYeuCau between '{tuNgay}' and '{denNgay}'
		and ct.DichVu_Id in (1410,1413)
        and yc.CLSYeuCau_Id in (select IDRef from SoLanIn where IDRef = yc.CLSYeuCau_Id)
        and sl.LayMau = 1
        and sl.ketqua is not null
        and sl.DaIn is not null and sl.tgin is not null
	) chitiet";


                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListCoKqDaIn KetQuaTestNhanhRepo" + ex.Message);
                return null;
            }
        }

        public async Task<int> UpdateDaIn(int id)
        {
            try
            {
                var thoiGianIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                var sql =
                    $@"UPDATE SoLanIn 
	                    SET DaIn = 1, tgin = '{thoiGianIn}'
	                    where idref = {id} ";

                var resultAwait = await _dapper.Update<int>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateDaIn KetQuaTestNhanhRepo" + ex.Message);
                return 0;
            }
        }
    }
}
