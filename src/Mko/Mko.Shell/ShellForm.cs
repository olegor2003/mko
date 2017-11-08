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

        public ShellForm()
        {
            InitializeComponent();
            yearSelectorComboBox.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        public event EventHandler<Year> YearChanged;

        public void AddView(IView view)
        {
            panel1.Controls.Add(view as Control);
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var copy = YearChanged;
            copy?.Invoke(this, (Year)yearSelectorComboBox.SelectedItem);
        }

        public IReadOnlyCollection<Year> Years
        {
            set
            {
                yearSelector.Items.Clear();
                yearSelectorComboBox.DataSource = value;
                yearSelectorComboBox.DisplayMember = "Name";
                yearSelectorComboBox.ValueMember = "Id";
                yearSelector.SelectedIndex = -1;
            }
        }
    }
}
