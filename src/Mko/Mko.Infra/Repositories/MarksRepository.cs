using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.Infra.Repositories
{
    public class MarksRepository: RepositoryBase, IMarksRepository
    {
        public MarksRepository(MainDbContext context) : base(context)
        {
        }

        public IReadOnlyCollection<Mark> GetMarksFor(int pupilId, Periods period, int yearId)
        {
            return _context.Marks
                            .Where(m => m.PupilId == pupilId && m.Period == period && m.YearId == yearId)
                            .ToList();
        }
    }
}