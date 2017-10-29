using System;
using System.ComponentModel;
using System.Windows.Forms;
using Mko.ViewModel;

namespace Mko.Shell
{
    public partial class ShellForm : Form, IShellView
    {
        public ShellForm()
        {
            InitializeComponent();
            this.yearSelector.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        public event EventHandler YearChanged;

        public void AddView(IView view)
        {
            panel1.Controls.Add(view as Control);
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var copy = YearChanged;
            copy?.Invoke(this, new EventArgs());
        }
    }
}
