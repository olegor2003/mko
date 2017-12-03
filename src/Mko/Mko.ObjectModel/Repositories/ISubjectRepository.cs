using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ObjectModel.Repositories
{
    public interface ISubjectRepository
    {
        IReadOnlyCollection<Subject> GetSubjects(Parallel parallel);
    }
}