using System.Data.Entity.ModelConfiguration;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class MarkProfile : EntityTypeConfiguration<Mark>
    {
        public MarkProfile()
        {
            Property(m => m.Period).IsRequired();

            Property(m => m.Value).IsRequired();
        }
    }
}