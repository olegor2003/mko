using System;

namespace Mko.Infra.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly Func<MainDbContext> _contextFactory;

        protected RepositoryBase(Func<MainDbContext> contextFactory)
        {
            this._contextFactory = contextFactory;
        }
    }
}