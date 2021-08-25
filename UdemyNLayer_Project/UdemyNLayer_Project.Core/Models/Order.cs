using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyNLayer_Project.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime OrderTime { get; set; }
        public virtual Student Students { get; set; }
        public virtual Course Courses { get; set; }
    }
}
