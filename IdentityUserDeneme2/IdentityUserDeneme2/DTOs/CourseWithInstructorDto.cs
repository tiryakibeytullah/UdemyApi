using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.DTOs
{
    public class CourseWithInstructorDto : CourseDto
    {
        public InstructorDto Instructors { get; set; }
    }
}
