using GameChroniclesGameSearch.Interfaces;
using GameChroniclesGameSearch.Models;
using IGDB;
using IGDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChroniclesGameSearch.Services
{
    public class IgdbGameSearchService : GameSearchService
    {
        private IGDBClient _igdbClient;

        public IgdbGameSearchService()
        {
            _igdbClient = new IGDBClient
            (
                Environment.GetEnvironmentVariable("IGDB_CLIENT_ID"),
                Environment.GetEnvironmentVariable("IGDB_CLIENT_SECRET")
            );
        }

        public async Task<GameSearchGame> GetGameByNameAsync(string name)
        {
            var games = await _igdbClient.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: $"fields name, rating; search \"{name}\"; where category = 0;");
            var game = games.First();

            var gameSearchGame = new GameSearchGame();
            gameSearchGame.Name = game.Name;
            gameSearchGame.Rating = game.Rating;


            return gameSearchGame;
        }
    }
}
