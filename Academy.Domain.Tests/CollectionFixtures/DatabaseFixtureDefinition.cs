using Xunit;

namespace Academy.Domain.Tests.CollectionFixtures
{
    [CollectionDefinition("Database collection")]
    public class DatabaseFixtureDefinition :ICollectionFixture<DatabaseFixture>
    {
    }
}
