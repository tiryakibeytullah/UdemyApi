#pragma checksum "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17c67052b302bfadf1d835d95d63669f90de8609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Create), @"mvc.1.0.view", @"/Views/Order/Create.cshtml")]
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
#line 1 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\_ViewImports.cshtml"
using IdentityUserDeneme2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\_ViewImports.cshtml"
using IdentityUserDeneme2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17c67052b302bfadf1d835d95d63669f90de8609", @"/Views/Order/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0962e4c00bbc9902610de49dac8b794b651d6caf", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityUserDeneme2.DTOs.CourseDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<figure class=\"text-center\">\r\n    <blockquote class=\"blockquote\">\r\n        <h2>Buy a course</h2>\r\n    </blockquote>\r\n    <figcaption class=\"blockquote-footer mt-1\">\r\n        Page with buy a course information.\r\n    </figcaption>\r\n</figure>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17c67052b302bfadf1d835d95d63669f90de86094148", async() => {
                WriteLiteral("\r\n    <div class=\"card border-0\" style=\"width:24rem;\">\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 469, "\"", 497, 1);
#nullable restore
#line 17 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml"
WriteAttributeValue("", 475, Model.Course_ImageUrl, 475, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 498, "\"", 526, 1);
#nullable restore
#line 17 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml"
WriteAttributeValue("", 504, Model.Name + ".png", 504, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid w-100\" />\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml"
                            Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p class=\"card-text\">\r\n                <b>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml"
               Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-currency-dollar mb-1"" viewBox=""0 0 16 16"">
                        <path d=""M4 10.781c.148 1.667 1.513 2.85 3.591 3.003V15h1.043v-1.216c2.27-.179 3.678-1.438 3.678-3.3 0-1.59-.947-2.51-2.956-3.028l-.722-.187V3.467c1.122.11 1.879.714 2.07 1.616h1.47c-.166-1.6-1.54-2.748-3.54-2.875V1H7.591v1.233c-1.939.23-3.27 1.472-3.27 3.156 0 1.454.966 2.483 2.661 2.917l.61.162v4.031c-1.149-.17-1.94-.8-2.131-1.718H4zm3.391-3.836c-1.043-.263-1.6-.825-1.6-1.616 0-.944.704-1.641 1.8-1.828v3.495l-.2-.05zm1.591 1.872c1.287.323 1.852.859 1.852 1.769 0 1.097-.826 1.828-2.2 1.939V8.73l.348.086z"" />
                    </svg>
                </b>
            </p>
            <p class=""card-text""><small class=""text-muted"">");
#nullable restore
#line 29 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Create.cshtml"
                                                       Write(Model.Course_Hour + " Hour");

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary btn-sm col-md-6\">Buy</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityUserDeneme2.DTOs.CourseDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
