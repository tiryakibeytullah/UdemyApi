using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayer_Project.Web.DTOs
{
    public class CourseWithInstructorDto : CourseDto
    {
        public InstructorDto Instructors { get; set; }
    }
}
