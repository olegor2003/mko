using System;
using System.Collections.Generic;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public interface IPeopleMarksView: IView
    {
        event EventHandler CurrentPupilCahnged;

        Pupil CurrentPupil { get; }

        IReadOnlyCollection<Pupil> Pupils { get; set; }
    }
}