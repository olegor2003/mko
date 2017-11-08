using System.Data.Entity;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class MainDbContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }

        public DbSet<Pupil> Pupils { get; set; }

        public DbSet<SchoolYear> SchoolYears { get; set; }

        public DbSet<Year> Years { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Mark> Marks { get; set; }

        public MainDbContext()
        {
            Init();
        }

        public MainDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Init();
        }

        private void Init()
        {
            Database.SetInitializer(new FluentDbContextInitializer<MainDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new GradeProfile());
            modelBuilder.Configurations.Add(new PupulProfile());
            modelBuilder.Configurations.Add(new SchoolYearProfile());
            modelBuilder.Configurations.Add(new YearProfile());
            modelBuilder.Configurations.Add(new MarkProfile());
        }
    }
}
