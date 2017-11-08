using System;
using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IShellView
    {
        event EventHandler<Year> YearChanged;

        IReadOnlyCollection<Year> Years { set; }

        void AddView(IView view);
    }
}