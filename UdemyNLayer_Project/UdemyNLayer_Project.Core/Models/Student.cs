using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UdemyNLayer_Project.Core.Models
{
    public class Student
    {
        public Student()
        {
            Courses = new Collection<Course>();
            Orders = new Collection<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
