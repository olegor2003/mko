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
                .RegisterType<PupilMarksControl>()
                .As<IPeopleMarksView>();

            moduleBuilder
                .RegisterType<PupilMarksPresenter>();

            moduleBuilder
                .RegisterType<MainDbContext>();
        }
    }
}