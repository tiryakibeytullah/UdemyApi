#pragma checksum "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e021a26f9d09dcb1d2e5b255d9b94f71c78e54c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_ViewImports.cshtml"
using IdentityUserDeneme2.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_ViewImports.cshtml"
using IdentityUserDeneme2.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_ViewImports.cshtml"
using IdentityUserDeneme2.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e021a26f9d09dcb1d2e5b255d9b94f71c78e54c", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abd2af9623ce8e8add151f6673f30e0c96a942a", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_AuthLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link text-dark"" href='/Identity/Account/Login'>Login</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link text-dark"" href='/Identity/Account/Register'>Register</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
#nullable restore
#line 21 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_AuthLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 30 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<script>
    $(function () {
        var current = this.location.pathname;
        $('.nav-tabs li a').each(function () {
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');
            }
        })
    })
</script>");
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