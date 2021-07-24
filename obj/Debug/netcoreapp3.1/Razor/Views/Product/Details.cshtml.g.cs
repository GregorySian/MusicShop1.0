#pragma checksum "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318a4d4be51e1a6f621a7ff19b0e6ff631f6b65d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\_ViewImports.cshtml"
using MusicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\_ViewImports.cshtml"
using MusicHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318a4d4be51e1a6f621a7ff19b0e6ff631f6b65d", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cff3d055fe8ad9cee3631ea5013e52e73dc7617", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Album>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Product Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "318a4d4be51e1a6f621a7ff19b0e6ff631f6b65d3336", async() => {
                WriteLiteral("\r\n    <h1>Album Details</h1>\r\n");
#nullable restore
#line 9 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Product\Details.cshtml"
     foreach (var a in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"caption\">\r\n                    <div class=\"Album-Title\">\r\n                        <h3>\r\n                             ");
#nullable restore
#line 16 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Product\Details.cshtml"
                        Write(a.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"Album\">\r\n                        <div class=\"img-thumbnail\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 602, "\"", 619, 1);
#nullable restore
#line 21 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Product\Details.cshtml"
WriteAttributeValue("", 608, a.ImageUrl, 608, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <div>\r\n                                <h5>Track List</h5>\r\n                            </div>\r\n                            <ol>\r\n                                <li>");
#nullable restore
#line 26 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Product\Details.cshtml"
                               Write(a.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            </ol>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Product\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591