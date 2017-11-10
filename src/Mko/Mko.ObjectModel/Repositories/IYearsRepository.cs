using System.Linq;
using Mko.ObjectModel.Model;

namespace Mko.ObjectModel.Repositories
{
    public interface IYearsRepository
    {
        Year GetCurrentYear();

        IQueryable<Year> GetAllYears();
    }
}