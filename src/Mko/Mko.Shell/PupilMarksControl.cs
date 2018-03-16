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

        public event EventHandler OnSaveClicked;

        public event EventHandler<Period> CurrentPeriodChanged;


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

        public bool SaveEnabled
        {
            set
            {
                btnSave.Enabled = value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var handler = OnSaveClicked;
            handler?.Invoke(this, new EventArgs());
        }

        private void PupilBindingSourceCurrentChanged(object sender, EventArgs e)
        {
            var handler = CurrentPupilChanged;
            handler?.Invoke(this, CurrentPupil);
        }

        private void rbStartPeriod_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                int periodNumber = int.Parse(rb.Tag.ToString());
                var handler = CurrentPeriodChanged;
                handler?.Invoke(this, (Period)periodNumber);
            }
        }
    }
}
