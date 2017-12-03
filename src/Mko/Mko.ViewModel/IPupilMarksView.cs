using System;
using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IPupilMarksView : IView
    {
        event EventHandler<Pupil> CurrentPupilChanged;

        event EventHandler<Period> CurrentPeriodChanged;

        event EventHandler Save;

        IReadOnlyCollection<Pupil> Pupils { set; }

        IReadOnlyCollection<SubjectMark> Marks { set; }
    }
}