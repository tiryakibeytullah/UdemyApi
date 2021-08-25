using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.DTOs
{
    public class OrderWithCourseAndStudentDto : OrderDto
    {
        public OrderWithCourseDto OrderWithCourseDto { get; set; }
        public OrderWithStudentDto OrderWithStudentDto { get; set; }
    }
}
