using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayer_Project.Web.DTOs
{
    public class InstructorWithCoursesDto : InstructorDto
    {
        public ICollection<CourseDto> Courses { get; set; }
    }
}
