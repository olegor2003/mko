using System.Collections.Generic;

namespace Mko.ObjectModel.Model
{
    public class Grade: BaseEntity, INameable
    {
        public string Letter { get; set; }
        
        public Parallel Parallel { get; set; }

        public string Name => $"{(int)Parallel}{Letter}";

        internal virtual ICollection<SchoolYear> SchoolYears { get; set; }
    }
}
