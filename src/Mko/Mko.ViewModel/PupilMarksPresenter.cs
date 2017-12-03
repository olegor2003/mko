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
        private readonly HashSet<SubjectMark> _changedMarks;

        public IPupilMarksView View { get; }

        public PupilMarksPresenter(IPupilRepository pupilRepository, IPupilMarksView pupilView, IMarksRepository marksRepository, ISubjectRepository subjectRepository, Context context, ISaveService saveService)
        {
            _changedMarks = new HashSet<SubjectMark>();
            _marksRepository = marksRepository;
            _subjectRepository = subjectRepository;
            _context = context;
            _saveService = saveService;
            View = pupilView;
            View.CurrentPupilChanged += OnCurrentPupilChanged;
            View.Pupils = pupilRepository.GetPupils(context.CurrentYear.Id, context.CurrentGrade.Id).ToList();
            View.Save += OnSave;
        }

        private void OnSave(object sender, System.EventArgs e)
        {
            SaveChanges();
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

            _changedMarks.Clear();
            _observableSubjectMarks = new ObservableCollectionEx<SubjectMark>();
            _context.CurrentPupil = pupil;
            var subjects = _subjectRepository.GetSubjects(_context.CurrentGrade.Parallel);
            var marks = _marksRepository.GetMarksFor(pupil.Id, _context.CurrentPeriod, _context.CurrentYear.Id);
            var subjectMarks = subjects.Select(s => new SubjectMark(s, marks.FirstOrDefault(m => m.Subject.Id == s.Id)?.Value));
            _observableSubjectMarks.Clear();
            foreach (var sm in subjectMarks)
            {
                _observableSubjectMarks.Add(sm);
            }
            _observableSubjectMarks.CollectionChanged += OnCollectionChanged;
            View.Marks = null;
            View.Marks = _observableSubjectMarks;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var changesMark = e.NewItems[0] as SubjectMark;
            _changedMarks.Add(changesMark);
            _isDirty = true;
        }

        private void SaveChanges()
        {
            var marksToSave = new List<Mark>();
            foreach (var changedMark in _changedMarks)
            {
                var mark = _marksRepository
                            .GetMarksFor(_context.CurrentPupil.Id, _context.CurrentPeriod, _context.CurrentYear.Id)
                            .FirstOrDefault(m => m.Subject.Id == changedMark.SubjectId);

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
                marksToSave.Add(mark);
            }
            _saveService.SaveChanges(marksToSave.ToArray());

            _isDirty = false;
        }
    }
}
