using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNhanhCovid.Repository;

namespace TestNhanhCovid.Controllers
{
    public class KetQuaController : Controller
    {
        private readonly ILogger<KetQuaController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IKetQuaTestNhanhRepo _iKetQuaTestNhanhRepo;
        private readonly ILayMauTestNhanhRepo _iLayMauTestNhanhRepo;

        public KetQuaController(ILogger<KetQuaController> logger, IWebHostEnvironment env
            , IKetQuaTestNhanhRepo iKetQuaTestNhanhRepo, ILayMauTestNhanhRepo iLayMauTestNhanhRepo)
        {
            _logger = logger;
            _env = env;
            _iKetQuaTestNhanhRepo = iKetQuaTestNhanhRepo;
            _iLayMauTestNhanhRepo = iLayMauTestNhanhRepo;
        }
        public IActionResult Index()
        {
            return View();
        }



        public async Task<IActionResult> GetListCoKqChuaIn()
        {
            try
            {
                var tuNgay = DateTime.Now.ToString("yyyyMMdd");
                var denNgay = DateTime.Now.AddDays(1).ToString("yyyyMMdd");


                var resultAwait = await _iKetQuaTestNhanhRepo.GetListCoKqChuaIn(tuNgay, denNgay);
                var result = resultAwait.ToList();

                return PartialView("_GetListCoKqChuaIn", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListCoKqChuaIn KetQuaController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> GetListCoKqDaIn()
        {
            try
            {
                var tuNgay = DateTime.Now.ToString("yyyyMMdd");
                var denNgay = DateTime.Now.AddDays(1).ToString("yyyyMMdd");


                var resultAwait = await _iKetQuaTestNhanhRepo.GetListCoKqDaIn(tuNgay, denNgay);
                var result = resultAwait.ToList();

                return PartialView("_GetListCoKqDaIn", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListCoKqDaIn KetQuaController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> UpdateDaIn(int Id)
        {
            try
            {
                //var thoiGian = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                var resultAwait = await _iKetQuaTestNhanhRepo.UpdateDaIn(Id);
                var result = resultAwait;

                return Content(result.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogInformation("UpdateDaIn KetQuaController" + ex.Message);
                return Content("0");
            }
        }


        //public async Task<IActionResult> GetListChuaNhapLis()
        //{
        //    try
        //    {
        //        var tuNgay = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
        //        var denNgay = DateTime.Now.ToString("yyyyMMdd");

        //        var resultAwait = await _iLayMauTestNhanhRepo.GetListCoKetQuaChuaNhapLis(tuNgay, denNgay);
        //        var result = resultAwait.ToList();

        //        return PartialView("_GetListChuaNhapLis", result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogInformation("GetListChuaNhapLis" + ex.Message);
        //        return Content("0");
        //    }
        //}

        //public async Task<IActionResult> GetListDaNhapLis()
        //{
        //    try
        //    {
        //        var tuNgay = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
        //        var denNgay = DateTime.Now.ToString("yyyyMMdd");

        //        var resultAwait = await _iLayMauTestNhanhRepo.GetListCoKetQuaDaNhapLis(tuNgay, denNgay);
        //        var result = resultAwait.ToList();

        //        return PartialView("_GetListDaNhapLis", result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogInformation("GetListDaNhapLis" + ex.Message);
        //        return Content("0");
        //    }
        //}

        //public async Task<IActionResult> UpdateLis(int Id, bool NhapLis)
        //{
        //    try
        //    {
        //        //var tuNgay = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
        //        //var denNgay = DateTime.Now.ToString("yyyyMMdd");

        //        var resultAwait = await _iKetQuaTestNhanhRepo.UpdateLis(Id, NhapLis);
        //        var result = resultAwait;

        //        return Content(result.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogInformation("UpdateLis " + ex.Message);
        //        return Content("0");
        //    }
        //}
    }
}
