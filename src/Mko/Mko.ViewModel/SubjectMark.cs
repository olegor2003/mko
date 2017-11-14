using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Mko.ObjectModel.Model;
using Mko.ViewModel.Annotations;

namespace Mko.ViewModel
{
    public class SubjectMark : INotifyPropertyChanged
    {
        private readonly Mark _mark;
        private readonly Subject _subject;
        private int? val;

        public SubjectMark(Subject subject, Mark mark)
        {
            _subject = subject;
            _mark = mark;
            if (mark != null)
            {
                val = mark.Value;
            }
        }

        public int SubjectId => _subject.Id;

        public string Subject => _subject.ShortName;

        public int? Value
        {
            get { return val; }
            set
            {
                SetField(ref val, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}