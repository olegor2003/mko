using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using Mko.Infra;
using Mko.ObjectModel.Model;
using Mko.ViewModel;

namespace Mko.Shell
{
    static class Program
    {
        private static IContainer _container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            _container = builder.Build();
            SeedDb();
            var shell = new ShellForm();
            var context = _container.Resolve<Context>();
            var shellPresenter = new ShellPresenter(_container, shell, context);
            Application.Run(shell);
        }

        private static void SeedDb()
        {
            var context = _container.Resolve<MainDbContext>();
            context.Years.Add(new Year() { IsActive = true, Name = "2017-2018" });
            context.SaveChanges();
        }
    }
}
