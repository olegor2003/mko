using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

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
            if (_context.CurrentPupil == pupil)
            {
                return;
            }

            _context.CurrentPupil = pupil;
            var subject = new List<Subject>()
            {
                new Subject() {Id = 1, ShortName = "Математика", Parallel = Parallel.First, FullName = "Математика"},
                new Subject() {Id = 2, ShortName = "Рус-яз", Parallel = Parallel.First, FullName = "Рус-яз"},
                new Subject() {Id = 3, ShortName = "Чтение", Parallel = Parallel.First, FullName = "Чтение"},
                new Subject() {Id = 4, ShortName = "Физ-ра", Parallel = Parallel.First, FullName = "Физ-ра"}
            };
            var marks = _marksRepository.GetMarksFor(pupil.Id, _context.CurrentPeriod, _context.CurrentYear.Id);
            var subjectMarks = subject.Select(s => new SubjectMark(s, marks.FirstOrDefault(m => m.Subject.Id == s.Id)));
            var observable = new ObservableCollectionEx<SubjectMark>();
            foreach (var sm in subjectMarks)
            {
                observable.Add(sm);
            }
            observable.CollectionChanged += Observable_CollectionChanged;
            View.Marks = observable;
        }

        private void Observable_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}
