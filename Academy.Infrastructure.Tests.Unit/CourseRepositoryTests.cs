using Academy.Domain.Tests;
using FluentAssertions;
using Xunit;

namespace Academy.Infrastructure.Tests.Unit
{
    public class CourseRepositoryTests
    {
        private readonly CourseRepository _courseRepository;  
        private readonly CourseTestBuilder _courseBuilder;
        public CourseRepositoryTests()
        {
            _courseRepository = new CourseRepository();
            _courseBuilder = new CourseTestBuilder();
        }

        [Fact]
        public void Sould_Add_NewCourse_To_CourseList()
        {
            //arrange
            var course = _courseBuilder.Build();

            //act 
            _courseRepository.Create(course);

            //assert
            _courseRepository.Courses.Should().Contain(course);
           //repository.Courses.Should().ContainEquivalentOf(course);

        }

        [Fact]
        public void Should_return_ListOfCourse()
        {

            //act
            var courses = _courseRepository.GetAll();

            //assert
            courses.Should().HaveCountLessThanOrEqualTo(0);
        }

        [Fact]
        public void Should_Return_CourseById()
        {
            //arrang
            const int id = 55;
            var expectedCourse = _courseBuilder.WithId(id).Build();
            _courseRepository.Create(expectedCourse);

            //act
            var actual = _courseRepository.GetBy(id);

            //assert
            actual.Should().Be(expectedCourse);
        }


        [Fact]
        public void Should_ReturnNull_when_IdNotExists()
        {
            const int id = 55;
            var actual = _courseRepository.GetBy(id);
            actual.Should().BeNull();
        }
    }
}