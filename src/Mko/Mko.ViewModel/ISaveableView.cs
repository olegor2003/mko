using System.Windows.Forms;

namespace Mko.ViewModel
{
    public interface ISaveableView: IView
    {
        DialogResult Save();
    }
}