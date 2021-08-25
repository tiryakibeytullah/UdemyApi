using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.DTOs
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Course_Hour { get; set; }
        public string Course_ImageUrl { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }

    }
}
