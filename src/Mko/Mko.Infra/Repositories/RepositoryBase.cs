namespace Mko.Infra.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly MainDbContext _context;

        protected RepositoryBase(MainDbContext context)
        {
            this._context = context;
        }
    }
}