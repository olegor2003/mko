using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mko.ObjectModel.Model;
using Mko.ViewModel;

namespace Mko.Shell
{
    public partial class ShellForm : Form, IShellView
    {
        private ComboBox yearSelectorComboBox => yearSelector.ComboBox;
        private ComboBox gradeSelectorComboBox => gradeSelector.ComboBox;

        public ShellForm()
        {
            InitializeComponent();
            yearSelectorComboBox.SelectedIndexChanged += OnSelectedIndexOfYearsChanged;
            gradeSelectorComboBox.SelectedIndexChanged += OnSelectedIndexOfGradesChanged;
        }


        public event EventHandler<Year> YearChanged;

        public event EventHandler<Grade> GradeChanged;

        public void AddView(IView view)
        {
            panel1.Controls.Add(view as Control);
        }

        private void OnSelectedIndexOfYearsChanged(object sender, EventArgs e)
        {
            var copy = YearChanged;
            copy?.Invoke(this, (Year)yearSelectorComboBox.SelectedItem);
        }

        private void OnSelectedIndexOfGradesChanged(object sender, EventArgs e)
        {
            var copy = GradeChanged;
            copy?.Invoke(this, (Grade)gradeSelectorComboBox.SelectedItem);
        }

        public IReadOnlyCollection<Year> Years
        {
            set
            {
                yearSelector.Items.Clear();
                InitValue(yearSelectorComboBox, value);
            }
        }

        public IReadOnlyCollection<Grade> Grades
        {
            set
            {
                gradeSelector.Items.Clear();
                InitValue(gradeSelectorComboBox, value, false);
            }
        }

        private void InitValue(ComboBox cb, IReadOnlyCollection<INameable> dataSource, bool resetIndex = true)
        {
            cb.DataSource = dataSource;
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
            if (resetIndex)
            {
                cb.SelectedIndex = -1;
            }
        }
    }
}
