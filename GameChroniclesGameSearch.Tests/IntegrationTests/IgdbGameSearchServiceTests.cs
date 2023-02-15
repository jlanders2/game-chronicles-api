using GameChroniclesGameSearch.Services;
using NUnit.Framework;

namespace GameChroniclesGameSearch.Tests.IntegrationTests
{
    [TestFixture]
    internal class IgdbGameSearchServiceTests
    {
        private readonly IgdbGameSearchService _igdbGameSearchService;

        public IgdbGameSearchServiceTests()
        {
            _igdbGameSearchService = new IgdbGameSearchService();
        }

        [Test]
        public async Task IgdbGameSearchServiceTest_GetGameByName_ReturnsAValue() 
        {
            var game = await _igdbGameSearchService.GetGameByNameAsync("Arkham Knight");

            Assert.IsNotNull(game);
        }
    }
}
