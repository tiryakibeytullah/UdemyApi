using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayer_Project.Web.DTOs
{
    public class OrderWithCourseDto : OrderDto
    {
        public CourseDto Courses { get; set; }
    }
}
