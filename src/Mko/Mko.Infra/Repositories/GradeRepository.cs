using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.Infra.Repositories
{
    public class GradeRepository : RepositoryBase, IGradeRepository
    {
        public GradeRepository(MainDbContext context) : base(context)
        {
        }

        public IReadOnlyCollection<Grade> GetGrades(int yearId)
        {
            return _context.Grades
                            .Where(g => g.SchoolYears.Any(sy => sy.YearId == yearId))
                            .ToList();
        }
    }
}