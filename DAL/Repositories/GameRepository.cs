using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class GameRepository : EfCoreRepository<Game, AppDbContext>
    {
        public GameRepository(AppDbContext repoDbContext) : base(repoDbContext)
        {
        }

        public async Task<Game> GetGameByName(string name)
        {
            var query = PrepareQuery();
            var game = await query.FirstOrDefaultAsync(g => g.Name.Equals(name));
            return game;
        }

    }
}