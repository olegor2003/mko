using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Mko.ObjectModel.Model
{
    public class Grade
    {
        public int Id { get; set; }

        public string Letter { get; set; }

        public int Parallel { get; set; }
    }
}
