using System;
using System.Collections.ObjectModel;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;
using System.Windows.Forms;

namespace Mko.ViewModel
{
    public class PupilMarksPresenter
    {
        private readonly IPupilRepository _pupilRepository;
        private readonly IMarksRepository _marksRepository;
        private readonly Context _context;

        public IPeopleMarksView View { get; set; }

        public bool IsEditable { get; set; }

        public PupilMarksPresenter(IPupilRepository pupilRepository, IPeopleMarksView pupilView, IMarksRepository marksRepository, Context context)
        {
            IsEditable = true;
            _pupilRepository = pupilRepository;
            _marksRepository = marksRepository;
            _context = context;
            View = pupilView;
            View.CurrentPupilChanged += OnCurrentPupilChanged;
            View.Pupils = pupilRepository.GetYearPupils(context.CurrentYear.Id).ToList();
        }

        private void OnCurrentPupilChanged(object sender, Pupil pupil)
        {
            var marks = _marksRepository.GetMarksFor(pupil.Id, _context.CurrentPeriod, _context.CurrentYear.Id);
            var subjectMarks = new ObservableCollection<SubjectMark>(marks.Select(m => new SubjectMark(m)));
            View.Marks = subjectMarks;
        }
    }
}
