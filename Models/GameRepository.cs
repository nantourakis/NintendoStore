using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class GameRepository : IGameRepository
    {

        // link each Game to their respective Category as a private variable
        //gives us access to category repository / Replaced with OUR DB
        // private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        // set up our DB and then inject it into our constructor to use it
        private readonly AppDbContext _appDbContext;

        public GameRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Game> GetAllGames 
        {
            //acces the db, return all games and include the category
            get
            {
                return _appDbContext.Games.Include(c => c.Category);
            }
        }
        public IEnumerable<Game> GetGamesOnSale
        {
            //return all the games/categories of the ones on sale
            get
            {
                return _appDbContext.Games.Include(c => c.Category).Where(p => p.IsonSale);
            }
        }

        public Game GetGameById(int gameId)
        {

            // return all games then filter it down to match the specific game ID
            // compare property GameId to the gameid that's passed through, find it if there's a match
            return _appDbContext.Games.FirstOrDefault(g => g.GameId == gameId);
        }
    }
}
