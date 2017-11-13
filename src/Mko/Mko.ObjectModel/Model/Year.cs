using System.Collections.Generic;

namespace Mko.ObjectModel.Model
{
    public class Year: BaseEntity, INameable
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        internal ICollection<SchoolYear> SchoolYears { get; set; }
    }
}