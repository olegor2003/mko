using System.Data.Entity.ModelConfiguration;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class YearProfile : EntityTypeConfiguration<Year>
    {
        public YearProfile()
        {
            HasMany(y => y.SchoolYears);
        }
    }
}