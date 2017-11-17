using Autofac;
using Mko.Infra;
using Mko.Infra.Repositories;
using Mko.ObjectModel.Repositories;
using Mko.ViewModel;

namespace Mko.Shell.ModulesProfile
{
    public class EntityModule : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder
                .RegisterType<PupilRepository>()
                .As<IPupilRepository>();

            moduleBuilder
                .RegisterType<YearsRepository>()
                .As<IYearsRepository>();

            moduleBuilder
                .RegisterType<PupilMarksControl>()
                .As<IPeopleMarksView>();

            moduleBuilder
                .RegisterType<GradeRepository>()
                .As<IGradeRepository>();

            moduleBuilder
                .RegisterType<MarksRepository>()
                .As<IMarksRepository>();

            moduleBuilder
                .RegisterType<ShellPresenter>();

            moduleBuilder
                .RegisterType<PupilMarksPresenter>();

            moduleBuilder
                .RegisterType<MainDbContext>()
                .SingleInstance();

            moduleBuilder
                .RegisterType<Context>()
                .SingleInstance();

            moduleBuilder
                .RegisterType<SaveService>()
                .As<ISaveService>();

            moduleBuilder
                .RegisterType<SaveDialogForm>()
                .As<ISaveView>();
        }
    }
}