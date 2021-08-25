using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UdemyNLayer_Project.Core.Models
{
    public class Course
    {
        public Course()
        {
            Orders = new Collection<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Course_Hour { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public string Course_ImageUrl { get; set; }
        public ICollection<Order> Orders { get; set; }
        public virtual Instructor Instructors { get; set; }
        public virtual Category Categories { get; set; }
        public virtual Student Students { get; set; }
    }
}
