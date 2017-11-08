using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ObjectModel.Repositories
{
    public interface IYearsRepository
    {
        Year GetCurrentYear();

        IReadOnlyCollection<Year> GetAllYears();
    }
}