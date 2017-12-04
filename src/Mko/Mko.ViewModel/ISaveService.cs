using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface ISaveService
    {
        void SaveChanges<T>(IEnumerable<T> values, bool force = false) where T : BaseEntity;
    }
}