using System.Collections.Generic;

namespace Mko.ObjectModel.Model
{
    public class Grade
    {
        public int Id { get; set; }

        public string Letter { get; set; }

        public int Parallel { get; set; }

        internal ICollection<SchoolYear> SchoolYears { get; set; }
    }
}
