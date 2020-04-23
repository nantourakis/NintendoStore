using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public interface IGameRepository
    {
        // what METHODS do we need in our Game interface? - list here

        //GetAllGames - use IEnumerbale of type Game
        IEnumerable<Game> GetAllGames { get; }

        // get all games on sale
        IEnumerable<Game> GetGamesOnSale { get; }

        //Get Game based on ID, pass int as a parameter
        Game GetGameById(int gameId);

        // interface is created, now we need to create our repositories to implement these Methods and Properties

    }
}
