using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ObjectModel.Repositories
{
    public interface IGradeRepository
    {
        IReadOnlyCollection<Grade> GetGrades(int yearId);
    }
}