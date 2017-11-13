using System;
using System.Windows.Forms;

namespace Mko.Shell
{
    public partial class SaveDialogForm : Form
    {
        public SaveDialogForm()
        {
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
    }
}
