using System.Data.Entity.ModelConfiguration;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class PupulProfile : EntityTypeConfiguration<Pupil>
    {
        public PupulProfile()
        {
            Ignore(p => p.FullName);

            Property(p => p.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasMaxLength(256);

            Property(p => p.LastName)
               .IsRequired()
               .HasColumnName("LastName")
               .HasMaxLength(256);

            HasMany(p => p.SchoolYears);
        }
    }
}