#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b16c4e6d699e21dc7129747a51a29d723293ef15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GetListDaLayMauChuaKq), @"mvc.1.0.view", @"/Views/Home/_GetListDaLayMauChuaKq.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\_ViewImports.cshtml"
using TestNhanhCovid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\_ViewImports.cshtml"
using TestNhanhCovid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b16c4e6d699e21dc7129747a51a29d723293ef15", @"/Views/Home/_GetListDaLayMauChuaKq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c095b019579c7da1bff97da91f19f94eadf43bf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GetListDaLayMauChuaKq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LayMauTestNhanh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
  
    var stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""float-right"">
    <button id=""btnXemDanhSach"" class=""btn btn-primary"">Xem danh sách</button>
</div>

<table id=""tblDanhSachChuaKetQua"" class=""table display table-striped table-bordered"" style=""width:100%; font-size: 13px; color: black"">
    <thead>
        <tr class=""text-center"">
            <th style=""width: 5%"">STT</th>
            <th style=""width: 5%"">Mã Y tế</th>
            <th style=""width: 10%"">Họ tên</th>
            <th style=""width: 5%"">Năm sinh</th>
            <th style=""width: 5%"">Giới tính</th>
            <th style=""width: 10%"">Điện thoại</th>
            <th style=""width: 10%"">Tên chỉ định</th>
            <th style=""width: 10%"">Thời gian lấy mẫu</th>
            <th style=""width: 20%"">Đối tượng</th>

            <th style=""width: 10%"">Âm tính</th>
            <th style=""width: 10%"">Dương tính</th>
            <th>Ghi chú</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 39 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
         foreach (var item in Model.OrderBy(m=>m.ThoiGian))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 42 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
            Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 43 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                                                  Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 44 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                                                  Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 45 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                                                  Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 47 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                 if (item.GioiTinh == "F")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nữ</p>\r\n");
#nullable restore
#line 50 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nam</p>\r\n");
#nullable restore
#line 54 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 56 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
           Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
           Write(item.DichVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
           Write(item.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 60 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                 if (item.ThanhToan == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-info\">Theo Yêu cầu</span>\r\n");
#nullable restore
#line 63 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n            <td>\r\n                <span class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2217, "\"", 2272, 4);
            WriteAttributeValue("", 2227, "InsertKetQua(", 2227, 13, true);
#nullable restore
#line 67 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
WriteAttributeValue("", 2240, item.YeuCauChiTiet_Id, 2240, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2262, ",", 2262, 1, true);
            WriteAttributeValue(" ", 2263, "\'false\')", 2264, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Âm tính\r\n                </span>\r\n\r\n            </td>\r\n            <td>\r\n                <span class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2413, "\"", 2467, 4);
            WriteAttributeValue("", 2423, "InsertKetQua(", 2423, 13, true);
#nullable restore
#line 73 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
WriteAttributeValue("", 2436, item.YeuCauChiTiet_Id, 2436, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2458, ",", 2458, 1, true);
            WriteAttributeValue(" ", 2459, "\'true\')", 2460, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Dương tính\r\n                </span>\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 78 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                 if (item.GhiChu == "null" || item.GhiChu is null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span></span>\r\n");
#nullable restore
#line 81 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.Contains("2"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 2</span>\r\n");
#nullable restore
#line 85 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.Contains("3"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 3</span>\r\n");
#nullable restore
#line 89 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.Contains("4"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 4</span>\r\n");
#nullable restore
#line 93 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.Contains("5"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 5</span>\r\n");
#nullable restore
#line 97 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.ToLower().Contains("ck"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Hợp đồng công ty</span>\r\n");
#nullable restore
#line 101 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.ToLower().Contains("nn"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Nhân viên</span>\r\n");
#nullable restore
#line 105 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span></span>\r\n");
#nullable restore
#line 109 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 112 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListDaLayMauChuaKq.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"    <script>
        function UpdateLis(id, nhapLis) {
            $.ajax({
                type: ""GET"",
                url: ""/ketqua/UpdateLis"",
                //data: JSON.stringify(objArr),
                data: { 'id': id, 'nhapLis': nhapLis },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (responses) {
                    if (responses === 1 || responses === ""1"") {
                        GetListChuaNhapLis();
                    } else {
                        swal.fire(""Thêm dữ liệu bị lỗi"");
                    }
                },
                failure: function (response) {
                    alert(""failure: GetListLayMauTestNhanh"" + response.responseText);
                },
                error: function (response) {
                    alert(""error: GetListLayMauTestNhanh"" + response.responseText);
                }
            });
        }

        function InsertKetQua(id, ke");
            WriteLiteral(@"tqua) {
            var userId = $(""#slNguoiKetQua option:selected"").val();
            console.log(userId);
            if (userId === 0 || userId === ""0"") {
                swal.fire(""Chưa chọn người trả kết quả"");
                return false;
            }
            else {
                var congTy = """";
                var congSo2 = """";
                if ($(""#ckTenCongTy"").is("":checked"")) {
                    congTy = '1';
                } else {
                    congTy = '0'
                }

                if ($(""#ckCongSo2"").is("":checked"")) {
                    congSo2 = '1';
                } else {
                    congSo2 = '0'
                }

                $.ajax({
                    type: ""GET"",
                    url: ""/Home/InsertKetQua"",
                    //data: JSON.stringify(objArr),
                    data: { 'id': id, 'ketqua': ketqua, 'NguoiKetQua': userId },
                    //contentType: ""application/json; charset=utf-8"",
       ");
            WriteLiteral(@"             dataType: ""text"",
                    success: function (responses) {
                        if (responses === 1 || responses === ""1"") {
                            swal.fire(""Cập nhật kết quả thành công"");
                            GetListDaLayMauChuaKq(congTy, congSo2);
                            GetListDaLayMauCoKq(congTy, congSo2);


                            //GetListDaLayMauChuaKq();
                            //GetListDaLayMauCoKq();
                        } else {
                            swal.fire(""Thêm dữ liệu bị lỗi"");
                        }
                    },
                    failure: function (response) {
                        alert(""failure: GetListLayMauTestNhanh"" + response.responseText);
                    },
                    error: function (response) {
                        alert(""error: GetListLayMauTestNhanh"" + response.responseText);
                    }
                });
            }           
            
        }
");
            WriteLiteral(@"

        $(document).ready(function () {
            
            

            $('#tblDanhSachChuaKetQua').DataTable();

            $(""#btnXemDanhSach"").click(function () {
                if ($(""#ckTenCongTy"").is("":checked"") && $(""#ckCongSo2"").is("":checked"")) {
                    GetListDaLayMauChuaKq('1', '1');
                }
                else if ($(""#ckTenCongTy"").is("":checked"") && !$(""#ckCongSo2"").is("":checked"")) {
                    GetListDaLayMauChuaKq('1', '0');
                }
                else if (!$(""#ckTenCongTy"").is("":checked"") && $(""#ckCongSo2"").is("":checked"")) {
                    GetListDaLayMauChuaKq('0', '1');
                }
                else {
                    GetListDaLayMauChuaKq('0', '0');
                }


                //if ($(""#ckTenCongTy"").is("":checked"")) {
                //    GetListDaLayMauChuaKq('1');
                //} else {
                //    GetListDaLayMauChuaKq('0');
                //}


                //Ge");
            WriteLiteral("tListDaLayMauChuaKq();\r\n                \r\n            });            \r\n        });\r\n    </script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LayMauTestNhanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
