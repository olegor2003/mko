using System;
using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IPeopleMarksView: IView
    {
        event EventHandler<Pupil> CurrentPupilChanged;

        event EventHandler<Periods> CurrentPeriodChanged;

        IReadOnlyCollection<Pupil> Pupils { get; set; }

        IReadOnlyCollection<SubjectMark> Marks { set; }
    }
}