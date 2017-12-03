using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mko.ObjectModel.Model;
using Mko.ViewModel;

namespace Mko.Shell
{
    public partial class PupilMarksControl : UserControl, IPupilMarksView
    {
        private Pupil CurrentPupil => pupilBindingSource.Current as Pupil;

        public event EventHandler<Pupil> CurrentPupilChanged;

        public event EventHandler<Period> CurrentPeriodChanged;

        public event EventHandler Save;

        public PupilMarksControl()
        {
            InitializeComponent();
            pupilBindingSource.CurrentChanged += PupilBindingSourceCurrentChanged;
        }

        public IReadOnlyCollection<Pupil> Pupils
        {
            set
            {
                pupilBindingSource.DataSource = null;
                pupilBindingSource.DataSource = value;
            }
        }

        public IReadOnlyCollection<SubjectMark> Marks
        {
            set
            {
                subjectMarksBindingSource.DataSource = null;
                subjectMarksBindingSource.DataSource = value;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            var copy = Save;
            copy?.Invoke(this, new EventArgs());
        }

        private void PupilBindingSourceCurrentChanged(object sender, EventArgs e)
        {
            var copy = CurrentPupilChanged;
            copy?.Invoke(this, CurrentPupil);
        }
    }
}
