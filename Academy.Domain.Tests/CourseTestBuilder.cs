using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Academy.Domain.CourseTests;

namespace Academy.Domain.Tests
{
    public class CourseTestBuilder
    {
        const int id = 1;
        string name = "Programming";
        const bool isOnline = true;
        double tuition = 1000;

        public CourseTestBuilder WithName(string name)
        {
            this.name = name;
            return this;    
        }

        public CourseTestBuilder WithTuition(double tuition)
        {
            this.tuition = tuition;
            return this;
        }

        public Course Build()
        {
            return new Course(id, name, isOnline, tuition);
        }
    }
}
