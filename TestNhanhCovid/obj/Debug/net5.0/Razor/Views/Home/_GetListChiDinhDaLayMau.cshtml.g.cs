#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "090070f554022b084466aae2d28fadd736e43537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GetListChiDinhDaLayMau), @"mvc.1.0.view", @"/Views/Home/_GetListChiDinhDaLayMau.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090070f554022b084466aae2d28fadd736e43537", @"/Views/Home/_GetListChiDinhDaLayMau.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c095b019579c7da1bff97da91f19f94eadf43bf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GetListChiDinhDaLayMau : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LayMauTestNhanh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
  
    var stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<table id=""tblDanhSachDaLayMau"" class=""table display table-striped table-bordered table-responsive"" style=""width:100%; font-size: 13px; color: black"">
    <thead>
        <tr>
            <th style=""width: 5%"">STT</th>
            <th style=""width: 5%"">M?? Y t???</th>
            <th style=""width: 5%"">H??? t??n</th>
            <th style=""width: 5%"">N??m sinh</th>
            <th style=""width: 5%"">Gi???i t??nh</th>
            <th style=""width: 5%"">??i???n tho???i</th>

            <th style=""width: 5%"">T??n ch??? ?????nh</th>            
            <th>Code Xn</th>
            <th>Tr???ng th??i</th>
");
            WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
         foreach (var item in Model.OrderByDescending(m=>m.ThoiGian))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
                Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 38 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
                                                      Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 39 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
                                                      Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 40 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
                                                      Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 42 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
                     if(item.GioiTinh == "F")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>N???</p>\r\n");
#nullable restore
#line 45 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nam</p>\r\n");
#nullable restore
#line 49 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 51 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
               Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
               Write(item.DichVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
               Write(item.CodeXn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <span class=\"btn btn-primary\">\r\n                            ???? l???y m???u\r\n                        </span>\r\n\r\n                </td>\r\n                \r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 63 "G:\SourceCodeWebApp\XNTestNhanhCovid\TestNhanhCovid\TestNhanhCovid\Views\Home\_GetListChiDinhDaLayMau.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"    <script>
        //function InsertKetQua(id, ketqua) {
        //    $.ajax({
        //        type: ""GET"",
        //        url: ""/Home/InsertKetQua"",
        //        //data: JSON.stringify(objArr),
        //        data: { 'id': id, 'ketqua': ketqua },
        //        //contentType: ""application/json; charset=utf-8"",
        //        dataType: ""text"",
        //        success: function (responses) {
        //            if (responses === 1 || responses === ""1"") {
        //                GetListLayMauTestNhanh();
        //            } else {
        //                swal.fire(""Th??m d??? li???u b??? l???i"");
        //            }
        //        },
        //        failure: function (response) {
        //            alert(""failure: GetListLayMauTestNhanh"" + response.responseText);
        //        },
        //        error: function (response) {
        //            alert(""error: GetListLayMauTestNhanh"" + response.responseText);
        //        }
        //    });
");
            WriteLiteral("        //}\r\n\r\n\r\n        $(document).ready(function () {\r\n            $(\'#tblDanhSachDaLayMau\').DataTable();\r\n        });\r\n    </script>\r\n");
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
