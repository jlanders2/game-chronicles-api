using GameChroniclesGameSearch.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameChroniclesApi.Controllers.Igdb
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameSearchController : ControllerBase
    {
        private readonly GameSearchService _gameSearchService;
        public GameSearchController(GameSearchService gameSearchService)
        {
            _gameSearchService = gameSearchService;
        }

        // Below is just an example of how to create endpoint
        //[HttpGet("name")]
        //public async Task<IActionResult> GetGameAndRatingByName(string gameName)
        //{
        //    var gameInfo = await _gameSearchService.GetGameByNameAsync(gameName);

        //    return Ok(gameInfo);
        //}
    }
}
