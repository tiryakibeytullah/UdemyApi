using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Data.Seeds
{
    public class StudentSeed : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(new Student { Id = 1, Name = "Beytullah", Surname = "Tiryaki", Mail = "beytullah@gmail.com", Password = "123456", Telephone = "05434382577" },
                new Student { Id = 2, Name = "Burak", Surname = "Tiryaki", Mail = "burak@gmail.com", Password = "123456", Telephone = "05434382557" });
        }
    }
}
