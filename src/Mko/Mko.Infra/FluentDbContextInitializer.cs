using System.Data.Entity;
using System.Linq;
using System.Reflection;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors;
using FluentMigrator.Runner.Processors.SqlServer;
using Mko.ObjectModel.Model;

namespace Mko.Infra
{
    public class FluentDbContextInitializer<T> : IDatabaseInitializer<T> where T : DbContext
    {
        public void InitializeDatabase(T context)
        {
            context.Database.CommandTimeout = 3600;
            var isNotExist = context.Database.CreateIfNotExists();
            if (isNotExist)
            {
                FillVersionInfoTable(context.Database.Connection.ConnectionString);
                SeedDb(context as MainDbContext);
            }
        }
        private void FillVersionInfoTable(string connectionString)
        {
            var announcer = new TextWriterAnnouncer(s => System.Diagnostics.Debug.WriteLine(s));
            var assembly = Assembly.GetExecutingAssembly();
            var migrationContext = new RunnerContext(announcer);
            var options = new ProcessorOptions { PreviewOnly = false, Timeout = 60 };
            var factory = new SqlServer2008ProcessorFactory();
            using (var processor = factory.Create(connectionString, announcer, options))
            {
                var runner = new MigrationRunner(assembly, migrationContext, processor);
                var versionLoader = runner.VersionLoader;
                foreach (var version in runner.MigrationLoader.LoadMigrations())
                {
                    var description = version.Value.Migration.ToString().Split('.').LastOrDefault();
                    versionLoader.UpdateVersionInfo(version.Key, description);
                }
                processor.CommitTransaction();
            }
        }

        private static void SeedDb(MainDbContext context)
        {
            context.Years.Add(new Year() { IsActive = true, Name = "2017-2018" });
            context.SaveChanges();
        }
    }
}