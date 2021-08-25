using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.DTOs
{
    public class CategoryWithCoursesDto : CategoryDto
    {
        public ICollection<CourseDto> Courses { get; set; }
    }
}
