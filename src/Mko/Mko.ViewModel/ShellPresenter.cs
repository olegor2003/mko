using Autofac;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.ViewModel
{
    public class ShellPresenter
    {
        private readonly IContainer _container;
        private readonly IShellView _shellView;
        private readonly Context _context;

        public ShellPresenter(IContainer container, IShellView shellView, Context context)
        {
            _container = container;
            _shellView = shellView;
            _context = context;
            var yearsRepository = container.Resolve<IYearsRepository>();
            shellView.Years = yearsRepository.GetAllYears();
            _shellView.YearChanged += OnYearChanged;
        }

        private void OnYearChanged(object sender, Year year)
        {
            if (_context.CurrentYear == year)
            {
                return;
            }
            _context.CurrentYear = year;
            var pupilMarksPresenter = _container.Resolve<PupilMarksPresenter>();
            _shellView.AddView(pupilMarksPresenter.View);
        }
    }
}