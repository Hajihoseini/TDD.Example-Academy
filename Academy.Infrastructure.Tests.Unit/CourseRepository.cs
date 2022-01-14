using Academy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Infrastructure.Tests.Unit
{
    public class CourseRepository
    {
        public List<Course> Courses = new List<Course>
        {
            new Course(24,"Programming with C#",true,5000)
        };

        public void Create(Course course)
        {
            Courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return Courses;
        }

        public Course GetBy(int id)
        {
            return Courses.FirstOrDefault(x=>x.Id==id) ;
        }
    }
}