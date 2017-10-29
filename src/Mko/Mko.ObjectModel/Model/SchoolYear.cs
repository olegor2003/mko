using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mko.ObjectModel.Model
{
    public class SchoolYear
    {
        public int Id { get; set; }

        public int PupilId { get; set; }

        public int YearId { get; set; }

        public int GradeId { get; set; }
    }
}
