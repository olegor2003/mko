using System.Collections.Generic;

namespace Mko.ObjectModel.Model
{
    public class Grade: BaseEntity, INameable
    {
        public string Letter { get; set; }
        
        public int Parallel { get; set; }

        public string Name => $"{Parallel}{Letter}";

        internal ICollection<SchoolYear> SchoolYears { get; set; }
    }
}
