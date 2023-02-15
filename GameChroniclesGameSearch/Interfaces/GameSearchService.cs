using GameChroniclesGameSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChroniclesGameSearch.Interfaces
{
    public interface GameSearchService
    {
        public Task<GameSearchGame> GetGameByNameAsync(string name); 
    }
}
