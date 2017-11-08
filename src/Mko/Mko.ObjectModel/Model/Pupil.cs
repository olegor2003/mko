using System.Collections.Generic;

namespace Mko.ObjectModel.Model
{
    public class Pupil: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        internal ICollection<SchoolYear> SchoolYears { get; set; }
    }
}
