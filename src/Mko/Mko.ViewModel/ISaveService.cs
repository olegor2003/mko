using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface ISaveService
    {
        void SaveChanges<T>(T[] values, bool force = false) where T : BaseEntity;
    }
}