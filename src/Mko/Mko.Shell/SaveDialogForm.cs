using System;
using System.Windows.Forms;
using Mko.ViewModel;

namespace Mko.Shell
{
    public partial class SaveDialogForm : Form, ISaveView
    {
        private readonly ShellForm _shell;

        public SaveDialogForm(ShellForm shell)
        {
            _shell = shell;
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        public bool SaveConfirmed => ShowDialog(_shell) == DialogResult.Yes;
    }
}
