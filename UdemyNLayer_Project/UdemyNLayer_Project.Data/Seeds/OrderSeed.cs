using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Data.Seeds
{
    public class OrderSeed : IEntityTypeConfiguration<Order>
    {
        private readonly int[] _studentId;
        private readonly int[] _courseId;
        public OrderSeed(int[] studentId, int[] courseId)
        {
            this._studentId = studentId;
            this._courseId = courseId;
        }
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order { Id = 1, StudentId = _studentId[0], CourseId = _courseId[0] },
                new Order { Id = 2, StudentId = _studentId[0], CourseId = _courseId[2] },
                new Order { Id = 3, StudentId = _studentId[1], CourseId = _courseId[1] });
        }
    }
}
