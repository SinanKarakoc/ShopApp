#pragma checksum "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "857b0b0bc1e9ad4cd2ac4c9efd4c0da2d95d9604"
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
#line 1 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\_ViewImports.cshtml"
using shoppapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857b0b0bc1e9ad4cd2ac4c9efd4c0da2d95d9604", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb817f1937de1591ebc3032773a5c6899211867", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
  
    var products = Model.Products;


#line default
#line hidden
#nullable disable
            DefineSection("MessageBox", async() => {
                WriteLiteral("\r\n    <div class=\"alert alert-success text-center m-0\">\r\n        Naber bruh?\r\n    </div>\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n     \r\n ");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n     ");
#nullable restore
#line 23 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n ");
            }
            );
            WriteLiteral(" \r\n");
#nullable restore
#line 26 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
 if (Model.Products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
                                          
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
         foreach (var item in products)//Model.Products yerine yukarda var tanımladık onu kullandık
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("_product",item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 41 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591