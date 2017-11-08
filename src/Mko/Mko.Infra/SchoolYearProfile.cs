using System.Data.Entity.ModelConfiguration;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class SchoolYearProfile : EntityTypeConfiguration<SchoolYear>
    {
        public SchoolYearProfile()
        {
            HasRequired(sy => sy.Pupil)
                .WithMany(p => p.SchoolYears)
                .HasForeignKey(sy => sy.PupilId);

            HasRequired(sy => sy.Grade)
                .WithMany(g => g.SchoolYears)
                .HasForeignKey(sy => sy.GradeId);

            HasRequired(sy => sy.Year)
                .WithMany(y => y.SchoolYears)
                .HasForeignKey(sy => sy.YearId);
        }
    }
}