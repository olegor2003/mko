using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.Infra.Repositories
{
    public class PupilRepository : RepositoryBase, IPupilRepository
    {
        public PupilRepository(MainDbContext contextFactory) : base(contextFactory)
        {
        }

        public void AddPupil(Pupil pupil)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePupil(int id)
        {
            throw new System.NotImplementedException();
        }

        public Pupil UpdatePupil(Pupil pupil)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Pupil> GetPupils(int yearId, int gradeId)
        {
            return _context
                    .Pupils
                    .Where(p => p.SchoolYears.Any(sy => sy.YearId == yearId && sy.GradeId == gradeId));
        }
    }
}