using System.ComponentModel;
using System.Runtime.CompilerServices;
using Mko.ObjectModel.Annotations;

namespace Mko.ObjectModel.Model
{
    public class Mark : BaseEntity
    {
        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        public int PupilId { get; set; }

        public int? Value { get; set; }

        public int YearId { get; set; }

        public Periods Period { get; set; }
    }
}