using System.Collections.Generic;

namespace Mko.ObjectModel.Model
{
    public class Pupil: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{LastName} {FirstName}";

        internal virtual ICollection<SchoolYear> SchoolYears { get; set; }
    }
}
