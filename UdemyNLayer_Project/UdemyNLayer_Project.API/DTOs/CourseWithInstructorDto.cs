﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayer_Project.API.DTOs
{
    public class CourseWithInstructorDto : CourseDto
    {
        public InstructorDto Instructors { get; set; }
    }
}
