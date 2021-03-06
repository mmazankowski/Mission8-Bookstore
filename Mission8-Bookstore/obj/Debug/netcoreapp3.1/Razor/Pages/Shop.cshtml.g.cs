#pragma checksum "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "954d90c5200d59d34db14afcbe316276f9917b0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mission8_Bookstore.Pages.Pages_Shop), @"mvc.1.0.razor-page", @"/Pages/Shop.cshtml")]
namespace Mission8_Bookstore.Pages
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
#line 3 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/_ViewImports.cshtml"
using Mission8_Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"954d90c5200d59d34db14afcbe316276f9917b0f", @"/Pages/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1d7cba2ed93f515fe2d6024c41552ec5f19769", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shop : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Your Cart</h2>\n\n<table class=\"table table-bordered table-striped\">\n\n    <thead>\n        <tr>\n            <th>Item</th>\n            <th>Quantity</th>\n            <th>Cost</th>\n            <th>Subtotal</th>\n        </tr>\n    </thead>\n\n    <tbody>\n");
#nullable restore
#line 20 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
         foreach(var i in Model.cart.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 23 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
           Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
           Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
           Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
            Write(i.Quantity * i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 28 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\">Total:</td>\n            <td>");
#nullable restore
#line 34 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
           Write(Model.cart.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n\n</table>\n\n<div>\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 764, "\"", 787, 1);
#nullable restore
#line 41 "/Users/matthewmazankowski/Desktop/413-Mission/Mission8-Bookstore/Mission8-Bookstore/Pages/Shop.cshtml"
WriteAttributeValue("", 771, Model.ReturnUrl, 771, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission8_Bookstore.Pages.ShopModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission8_Bookstore.Pages.ShopModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission8_Bookstore.Pages.ShopModel>)PageContext?.ViewData;
        public Mission8_Bookstore.Pages.ShopModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
