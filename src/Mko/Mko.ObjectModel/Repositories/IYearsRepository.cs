using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;

namespace Mko.ObjectModel.Repositories
{
    public interface IYearsRepository
    {
        Year GetCurrentYear();

        IReadOnlyCollection<Year> GetAllYears();
    }
}