#pragma checksum "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075ac5ab185c3dfc49de42db1e7461a3e9b81876"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075ac5ab185c3dfc49de42db1e7461a3e9b81876", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0962e4c00bbc9902610de49dac8b794b651d6caf", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityUserDeneme2.DTOs.OrderDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger mx-2 btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info mx-2 btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetWithCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm mr-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var studentList = (List<SelectListItem>)ViewData["studentList"];
    var courseList = (List<SelectListItem>)ViewData["courseList"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<figure class=""text-center"">
    <blockquote class=""blockquote"">
        <h2>Orders</h2>
    </blockquote>
    <figcaption class=""blockquote-footer mt-1"">
        Page with order information.
    </figcaption>
</figure>

<div class=""container"">
    <div class=""col align-self-center"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Student Name</th>
                    <th scope=""col"">Course Name</th>
                    <th scope=""col"" style=""padding-right:180px; text-align:right;"">Transactions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                 foreach (var order in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                     if (ViewBag.roleName == "Admin")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 35 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                       Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"row\">\r\n");
#nullable restore
#line 37 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                 foreach (var item in studentList)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                     if (order.StudentId == Convert.ToInt32(item.Value))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                  
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </th>\r\n                            <th scope=\"row\">\r\n");
#nullable restore
#line 46 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                 foreach (var item in courseList)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                     if (order.CourseId == Convert.ToInt32(item.Value))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                  
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </th>\r\n                            <th scope=\"row\" style=\"padding-right: 150px; text-align: right;\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075ac5ab185c3dfc49de42db1e7461a3e9b8187610816", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                                                                WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075ac5ab185c3dfc49de42db1e7461a3e9b8187613156", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                                                                    WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075ac5ab185c3dfc49de42db1e7461a3e9b8187615500", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                                                                         WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                     if (ViewBag.roleName == "Student")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                         if (ViewBag.userId == order.StudentId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 66 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                           Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th scope=\"row\">\r\n");
#nullable restore
#line 68 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                     foreach (var item in studentList)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                         if (order.StudentId == Convert.ToInt32(item.Value))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                       Write(item.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                      
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </th>\r\n                                <th scope=\"row\">\r\n");
#nullable restore
#line 77 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                     foreach (var item in courseList)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                         if (order.CourseId == Convert.ToInt32(item.Value))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                       Write(item.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                      
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </th>\r\n                                <th scope=\"row\" style=\"padding-right: 150px; text-align: right;\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075ac5ab185c3dfc49de42db1e7461a3e9b8187622359", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                                                                                                             WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n");
#nullable restore
#line 89 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Beytullah\source\repos\IdentityUserDeneme2\IdentityUserDeneme2\Views\Order\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityUserDeneme2.DTOs.OrderDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
