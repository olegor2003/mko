using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ObjectModel.Repositories
{
    public interface IMarksRepository
    {
        IReadOnlyCollection<Mark> GetMarksFor(int pupilId, Period period, int yearId);
    }
}