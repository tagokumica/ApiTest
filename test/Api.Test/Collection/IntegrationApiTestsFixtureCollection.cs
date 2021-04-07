using Api.Test.Config;
using Xunit;

namespace Api.Test.Collection
{
    [CollectionDefinition(nameof(IntegrationApiTestsFixtureCollection))]
    public class IntegrationApiTestsFixtureCollection:  ICollectionFixture<IntegrationTestsFixture<Startup>>
    {
        
    }
}