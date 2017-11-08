using System.ComponentModel;
using System.Runtime.CompilerServices;
using Mko.ViewModel.Annotations;

namespace Mko.ViewModel
{
    public class SubjectMark : INotifyPropertyChanged
    {
        public SubjectMark()
        {
            
        }

        public int MarkId { get; set; }

        public int SubjectId { get; set; }

        public string Subject { get; set; }

        public int? Value { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}