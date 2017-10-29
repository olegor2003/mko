using Autofac;
using Mko.ObjectModel.Model;

namespace Mko.ViewModel
{
    public class ShellPresenter
    {
        private readonly IContainer _container;
        private readonly IShellView _shellView;

        public ShellPresenter(IContainer container, IShellView shellView)
        {
            _container = container;
            _shellView = shellView;
            _shellView.YearChanged += OnYearChanged;
        }

        private void OnYearChanged(object sender, System.EventArgs e)
        {
            var pupilMarksPresenter = _container.Resolve<PupilMarksPresenter>();
            _shellView.AddView(pupilMarksPresenter.View);
        }

        public Year CurrentYear { get; set; }
    }
}