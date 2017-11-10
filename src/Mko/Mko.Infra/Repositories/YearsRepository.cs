using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.Infra.Repositories
{
    public class YearsRepository : RepositoryBase, IYearsRepository
    {
        public YearsRepository(MainDbContext context) : base(context)
        {
        }

        public Year GetCurrentYear()
        {
            return _context.Years.SingleOrDefault(y => y.IsActive);
        }

        public IQueryable<Year> GetAllYears()
        {
            return _context.Years;
        }
    }
}