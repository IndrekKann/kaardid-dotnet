using Domain;

namespace DAL.Repositories
{
    public class ActiveGameRepository : EfCoreRepository<ActiveGame, AppDbContext>
    {
        
        public ActiveGameRepository(AppDbContext repoDbContext) : base(repoDbContext)
        {
        }
        
    }
}