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
            var shell = new ShellForm();
            builder.RegisterInstance(shell).As<IShellView>();
            _container = builder.Build();
            var shellPresenter = _container.Resolve<ShellPresenter>();
            Application.Run(shell);
        }
    }
}
