using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UdemyNLayer_Project.Core.Models
{
    public class Category
    {
        public Category()
        {
            Courses = new Collection<Course>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
