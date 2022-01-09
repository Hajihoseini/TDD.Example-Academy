using FluentAssertions;
using System;
using Xunit;

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
            course.Sections.Should().BeEmpty();
        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenNameIsNotProvided()
        {
            var coursesBuilder = new CourseTestBuilder();
            Action course = () => coursesBuilder.WithName("").Build();
            course.Should().ThrowExactly<CourseNameIsInvalidException>();
        }


        [Fact]
        public void Constructor_ShouldThrowException_WhenTuitionIsNotProvided()
        {
            var coursesBuilder = new CourseTestBuilder();
            Action course = () => coursesBuilder.WithTuition(0).Build();
            course.Should().ThrowExactly<CourseTuitionIsInvalidException>();
        }


        [Fact]
        public void AddSection_ShouldAddNewSectionToSections_WhenIdAndNamePassed()
        {
            //arrange
            var courseBuilder = new CourseTestBuilder();
            var course = courseBuilder.Build();
            var sectionToAdd = SectionFactory.Create();


            //act
            course.AddSection(sectionToAdd);


            //assert
            course.Sections.Should().ContainEquivalentOf(sectionToAdd);

        }
    }
}