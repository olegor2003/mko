using System;
using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;
using System.Data.Entity;

namespace Mko.Infra.Repositories
{
    public class PupilRepository : RepositoryBase, IPupilRepository
    {
        public PupilRepository(Func<MainDbContext> contextFactory) : base(contextFactory)
        {
        }

        public IReadOnlyCollection<Pupil> GetActiveYearPupils()
        {
            using (var context = _contextFactory())
            {
                return context.Pupils.AsNoTracking().ToList();
            }
        }

        public void AddPupul(Pupil pupil)
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

        public IReadOnlyCollection<Pupil> GetYearPupils(int yearId)
        {
            using (var context = _contextFactory())
            {
                return context
                            .Pupils
                            .Where(p => p.SchoolYears.Any(sy => sy.YearId == yearId))
                            .ToList();
            }
        }
    }
}