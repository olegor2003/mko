using System;
using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.Infra.Repositories
{
    public class YearsRepository : RepositoryBase, IYearsRepository
    {
        public YearsRepository(Func<MainDbContext> contextFactory) : base(contextFactory)
        {
        }

        public Year GetCurrentYear()
        {
            using (var context = _contextFactory())
            {
                return context.Years.SingleOrDefault(y => y.IsActive);
            }
        }

        public IReadOnlyCollection<Year> GetAllYears()
        {
            using (var context = _contextFactory())
            {
                return context.Years.ToList();
            }
        }
    }
}