using FluentAssertions;
using Xunit;

namespace Academy.Domain.Tests
{
    public class SectionTests
    {
        [Fact]
        public void Constructor_should_construct_section_properly()
        {
            //arrange -> Setup
            const int id = 1;
            const string name = "Python";


            //act -> Exercise
            var section = new Section(id, name);


            //assert -> Verify
            section.Id.Should().Be(id);
            section.Name.Should().Be(name); 

        }
    }
}
