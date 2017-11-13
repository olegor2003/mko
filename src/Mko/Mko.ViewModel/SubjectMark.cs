using System.ComponentModel;
using System.Runtime.CompilerServices;
using Mko.ObjectModel.Model;
using Mko.ViewModel.Annotations;

namespace Mko.ViewModel
{
    public class SubjectMark : INotifyPropertyChanged
    {
        private readonly Mark _mark;

        public SubjectMark(Mark mark)
        {
            _mark = mark;
        }

        public int MarkId => _mark.Id;

        public int SubjectId => _mark.Subject.Id;

        public string Subject => _mark.Subject.ShortName;

        public int? Value { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}