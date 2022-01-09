using FluentAssertions;
using System;
using Xunit;
using static Academy.Domain.CourseTests;

namespace Academy.Domain.Tests
{
    public partial class CourseTests
    {
        [Fact]
        public void Constructor_ShouldConstructCourseProperly()
        {
            const int id = 1;
            const string name = "Programming";
            const bool isOnline = true;
            const double tuition = 1000;

            var coursesBuilder= new CourseTestBuilder();
            var course = coursesBuilder.Build();

            course.Id.Should().Be(id);  
            course.Name.Should().Be(name);
            course.IsOnline.Should().Be(isOnline);
            course.Tuition.Should().Be(tuition);

        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenNameIsNotProvided()
        {
            var coursesBuilder = new CourseTestBuilder();
            Action course = () => coursesBuilder.WithName("").Build();
            course.Should().Throw<Exception>();
        }


        [Fact]
        public void Constructor_ShouldThrowException_WhenTuitionIsNotProvided()
        {
            var coursesBuilder = new CourseTestBuilder();
            Action course = () => coursesBuilder.WithTuition(0).Build();
            
            course.Should().Throw<Exception>();
        }
    }
}