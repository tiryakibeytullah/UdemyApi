using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer_Project.Core;
using UdemyNLayer_Project.Core.Models;
using UdemyNLayer_Project.Data.Configurations;
using UdemyNLayer_Project.Data.Seeds;

namespace UdemyNLayer_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2, 3, 4 }));
            modelBuilder.ApplyConfiguration(new CourseSeed(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 }));
            modelBuilder.ApplyConfiguration(new OrderSeed(new int[] { 1, 1, 2 }, new int[] { 1, 3, 2 }));
            modelBuilder.ApplyConfiguration(new InstructorSeed(new int[] { 1, 2, 3, 4 }));
            modelBuilder.ApplyConfiguration(new StudentSeed());
        }
    }
}
