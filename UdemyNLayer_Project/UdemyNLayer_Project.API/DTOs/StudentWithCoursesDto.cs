using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayer_Project.API.DTOs
{
    public class StudentWithCoursesDto : StudentDto
    {
        public ICollection<CourseDto> Courses { get; set; }
    }
}
