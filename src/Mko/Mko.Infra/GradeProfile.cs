﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class GradeProfile : EntityTypeConfiguration<Grade>
    {
        public GradeProfile()
        {
            
        }
    }
}
