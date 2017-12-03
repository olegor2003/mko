using System;
using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IPupilMarksView: IView
    {
        event EventHandler<Pupil> CurrentPupilChanged;

        event EventHandler<Periods> CurrentPeriodChanged;

        event EventHandler Save;

        IReadOnlyCollection<Pupil> Pupils { get; set; }

        IReadOnlyCollection<SubjectMark> Marks { set; }
    }
}