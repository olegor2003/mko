using System;
using System.Linq;
using Autofac;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.ViewModel
{
    public class ShellPresenter
    {
        private readonly IShellView _shellView;
        private readonly IGradeRepository _gradeRepository;
        private readonly Func<PupilMarksPresenter> _pupilMarksPresenterFactory;
        private readonly Context _context;
        private PupilMarksPresenter _currentPupilMarksPresenter;

        public ShellPresenter(IShellView shellView, IYearsRepository yearsRepository, IGradeRepository gradeRepository, Func<PupilMarksPresenter> pupilMarksPresenterFactory, Context context)
        {
            _shellView = shellView;
            _gradeRepository = gradeRepository;
            _pupilMarksPresenterFactory = pupilMarksPresenterFactory;
            _context = context;
            _shellView.Years = yearsRepository.GetAllYears().ToList();
            _shellView.YearChanged += OnYearChanged;
            _shellView.GradeChanged += OnGradeChanged;
        }

        private void OnGradeChanged(object sender, Grade grade)
        {
            if (_context.CurrentGrade == grade)
            {
                return;
            }
            _context.CurrentGrade = grade;
            _currentPupilMarksPresenter = _pupilMarksPresenterFactory();
            _shellView.AddView(_currentPupilMarksPresenter.View);
        }

        private void OnYearChanged(object sender, Year year)
        {
            if (_context.CurrentYear == year)
            {
                return;
            }
            _context.CurrentYear = year;
            _shellView.Grades = _gradeRepository.GetGrades(year.Id);
        }
    }
}