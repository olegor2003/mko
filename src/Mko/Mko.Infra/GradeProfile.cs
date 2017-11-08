using System.Data.Entity.ModelConfiguration;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class GradeProfile : EntityTypeConfiguration<Grade>
    {
        public GradeProfile()
        {
            HasMany(g => g.SchoolYears);
        }
    }
}
