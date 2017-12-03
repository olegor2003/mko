using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.Infra.Repositories
{
    public class SubjectRepository : RepositoryBase, ISubjectRepository
    {
        public SubjectRepository(MainDbContext context) : base(context)
        {
        }

        public IReadOnlyCollection<Subject> GetSubjects(Parallel parallel)
        {
            return _context.Subjects.Where(s => s.Parallel == parallel).ToList();
        }
    }
}