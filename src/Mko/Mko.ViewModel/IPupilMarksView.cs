using System;
using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IPupilMarksView : IView
    {
        event EventHandler<Pupil> CurrentPupilChanged;

        event EventHandler OnSaveClicked;

        event EventHandler<Period> CurrentPeriodChanged;

        IReadOnlyCollection<Pupil> Pupils { set; }

        IReadOnlyCollection<SubjectMark> Marks { set; }

        bool SaveEnabled { set; }
    }
}