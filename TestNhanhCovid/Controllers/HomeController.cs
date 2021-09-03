using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestNhanhCovid.Models;
using TestNhanhCovid.Repository;

namespace TestNhanhCovid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;        
        private readonly IWebHostEnvironment _env;
        private readonly IKetQuaTestNhanhRepo _iKetQuaTestNhanhRepo;
        private readonly ILayMauTestNhanhRepo _iLayMauTestNhanhRepo;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env
            , IKetQuaTestNhanhRepo iKetQuaTestNhanhRepo, ILayMauTestNhanhRepo iLayMauTestNhanhRepo)
        {
            _logger = logger;
            _env = env;
            _iKetQuaTestNhanhRepo = iKetQuaTestNhanhRepo;
            _iLayMauTestNhanhRepo = iLayMauTestNhanhRepo;
        }        

        public async Task<IActionResult> Index()
        {
            //var tuNgay = DateTime.Now.ToString("yyyyMMdd");
            //var denNgay = DateTime.Now.ToString("yyyyMMdd");

            //var resultAwait = await _iLayMauTestNhanhRepo.GetListByDate(tuNgay, denNgay);
            //var result = resultAwait.ToList();
            return View();
        }

        #region Lấy mẫu
        public async Task<IActionResult> GetListChiDinhChuaLayMau(string tenCongTy, string congSo2, string nhanVien, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var codeXN = await GetCodeXnMax();
                int codeXnMax = 0;

                if (codeXN == 0)
                {
                    codeXnMax = 100 + 1;
                }
                else if (codeXN == 1)
                {
                    return Content("0");
                }
                else
                {
                    codeXnMax = codeXN + 1;
                }               


                var resultAwait = await _iLayMauTestNhanhRepo.GetListChuaLayMau(tuNgay1, denNgay1);
                
                if(tenCongTy == "0" && congSo2 == "0" && nhanVien == "0") //ds không có hợp đồng, ko có số 2, ko có nhân viên
                {
                    var result = resultAwait
                    .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")                    
                    || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                    .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if(tenCongTy == "1" && congSo2 == "0" && nhanVien == "0") // có cty, ko có cổng 2, ko nhan vien
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("ck"))
                        .OrderBy(m=>m.TenCongTy)
                        .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0" && nhanVien == "1") // có cty, ko có cổng 2, co nhan vien
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("ck") || m.GhiChu.ToLower().Contains("nv"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if (tenCongTy == "0"  && congSo2 == "1" && nhanVien == "0") // ko có cty, ko nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if (tenCongTy == "0"  && congSo2 == "1" && nhanVien == "1") // ko có cty, có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("nv"))
                        .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if (tenCongTy == "0" && congSo2 == "0" && nhanVien == "1") // ko có cty, có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("nv"))
                        .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if (tenCongTy == "1" && congSo2 == "1" && nhanVien == "0") // có cty, ko có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("ck"))
                        .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }

                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("ck") || m.GhiChu.ToLower().Contains("nv"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    ViewBag.CodeXn = codeXnMax;

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListChiDinhChuaLayMau HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> Insert(int Id, int YeuCauChiTiet_Id, int codeXn, string NguoiLayMau)
        {
            try
            {
                var codeXN = await GetCodeXnMax();
                int codeXnMax = 0;

                if(codeXN == 0 )
                {
                    codeXnMax = 100 + 1;
                }
                else if(codeXN == 1)
                {
                    return Content("0");
                }
                else
                {
                    codeXnMax = codeXN + 1;
                }               
                

                var thoiGian = DateTime.Now.AddMinutes(-15).ToString("yyyy-MM-dd HH:mm:ss.fff");               

                var resultAwait = await _iLayMauTestNhanhRepo.Insert(Id, YeuCauChiTiet_Id, NguoiLayMau, codeXnMax.ToString(), thoiGian);
                var result = resultAwait;

                return Content(result.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Insert HomeController" + ex.Message);
                return Content("0");
            }
        }

        private async Task<int> GetCodeXnMax()
        {
            try
            {
                var codeXN = await _iLayMauTestNhanhRepo.GetCodeXnMax();    
                return codeXN;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetCodeXnMax HomeController" + ex.Message);
                return 1;
            }
        }

        public async Task<IActionResult> GetListChiDinhDaLayMau()
        {
            try
            {
                var tuNgay = DateTime.Now.ToString("yyyyMMdd");
                var denNgay = DateTime.Now.AddDays(1).ToString("yyyyMMdd");                


                var resultAwait = await _iLayMauTestNhanhRepo.GetListDaLayMau(tuNgay, denNgay);
                var result = resultAwait.ToList();                

                return PartialView("_GetListChiDinhDaLayMau", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListChiDinhDaLayMau HomeController" + ex.Message);
                return Content("0");
            }
        }

        #endregion


        #region Kết quả
        public async Task<IActionResult> GetListDaLayMauChuaKq(string tenCongTy, string congSo2, string nhanVien, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");


                var resultAwait = await _iLayMauTestNhanhRepo.GetListChuaKetQua(tuNgay1, denNgay1);
                
                if (tenCongTy == "0" && congSo2 == "0" && nhanVien == "0") //ds không có hợp đồng, ko có số 2, ko có nhân viên
                {
                    var result = resultAwait
                    .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")                    
                    || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                    .ToList();                                        

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0" && nhanVien == "0") // có cty, ko có cổng 2, ko nhan vien
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("ck"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();                   

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0" && nhanVien == "1") // có cty, ko có cổng 2, co nhan vien
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("ck") || m.GhiChu.ToLower().Contains("nv"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();
                   
                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "0" && nhanVien == "0" && congSo2 == "1") // ko có cty, ko nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();
                    
                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "0" && nhanVien == "1" && congSo2 == "1") // ko có cty, có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("nv"))
                        .ToList();
                    
                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "0" && congSo2 == "0" && nhanVien == "1") // ko có cty, có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("nv"))
                        .ToList();                    

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "1" && nhanVien == "0") // có cty, ko có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("ck"))
                        .ToList();                    

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("ck") || m.GhiChu.ToLower().Contains("nv"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();
                    

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }





                //if (tenCongTy == "0") //ds không có hợp đồng
                //{
                //    var result = resultAwait
                //        .Where(m => m.GhiChu is null)
                //        .ToList();                    

                //    return PartialView("_GetListDaLayMauChuaKq", result);
                //}
                //else
                //{
                //    var result = resultAwait
                //        .Where(m => m.TenCongTy is not null && m.GhiChu is not null)
                //        .ToList();                    

                //    return PartialView("_GetListDaLayMauChuaKq", result);
                //}


                //var result = resultAwait.ToList();

                //return PartialView("_GetListDaLayMauChuaKq", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListDaLayMauChuaKq KetQuaController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> GetListDaLayMauCoKq(string tenCongTy, string congSo2, string nhanVien, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");


                var resultAwait = await _iLayMauTestNhanhRepo.GetListDaKetQua(tuNgay1, denNgay1);                

                if (tenCongTy == "0" && congSo2 == "0" && nhanVien == "0") //ds không có hợp đồng, ko có số 2, ko có nhân viên
                {
                    var result = resultAwait
                    .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")                   
                    || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                    .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0" && nhanVien == "0") // có cty, ko có cổng 2, ko nhan vien
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("ck"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0" && nhanVien == "1") // có cty, ko có cổng 2, co nhan vien
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("ck") || m.GhiChu.ToLower().Contains("nv"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "0" && nhanVien == "0" && congSo2 == "1") // ko có cty, ko nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "0" && nhanVien == "1" && congSo2 == "1") // ko có cty, có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("nv"))
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "0" && congSo2 == "0" && nhanVien == "1") // ko có cty, có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("nv"))
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "1" && nhanVien == "0") // có cty, ko có nhan vien, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("ck"))
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower().Contains("ck") || m.GhiChu.ToLower().Contains("nv"))
                        .OrderBy(m => m.TenCongTy)
                        .ToList();


                    return PartialView("_GetListDaLayMauCoKq", result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListDaLayMauCoKq HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> InsertKetQua(int Id, bool KetQua, string NguoiKetQua)
        {
            try
            {
                var thoiGian = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                var resultAwait = await _iLayMauTestNhanhRepo.InsertKetQua(Id, KetQua, NguoiKetQua, thoiGian );
                var result = resultAwait;

                return Content(result.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogInformation("InsertKetQua HomeController" + ex.Message);
                return Content("0");
            }
        }


        #endregion




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
