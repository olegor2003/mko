using System;
using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.Infra.Repositories
{
    public class PupilRepository : IPupilRepository
    {
        private readonly Func<MainDbContext> _contextFactory;

        public PupilRepository(Func<MainDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
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
    }
}