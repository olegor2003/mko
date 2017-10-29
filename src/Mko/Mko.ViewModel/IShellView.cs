using System;

namespace Mko.ViewModel
{
    public interface IShellView
    {
        event EventHandler YearChanged;

        void AddView(IView view);
    }
}