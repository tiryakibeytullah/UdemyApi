using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Core
{
    public class Instructor
    {
        public Instructor()
        {
            Courses = new Collection<Course>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TCNo { get; set; }
        public string Telephone { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public string Degree { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
