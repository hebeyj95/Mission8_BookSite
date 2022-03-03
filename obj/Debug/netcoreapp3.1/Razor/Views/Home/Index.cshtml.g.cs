#pragma checksum "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b67a4880b6933f3993b38b8c3c00ca4e8d0db2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\_ViewImports.cshtml"
using BookSite2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\_ViewImports.cshtml"
using BookSite2._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\_ViewImports.cshtml"
using BookSite2._0.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b67a4880b6933f3993b38b8c3c00ca4e8d0db2f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4217c3a2c99bc2fd5236df774fea351d3f9137", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::BookSite2._0.Infrastructure.PaginationTagHelper __BookSite2__0_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "BookSite2.0";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n    <div class=\"text-left\">\r\n");
#nullable restore
#line 12 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
         foreach (Book b in Model.Books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 14 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
           Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ul>\r\n                <li>Author: ");
#nullable restore
#line 16 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
                       Write(b.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Publisher: ");
#nullable restore
#line 17 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
                          Write(b.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>ISBN: ");
#nullable restore
#line 18 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
                     Write(b.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Category: ");
#nullable restore
#line 19 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
                         Write(b.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Number of Pages: ");
#nullable restore
#line 20 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
                                Write(b.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Price: $");
#nullable restore
#line 21 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
                       Write(b.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n");
#nullable restore
#line 23 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b67a4880b6933f3993b38b8c3c00ca4e8d0db2f6661", async() => {
            }
            );
            __BookSite2__0_Infrastructure_PaginationTagHelper = CreateTagHelper<global::BookSite2._0.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__BookSite2__0_Infrastructure_PaginationTagHelper);
#nullable restore
#line 25 "C:\Users\Heber\source\repos\Mission8_BookSite\Views\Home\Index.cshtml"
__BookSite2__0_Infrastructure_PaginationTagHelper.PageBlah = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-blah", __BookSite2__0_Infrastructure_PaginationTagHelper.PageBlah, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __BookSite2__0_Infrastructure_PaginationTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591