#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e65965bccb16dfbcd681e56a25c968d552af1c3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KetQua__GetListCoKqChuaIn), @"mvc.1.0.view", @"/Views/KetQua/_GetListCoKqChuaIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e65965bccb16dfbcd681e56a25c968d552af1c3c", @"/Views/KetQua/_GetListCoKqChuaIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c095b019579c7da1bff97da91f19f94eadf43bf9", @"/Views/_ViewImports.cshtml")]
    public class Views_KetQua__GetListCoKqChuaIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LayMauTestNhanh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
  
    var stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<table id=""tblDanhSachCoKetQuaChuaIn"" class=""table display table-striped table-bordered"" style=""width:100%; font-size: 13px; color: black"">
    <thead>
        <tr>
            <th style=""width: 5%"">STT</th>
            <th style=""width: 5%"">Mã Y tế</th>
            <th style=""width: 10%"">Họ tên</th>
            <th style=""width: 5%"">Năm sinh</th>
            <th style=""width: 5%"">Giới tính</th>
            <th style=""width: 10%"">Điện thoại</th>

            <th style=""width: 20%"">Tên chỉ định</th>
            <th style=""width: 10%"">Thời gian kết quả</th>
            <th>Đối tượng</th>
            <th style=""width: 10%"">Kết quả</th>
            <th>#</th>
");
            WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
         foreach (var item in Model.OrderByDescending(m=>m.ThoiGian))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 39 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
            Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 40 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                                                  Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 41 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                                                  Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 42 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                                                  Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 44 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                 if (item.GioiTinh == "F")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nữ</p>\r\n");
#nullable restore
#line 47 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nam</p>\r\n");
#nullable restore
#line 51 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 53 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
           Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
           Write(item.DichVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
           Write(item.ThoiGian);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 57 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                 if (item.ThanhToan == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"btn btn-info\">Theo Yêu cầu</span>\r\n");
#nullable restore
#line 60 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 63 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                 if (item.KetQua == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-primary\">\r\n                        Âm tính\r\n                    </span>\r\n");
#nullable restore
#line 68 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-danger\">\r\n                        Dương tính\r\n                    </span>\r\n");
#nullable restore
#line 74 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n<td>\r\n        <span class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2469, "\"", 2499, 3);
            WriteAttributeValue("", 2479, "UpdateDaIn(", 2479, 11, true);
#nullable restore
#line 79 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
WriteAttributeValue("", 2490, item.Id, 2490, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2498, ")", 2498, 1, true);
            EndWriteAttribute();
            WriteLiteral(">In kết quả</span>\r\n    </td>\r\n\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 84 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\KetQua\_GetListCoKqChuaIn.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"    <script>
        function UpdateDaIn(id) {
            $.ajax({
                type: ""GET"",
                url: ""/ketqua/UpdateDaIn"",
                //data: JSON.stringify(objArr),
                data: { 'id': id },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (responses) {
                    if (responses === 1 || responses === ""1"") {
                        GetListCoKqChuaIn();
                        GetListCoKqDaIn();
                    } else {
                        swal.fire(""In kết quả bị lỗi"");
                    }
                },
                failure: function (response) {
                    alert(""failure: UpdateDaIn _GetListCoKqChuaIn"" + response.responseText);
                },
                error: function (response) {
                    alert(""error: UpdateDaIn _GetListCoKqChuaIn"" + response.responseText);
                }
            });
        }


      ");
            WriteLiteral("  $(document).ready(function () {\r\n            $(\'#tblDanhSachCoKetQuaChuaIn\').DataTable();\r\n        });\r\n    </script>\r\n");
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