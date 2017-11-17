using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mko.ObjectModel.Model;
using Mko.ViewModel;

namespace Mko.Shell
{
    public partial class PupilMarksControl : UserControl, IPeopleMarksView
    {
        private Pupil CurrentPupil => pupilBindingSource.Current as Pupil;

        public PupilMarksControl()
        {
            InitializeComponent();
            pupilBindingSource.CurrentChanged += PupilBindingSourceCurrentChanged;
        }

        private void PupilBindingSourceCurrentChanged(object sender, EventArgs e)
        {
            var copy = CurrentPupilChanged;
            copy?.Invoke(this, CurrentPupil);
        }

        public event EventHandler<Pupil> CurrentPupilChanged;

        public IReadOnlyCollection<Pupil> Pupils
        {
            get
            {
                return pupilBindingSource.DataSource as IReadOnlyCollection<Pupil>;
            }
            set
            {
                pupilBindingSource.DataSource = null;
                pupilBindingSource.DataSource = value;
            }
        }

        public IReadOnlyCollection<SubjectMark> Marks
        {
            set { subjectMarksBindingSource.DataSource = value; }
        }

        public event EventHandler<Periods> CurrentPeriodChanged;
    }
}
