#pragma checksum "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8aa191e13272f4629812e99483424c8e3775a0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8aa191e13272f4629812e99483424c8e3775a0a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb817f1937de1591ebc3032773a5c6899211867", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8aa191e13272f4629812e99483424c8e3775a0a3079", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n\r\n    <link href=\"/node/bootstrap/dist/css/bootstrap.min.css\" rel=\"stylesheet\"  crossorigin=\"anonymous\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8aa191e13272f4629812e99483424c8e3775a0a4279", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("MessageBox"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
   Write(RenderSection("MessageBox"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
                                    
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-success text-center m-0\">\r\n            Genel mesaj\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
#nullable restore
#line 22 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
Write(RenderSection("Header",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <main class=\"my-3\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 29 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
             if (IsSectionDefined("Categories"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-3\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
                   Write(RenderSection("Categories",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 47 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </main>\r\n\r\n    <footer class=\"py-5 bg-dark text-white text-center\">\r\n        Shopp App | 2021\r\n    </footer>\r\n\r\n\r\n    ");
#nullable restore
#line 57 "C:\Users\Sinan\Desktop\ShopApp\shoppapp.webui\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591