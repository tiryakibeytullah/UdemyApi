#pragma checksum "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4756a5635e11e35649b626ca9d8231a308f7bf5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_IndexWithCourses), @"mvc.1.0.view", @"/Views/Instructors/IndexWithCourses.cshtml")]
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
#line 1 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\_ViewImports.cshtml"
using UdemyNLayer_Project.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\_ViewImports.cshtml"
using UdemyNLayer_Project.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\_ViewImports.cshtml"
using UdemyNLayer_Project.Web.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4756a5635e11e35649b626ca9d8231a308f7bf5f", @"/Views/Instructors/IndexWithCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42359b046b78df91b65f6d16ffdea301e5e21ea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_IndexWithCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InstructorWithCoursesDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
  
    ViewData["Title"] = "IndexWithCourses";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<figure class=""text-center"">
    <blockquote class=""blockquote"">
        <h2>Instructor</h2>
    </blockquote>
    <figcaption class=""blockquote-footer mt-1"">
        Page with Instructor courses.
    </figcaption>
</figure>

<div class=""container"">
    <div class=""container-fluid"">
        <div class=""row row-cols-1 row-cols-md-2 g-4 mt-2"">
");
#nullable restore
#line 18 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
             foreach (var courseDetail in Model.Courses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6\">\r\n                    <div class=\"card border-0\">\r\n                        <img class=\"card-img-top text-center\"");
            BeginWriteAttribute("src", " src=\"", 666, "\"", 701, 1);
#nullable restore
#line 22 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
WriteAttributeValue("", 672, courseDetail.Course_ImageUrl, 672, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:450px; height:225px;\">\r\n                        <div class=\"card-body\">\r\n                            <div style=\"max-width:440px;\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
                                                  Write(courseDetail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
                                                Write(courseDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <p class=\"mt-2\"><strong>");
#nullable restore
#line 28 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
                                                Write(courseDetail.Price + " TL");

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                            <p class=\"card-text\">\r\n                                <small class=\"text-muted\">\r\n                                    ");
#nullable restore
#line 31 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
                                Write(courseDetail.Course_Hour + " Saat | T??m D??zeyler | ");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star-fill mb-1"" viewBox=""0 0 16 16"">
                                        <path d=""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"" />
                                    </svg>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star-fill mb-1"" viewBox=""0 0 16 16"">
                                        <path d=""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"" />
                            ");
            WriteLiteral(@"        </svg>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star-fill mb-1"" viewBox=""0 0 16 16"">
                                        <path d=""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"" />
                                    </svg>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star-fill mb-1"" viewBox=""0 0 16 16"">
                                        <path d=""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"" />
              ");
            WriteLiteral(@"                      </svg>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star-half mb-1"" viewBox=""0 0 16 16"">
                                        <path d=""M5.354 5.119 7.538.792A.516.516 0 0 1 8 .5c.183 0 .366.097.465.292l2.184 4.327 4.898.696A.537.537 0 0 1 16 6.32a.548.548 0 0 1-.17.445l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256a.52.52 0 0 1-.146.05c-.342.06-.668-.254-.6-.642l.83-4.73L.173 6.765a.55.55 0 0 1-.172-.403.58.58 0 0 1 .085-.302.513.513 0 0 1 .37-.245l4.898-.696zM8 12.027a.5.5 0 0 1 .232.056l3.686 1.894-.694-3.957a.565.565 0 0 1 .162-.505l2.907-2.77-4.052-.576a.525.525 0 0 1-.393-.288L8.001 2.223 8 2.226v9.8z"" />
                                    </svg>
                                </small>
                            </p>
                        </div>
                    </div>
                    <hr style=""width:500px;"" />
                </div>
");
#nullable restore
#line 53 "C:\Users\Beytullah\Desktop\Staj-Proje\UdemyNLayer_Project\UdemyNLayer_Project.Web\Views\Instructors\IndexWithCourses.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InstructorWithCoursesDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
