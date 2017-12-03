using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public class Context
    {
        public Year CurrentYear { get; set; }

        // TODO implement
        public Period CurrentPeriod { get; set; } = Period.Start;

        public Grade CurrentGrade { get; set; }

        public Pupil CurrentPupil { get; set; }
    }
}