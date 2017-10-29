using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using Mko.ViewModel;

namespace Mko.Shell
{
    static class Program
    {
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
            var container = builder.Build();
            var shell = new ShellForm();
            var shellPresenter = new ShellPresenter(container, shell);
            Application.Run(shell);
        }
    }
}
