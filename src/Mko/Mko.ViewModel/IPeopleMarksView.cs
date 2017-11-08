using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IPeopleMarksView: IView
    {
        event EventHandler<Pupil> CurrentPupilCahnged;

        event EventHandler<Periods> CurrentPeriodCahnged;

        IReadOnlyCollection<Pupil> Pupils { get; set; }

        DialogResult ShowSaveMessage();
    }
}