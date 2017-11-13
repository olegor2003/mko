using System;
using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IShellView
    {
        event EventHandler<Year> YearChanged;

        event EventHandler<Grade> GradeChanged;

        IReadOnlyCollection<Year> Years { set; }

        IReadOnlyCollection<Grade> Grades { set; }

        void AddView(IView view);
    }
}