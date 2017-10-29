using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mko.ObjectModel.Model;
using Mko.ViewModel;

namespace Mko.Shell
{
    public partial class PupilMarksControl : UserControl, IPeopleMarksView
    {
        public PupilMarksControl()
        {
            InitializeComponent();
            pupilBindingSource.CurrentChanged += PupilBindingSourceCurrentChanged;
        }

        private void PupilBindingSourceCurrentChanged(object sender, EventArgs e)
        {
            var copy = CurrentPupilCahnged;
            copy?.Invoke(this, new EventArgs());
        }

        public event EventHandler CurrentPupilCahnged;

        public Pupil CurrentPupil => pupilBindingSource.Current as Pupil;

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
    }
}
