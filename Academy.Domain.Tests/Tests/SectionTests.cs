using Academy.Domain.Tests.CollectionFixtures;
using FluentAssertions;
using Xunit;

namespace Academy.Domain.Tests
{
    [Collection("Database collection")]
    public class SectionTests
    {
        public SectionTests(DatabaseFixture databaseFixture)
        {

        }

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
