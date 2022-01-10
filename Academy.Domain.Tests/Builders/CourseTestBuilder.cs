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
        private const int id = 1;
        private string _name = "Programming";
        private const bool IsOnline = true;
        private double _tuition = 1000;

        public CourseTestBuilder WithName(string name)
        {
            _name = name;
            return this;    
        }

        public CourseTestBuilder WithTuition(double tuition)
        {
            _tuition = tuition;
            return this;
        }

        public Course Build()
        {
            return new Course(id, _name, IsOnline, _tuition);
        }
    }
}
