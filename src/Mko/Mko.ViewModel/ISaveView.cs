using System;

namespace Mko.ViewModel
{
    public interface ISaveView: IDisposable
    {
        bool SaveConfirmed { get; }
    }
}