using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class MainDbContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }

        public DbSet<Pupil> Pupils { get; set; }

        public DbSet<SchoolYear> SchoolYears { get; set; }

        public DbSet<Year> Yeares { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
