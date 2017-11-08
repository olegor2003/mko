using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public class Context
    {
        public Year CurrentYear { get; set; }

        public Periods CurrentPeriod { get; set; }

        public Grade CurrentGrade { get; set; }
    }
}