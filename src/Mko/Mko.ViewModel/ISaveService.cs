using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface ISaveService
    {
        void SaveChanges<T>(T[] values) where T : BaseEntity;
    }
}