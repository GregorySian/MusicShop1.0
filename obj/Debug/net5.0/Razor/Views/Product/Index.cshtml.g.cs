#pragma checksum "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cceed4554f5310c42c8a3b42c38ee675b903d5a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Greg\source\repos\MusicShop1.0\Views\_ViewImports.cshtml"
using MusicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Greg\source\repos\MusicShop1.0\Views\_ViewImports.cshtml"
using MusicHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cceed4554f5310c42c8a3b42c38ee675b903d5a7", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cff3d055fe8ad9cee3631ea5013e52e73dc7617", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicHub.ViewModels.AlbumsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml"
 foreach (var p in Model.Albums)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 6 "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml"
       Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        ");
#nullable restore
#line 7 "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml"
   Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h4>");
#nullable restore
#line 8 "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml"
       Write(p.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("page-model", " page-model=\"", 210, "\"", 244, 1);
#nullable restore
#line 11 "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml"
WriteAttributeValue("", 223, Model.PaginationInfo, 223, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-action=\"List\" page-classes-enabled=\"true\"\r\n     page-class=\"btn\" page-class-normal=\"btn-secondary\"\r\n     page-class-selected=\"btn-primary\"");
            BeginWriteAttribute("page-url-category", " page-url-category=\"", 389, "\"", 428, 1);
#nullable restore
#line 13 "C:\Users\Greg\source\repos\MusicShop1.0\Views\Product\Index.cshtml"
WriteAttributeValue("", 409, Model.CurrentGenre, 409, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n     class=\"btn-group pull-right m-1\">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicHub.ViewModels.AlbumsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
