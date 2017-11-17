using System.Collections.Generic;
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
        private readonly ISaveService _saveService;
        private bool isDirty = false;
        private readonly ObservableCollectionEx<SubjectMark> _observableSubjectMarks = new ObservableCollectionEx<SubjectMark>();
        private readonly HashSet<SubjectMark> _changedMarks = new HashSet<SubjectMark>();

        public IPeopleMarksView View { get; set; }

        public bool IsEditable { get; set; }

        public PupilMarksPresenter(IPupilRepository pupilRepository, IPeopleMarksView pupilView, IMarksRepository marksRepository, Context context, ISaveService saveService)
        {
            IsEditable = true;
            _pupilRepository = pupilRepository;
            _marksRepository = marksRepository;
            _context = context;
            _saveService = saveService;
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

            if (isDirty)
            {
                SaveChanges();
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
            _observableSubjectMarks.Clear();
            foreach (var sm in subjectMarks)
            {
                _observableSubjectMarks.Add(sm);
            }
            _observableSubjectMarks.CollectionChanged += OnCollectionChanged;
            View.Marks = null;
            View.Marks = _observableSubjectMarks;
        }

        private void OnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var changesMark = e.NewItems[0] as SubjectMark;
            _changedMarks.Add(changesMark);

            isDirty = true;
        }

        private void SaveChanges()
        {
            var changedMark = _changedMarks.First();
            var mark = _marksRepository.GetMarksFor(_context.CurrentPupil.Id, _context.CurrentPeriod, _context.CurrentYear.Id).FirstOrDefault(m => m.Subject.Id == changedMark.SubjectId);
            
            if (mark == null)
            {
                mark = new Mark
                {
                    SubjectId = changedMark.SubjectId,
                    Period = _context.CurrentPeriod,
                    PupilId = _context.CurrentPupil.Id,
                    YearId = _context.CurrentYear.Id,
                    Value = changedMark.Value
                };
            }
            else
            {
                mark.Value = changedMark.Value;
            }
            _saveService.SaveChanges(new[] { mark });
            isDirty = false;
        }
    }
}
