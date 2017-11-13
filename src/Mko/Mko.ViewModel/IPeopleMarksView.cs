using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IPeopleMarksView : ISaveableView
    {
        event EventHandler<Pupil> CurrentPupilChanged;

        event EventHandler<Periods> CurrentPeriodChanged;

        IReadOnlyCollection<Pupil> Pupils { get; set; }

        IReadOnlyCollection<SubjectMark> Marks { set; }
    }
}