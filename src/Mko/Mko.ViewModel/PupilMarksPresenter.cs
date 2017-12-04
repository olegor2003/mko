using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;

namespace Mko.ViewModel
{
    public class PupilMarksPresenter
    {
        private readonly IMarksRepository _marksRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly Context _context;
        private readonly ISaveService _saveService;
        private bool _isDirty = false;
        private ObservableCollectionEx<SubjectMark> _observableSubjectMarks;
        private HashSet<SubjectMark> _changedMarks;
        private IReadOnlyCollection<Subject> _subjects;
        private IReadOnlyCollection<Mark> _pupilMarks;

        public IPupilMarksView View { get; }

        public PupilMarksPresenter(IPupilRepository pupilRepository, IPupilMarksView pupilView, IMarksRepository marksRepository, ISubjectRepository subjectRepository, Context context, ISaveService saveService)
        {
            _marksRepository = marksRepository;
            _subjectRepository = subjectRepository;
            _context = context;
            _saveService = saveService;
            _subjects = _subjectRepository.GetSubjects(_context.CurrentGrade.Parallel);
            View = pupilView;
            View.CurrentPupilChanged += OnCurrentPupilChanged;
            View.Pupils = pupilRepository.GetPupils(context.CurrentYear.Id, context.CurrentGrade.Id);
            View.Save += OnSave;
        }

        private void OnSave(object sender, System.EventArgs e)
        {
            SaveChanges(true);
        }

        private void OnCurrentPupilChanged(object sender, Pupil pupil)
        {
            if (_context.CurrentPupil == pupil)
            {
                return;
            }

            if (_isDirty)
            {
                SaveChanges();
            }

            Prepare(pupil);
        }

        private void Prepare(Pupil pupil)
        {
            _context.CurrentPupil = pupil;

            _changedMarks = new HashSet<SubjectMark>();
            _observableSubjectMarks = new ObservableCollectionEx<SubjectMark>();

            var subjectMarks = GetSubjectMarks();
            foreach (var sm in subjectMarks)
            {
                _observableSubjectMarks.Add(sm);
            }
            _observableSubjectMarks.CollectionChanged += OnCollectionChanged;
            View.Marks = _observableSubjectMarks;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var changesMark = e.NewItems[0] as SubjectMark;
            _changedMarks.Add(changesMark);
            _isDirty = true;
        }

        private IEnumerable<SubjectMark> GetSubjectMarks()
        {
            _pupilMarks = _marksRepository.GetMarksFor(_context.CurrentPupil.Id, _context.CurrentPeriod, _context.CurrentYear.Id).ToList();
            return _subjects.Select(s => new SubjectMark(s, _pupilMarks.FirstOrDefault(m => m.Subject.Id == s.Id)?.Value)).OrderBy(s => s.Subject);
        }

        private void SaveChanges(bool force = false)
        {
            var marksToSave = from subjectMark in _changedMarks
                              join mark in _pupilMarks on subjectMark.SubjectId equals mark.SubjectId into j
                              from x in j.DefaultIfEmpty()
                              select x == null
                                  ? new Mark
                                  {
                                      SubjectId = subjectMark.SubjectId,
                                      Period = _context.CurrentPeriod,
                                      PupilId = _context.CurrentPupil.Id,
                                      YearId = _context.CurrentYear.Id,
                                      Value = subjectMark.Value
                                  }
                                  : Update(x, subjectMark.Value);

            _saveService.SaveChanges(marksToSave, force);

            _isDirty = false;
        }

        private static Mark Update(Mark mark, int? value)
        {
            mark.Value = value;
            return mark;
        }
    }
}
