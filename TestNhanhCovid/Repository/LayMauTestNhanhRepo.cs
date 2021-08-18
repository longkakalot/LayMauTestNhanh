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
    public class LayMauTestNhanhRepo : ILayMauTestNhanhRepo
    {
        private readonly IDapperService _dapper;
        private readonly ILogger<LayMauTestNhanhRepo> _logger;
        public LayMauTestNhanhRepo(IDapperService dapper, ILogger<LayMauTestNhanhRepo> logger, ILoggerFactory logFactory)
        {
            _logger = logger;
            _dapper = dapper;
            _logger = logFactory.CreateLogger<LayMauTestNhanhRepo>();
        }
        public Task<IList<LayMauTestNhanh>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<LayMauTestNhanh>> GetListChuaLayMau(string tuNgay, string denNgay)
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
		,ThoiGian = yc.ThoiGianYeuCau	
        ,Id = yc.CLSYeuCau_Id
        ,ct.YeuCauChiTiet_Id
        ,NguoiLayMau = nv.TenNhanVien
		,ThanhToan = case when hd.HoaDon_Id is not null and hd.HuyHoaDon = 0 and hd.HoanTra = 0 then 0 else 1 end
        ,tn.TenCongTy, yc.GhiChu
	from CLSYeuCau yc
		left join CLSYeuCauChiTiet ct on ct.CLSYeuCau_Id = yc.CLSYeuCau_Id
		left join DM_DichVu dv on dv.DichVu_Id = ct.DichVu_Id
		left join TiepNhan tn on tn.TiepNhan_Id = yc.TiepNhan_Id
        left join KhamBenh kb on kb.TiepNhan_Id = tn.TiepNhan_Id
		left join NhanVien nv on nv.NhanVien_Id = yc.BacSiChiDinh_Id
		left join DM_DoiTuong dt on dt.DoiTuong_Id = tn.DoiTuong_Id
		left join DM_BenhNhan bn on bn.BenhNhan_Id = yc.BenhNhan_Id	
        left join HoaDonChiTiet hdct on hdct.YeuCauChiTiet_Id = ct.YeuCauChiTiet_Id
		left join HoaDon hd on hd.HoaDon_Id = hdct.HoaDon_Id
        left join SoLanIn sl on sl.IDRef = yc.CLSYeuCau_Id
	where yc.ThoiGianYeuCau between '{tuNgay}' and '{denNgay}'
		and ct.DichVu_Id in (803,1375,1410,1413)
        and yc.TrangThai = 'ChuaKetQua'
		and ct.TrangThai = 'ChuaThucHien'
        and yc.CLSYeuCau_Id not in (select IDRef from SoLanIn where IDRef = yc.CLSYeuCau_Id)
		and ct.YeuCauChiTiet_Id not in (select YeuCauChiTiet_Id from SoLanIn where IDRef = yc.CLSYeuCau_Id)
        and ((hdct.HoaDonChiTiet_Id is not null and hd.DaThanhToan = 1 and hd.HuyHoaDon = 0 and hd.HoanTra = 0)
			or (hdct.HoaDonChiTiet_Id is null and ct.KhongThuTien = 1)
            or (yc.BenhAn_Id is null and dt.NhomDoiTuong_Id in (563))
            or (yc.BenhAn_Id is not null))
		--and tn.CodePCR is not null
	) chitiet";


                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListChuaKetQuaByDate LayMauTestNhanhRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<LayMauTestNhanh>> GetListDaLayMau(string tuNgay, string denNgay)
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
		,ThoiGian = sl.ThoiGian	
        ,Id = yc.CLSYeuCau_Id
,ct.YeuCauChiTiet_Id
        ,KetQua = sl.KetQua
        --,CodeXn = sl.CodeXn
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
		and ct.YeuCauChiTiet_Id in (select YeuCauChiTiet_Id from SoLanIn where IDRef = yc.CLSYeuCau_Id)

        and sl.LayMau = 1
	) chitiet";


                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListDaLayMau LayMauTestNhanhRepo" + ex.Message);
                return null;
            }
        }
                
        public async Task<int> Insert(int Id, int YeuCauChiTiet_Id, string NguoiLayMau, string CodeXn, string ThoiGianLayMau)
        {
            try
            {
                //var thoiGian1 = ThoiGian.ToString("yyyy-MM-dd HH:mm:ss.fff");
                
                var sql = $@"INSERT INTO SoLanIn (IDRef, YeuCauChiTiet_Id, NguoiLayMau, LayMau, CodeXn, TgLayMau) values ({Id}, {YeuCauChiTiet_Id}, N'{NguoiLayMau}', 1 , '{CodeXn}', '{ThoiGianLayMau}')";

                var resultAwait = await _dapper.Insert<int>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Insert LayMauTestNhanhRepo" + ex.Message);
                return 0;
            }
        }

        public async Task<int> GetCodeXnMax()
        {
            try
            {
                var thoiGian = DateTime.Now.ToString("yy/MM/dd");

                var sql = @$" select max(codeXn) from solanin where CONVERT(varchar,tglaymau,11) = '{thoiGian}'";


                var resultAwait = await _dapper.Get<int>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetCodeXnMax LayMauTestNhanhRepo" + ex.Message);
                return 0;
            }
        }

        public async Task<IList<LayMauTestNhanh>> GetListChuaKetQua(string tuNgay, string denNgay)
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
		,ThoiGian = sl.Tglaymau	
        ,Id = yc.CLSYeuCau_Id
        ,ct.YeuCauChiTiet_Id
        ,KetQua = sl.KetQua
        --,CodeXn = sl.CodeXn
		,ThanhToan = case when hd.HoaDon_Id is not null and hd.HuyHoaDon = 0 and hd.HoanTra = 0 then 0 else 1 end
        ,tn.TenCongTy, yc.GhiChu
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
		and ct.DichVu_Id in (803,1375,1410,1413)
        and yc.CLSYeuCau_Id in (select IDRef from SoLanIn where IDRef = yc.CLSYeuCau_Id)
		--and ct.YeuCauChiTiet_Id in (select YeuCauChiTiet_Id from SoLanIn where IDRef = yc.CLSYeuCau_Id)

        and sl.TGLayMau is not null
        and sl.TGKetQua is null
	) chitiet";


                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListDaLayMau LayMauTestNhanhRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<LayMauTestNhanh>> GetListDaKetQua(string tuNgay, string denNgay)
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
,ct.YeuCauChiTiet_Id
        ,KetQua = sl.KetQua
        --,CodeXn = sl.CodeXn
		,ThanhToan = case when hd.HoaDon_Id is not null and hd.HuyHoaDon = 0 and hd.HoanTra = 0 then 0 else 1 end
        ,tn.TenCongTy, yc.GhiChu
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
		and ct.DichVu_Id in (803,1375,1410,1413)
        and yc.CLSYeuCau_Id in (select IDRef from SoLanIn where IDRef = yc.CLSYeuCau_Id)
		--and ct.YeuCauChiTiet_Id in (select YeuCauChiTiet_Id from SoLanIn where IDRef = yc.CLSYeuCau_Id)

        and sl.LayMau = 1
        and sl.ketqua is not null
	) chitiet";


                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListDaLayMau LayMauTestNhanhRepo" + ex.Message);
                return null;
            }
        }

        public async Task<int> InsertKetQua(int Id, bool KetQua, string NguoiKetQua, string ThoiGianKetQua)
        {
            try
            {
                //var thoiGian1 = ThoiGian.ToString("yyyy-MM-dd HH:mm:ss.fff");

                var sql = 
                    $@"UPDATE SoLanIn 
	                    SET KetQua = '{KetQua}', NguoiKetQua = N'{NguoiKetQua}', TgKetQua = '{ThoiGianKetQua}'
	                    where YeuCauChiTiet_Id = {Id} ";

                var resultAwait = await _dapper.Update<int>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("InsertKetQua LayMauTestNhanhRepo" + ex.Message);
                return 0;
            }
        }
    }
}
