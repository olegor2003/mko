using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.Infra.Repositories
{
    public interface IMarksRepository
    {
        IReadOnlyCollection<Mark> GetMarksFor(int pupilId, Periods period, int yearId);
    }
}