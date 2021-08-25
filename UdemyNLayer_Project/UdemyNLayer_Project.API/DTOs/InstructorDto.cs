using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayer_Project.API.DTOs
{
    public class InstructorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public string Degree { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
