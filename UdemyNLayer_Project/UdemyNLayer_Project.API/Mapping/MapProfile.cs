using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer_Project.API.DTOs;
using UdemyNLayer_Project.Core;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryWithCoursesDto>();
            CreateMap<CategoryWithCoursesDto, Category>();

            CreateMap<Course, CourseDto>();
            CreateMap<CourseDto, Course>();

            CreateMap<Course, CourseWithInstructorDto>();
            CreateMap<CourseWithInstructorDto, Course>();

            CreateMap<Instructor, InstructorDto>();
            CreateMap<InstructorDto, Instructor>();

            CreateMap<Instructor, InstructorWithCoursesDto>();
            CreateMap<InstructorWithCoursesDto, Instructor>();

            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();

            CreateMap<Student, StudentWithCoursesDto>();
            CreateMap<StudentWithCoursesDto, Student>();

            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, OrderWithCourseDto>().ReverseMap();
            CreateMap<Order, OrderWithStudentDto>().ReverseMap();
        }
    }
}
