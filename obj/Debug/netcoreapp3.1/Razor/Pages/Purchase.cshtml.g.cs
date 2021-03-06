#pragma checksum "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f50750ade344bc5d11f5ce1516cdf2b7b10b7e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Purchase), @"mvc.1.0.razor-page", @"/Pages/Purchase.cshtml")]
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
#line 2 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\_ViewImports.cshtml"
using BookSite2._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f50750ade344bc5d11f5ce1516cdf2b7b10b7e6", @"/Pages/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d34c9f248219b37349cee8de8fcb1652ef27134", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Purchase : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""m-3"" >
    <h2>Your Basket</h2>
    <table class=""table table-borderless table table-striped"">
        <thead>
            <tr>
                <th>Item</th>
                <th>Quantity</th>
                <th>Price</th>
                <th>Subtotal</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
             foreach (var i in Model.basket.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
                   Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
                   Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
                   Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
                    Write(i.Quantity * i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr class=\"font-weight-bold bg-light\">\r\n                <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
               Write(Model.basket.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n\r\n    <div>\r\n        <a class=\"btn btn-outline-secondary\"");
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1056, 1);
#nullable restore
#line 36 "C:\Users\Heber\source\repos\Mission8_BookSite\Pages\Purchase.cshtml"
WriteAttributeValue("", 1040, Model.ReturnUrl, 1040, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookSite2._0.Pages.PurchaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookSite2._0.Pages.PurchaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookSite2._0.Pages.PurchaseModel>)PageContext?.ViewData;
        public BookSite2._0.Pages.PurchaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
