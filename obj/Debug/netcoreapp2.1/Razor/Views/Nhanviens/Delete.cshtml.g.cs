#pragma checksum "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72ecc9dfa2e5c8c533a2ed9eb54e9028eb93053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nhanviens_Delete), @"mvc.1.0.view", @"/Views/Nhanviens/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nhanviens/Delete.cshtml", typeof(AspNetCore.Views_Nhanviens_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ecc9dfa2e5c8c533a2ed9eb54e9028eb93053", @"/Views/Nhanviens/Delete.cshtml")]
    public class Views_Nhanviens_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloApi.models.Nhanvien>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Nhanvien</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(247, 41, false);
#line 15 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.hoten));

#line default
#line hidden
            EndContext();
            BeginContext(288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(332, 37, false);
#line 18 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.hoten));

#line default
#line hidden
            EndContext();
            BeginContext(369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(413, 42, false);
#line 21 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.diachi));

#line default
#line hidden
            EndContext();
            BeginContext(455, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(499, 38, false);
#line 24 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.diachi));

#line default
#line hidden
            EndContext();
            BeginContext(537, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(581, 45, false);
#line 27 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.dienthoai));

#line default
#line hidden
            EndContext();
            BeginContext(626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(670, 41, false);
#line 30 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.dienthoai));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 44, false);
#line 33 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.mabophan));

#line default
#line hidden
            EndContext();
            BeginContext(799, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(843, 40, false);
#line 36 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.mabophan));

#line default
#line hidden
            EndContext();
            BeginContext(883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(927, 44, false);
#line 39 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ngaysinh));

#line default
#line hidden
            EndContext();
            BeginContext(971, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1015, 40, false);
#line 42 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ngaysinh));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1099, 44, false);
#line 45 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.gioitinh));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1187, 40, false);
#line 48 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.gioitinh));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1271, 40, false);
#line 51 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.macv));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1355, 36, false);
#line 54 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.macv));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1435, 40, false);
#line 57 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TDVH));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1519, 36, false);
#line 60 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TDVH));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1599, 44, false);
#line 63 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.bacluong));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1687, 40, false);
#line 66 "D:\ASP\HelloApi\HelloApi\Views\Nhanviens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.bacluong));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 263, true);
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""manhanvien"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-default"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloApi.models.Nhanvien> Html { get; private set; }
    }
}
#pragma warning restore 1591