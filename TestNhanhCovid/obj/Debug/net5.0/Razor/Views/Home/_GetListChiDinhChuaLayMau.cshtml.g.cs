#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78ce3c108b2e86e719c1253f11eccd70167b10e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GetListChiDinhChuaLayMau), @"mvc.1.0.view", @"/Views/Home/_GetListChiDinhChuaLayMau.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ce3c108b2e86e719c1253f11eccd70167b10e1", @"/Views/Home/_GetListChiDinhChuaLayMau.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c095b019579c7da1bff97da91f19f94eadf43bf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GetListChiDinhChuaLayMau : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LayMauTestNhanh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
  
    var stt = 1;
    var codeXn = ViewBag.CodeXn;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""float-right"">
    <button id=""btnXemDanhSachChuaLayMau"" class=""btn btn-primary"">Xem danh sách</button>
</div>
<table id=""tblDanhSachLayMau"" class=""table display table-striped table-bordered"" style=""width:100%; font-size: 13px; color: black"">
    <thead>
        <tr class=""text-center"">
            <th style=""width: 5%"">STT</th>
            <th style=""width: 5%"">Mã Y tế</th>
            <th style=""width: 10%"">Họ tên</th>
            <th style=""width: 5%"">Năm sinh</th>
            <th style=""width: 5%"">Giới tính</th>
            <th style=""width: 10%"">Điện thoại</th>

            <th style=""width: 10%"">Tên chỉ định</th>
            <th style=""width: 10%"">Thời gian chỉ định</th>     
");
            WriteLiteral("            <th style=\"width: 5%\">Code Xn</th>\r\n            <th style=\"width: 10%\">Đối tượng</th>\r\n            <th style=\"width: 10%\">Xử lý</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
         foreach (var item in Model.OrderBy(m=>m.ThoiGian))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 43 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 44 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                                                      Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 45 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                                                      Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 46 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                                                      Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 48 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                     if (item.GioiTinh == "F")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nữ</p>\r\n");
#nullable restore
#line 51 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nam</p>\r\n");
#nullable restore
#line 55 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 57 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
               Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
               Write(item.DichVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
               Write(item.ThoiGian);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 67 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                Write(codeXn++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 69 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                     if(item.ThanhToan == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"btn btn-info\">Theo Yêu cầu</span>\r\n");
#nullable restore
#line 72 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                    }                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <span class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2750, "\"", 2797, 6);
            WriteAttributeValue("", 2760, "LayMau(", 2760, 7, true);
#nullable restore
#line 75 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
WriteAttributeValue("", 2767, item.Id, 2767, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2775, ",", 2775, 1, true);
            WriteAttributeValue(" ", 2776, "\'", 2777, 2, true);
#nullable restore
#line 75 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
WriteAttributeValue("", 2778, item.NguoiLayMau, 2778, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2795, "\')", 2795, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Lấy mẫu</span>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 78 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"    <script>
        function InsertKetQua(id, ketqua) {            
            $.ajax({
                type: ""GET"",
                url: ""/Home/InsertKetQua"",
                //data: JSON.stringify(objArr),
                data: { 'id': id, 'ketqua': ketqua },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (responses) {
                    if (responses === 1 || responses === ""1"") {
                        GetListLayMauTestNhanhChuaKetQua();
                        //GetListLayMauTestNhanhCoKetQua();
                    } else {
                        swal.fire(""Thêm dữ liệu bị lỗi"");
                    }
                },
                failure: function (response) {
                    alert(""failure: GetListLayMauTestNhanh"" + response.responseText);
                },
                error: function (response) {
                    alert(""error: GetListLayMauTestNhanh"" + response.responseText)");
            WriteLiteral(@";
                }
            });
        }
        function LayMau(id, nguoilaymau) {
            $.ajax({
                type: ""GET"",
                url: ""/Home/Insert"",
                //data: JSON.stringify(objArr),
                data: { 'id': id, 'nguoilaymau': nguoilaymau },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (responses) {
                    if (responses === 1 || responses === ""1"") {
                        GetListChiDinhChuaLayMau();
                        GetListChiDinhDaLayMau();
                    } else {
                        swal.fire(""Thêm dữ liệu bị lỗi"");
                    }
                },
                failure: function (response) {
                    alert(""failure: GetListLayMauTestNhanh"" + response.responseText);
                },
                error: function (response) {
                    alert(""error: GetListLayMauTestNhanh"" + response.resp");
            WriteLiteral(@"onseText);
                }
            });
        }

        $(document).ready(function () {
            $('#tblDanhSachLayMau').DataTable();

            $(""#btnXemDanhSachChuaLayMau"").click(function () {
                GetListChiDinhChuaLayMau();
            });
        });
    </script>
");
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
