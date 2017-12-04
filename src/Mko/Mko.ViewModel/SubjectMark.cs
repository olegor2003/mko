using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Mko.ObjectModel.Model;
using Mko.ViewModel.Annotations;

namespace Mko.ViewModel
{
    public class SubjectMark : INotifyPropertyChanged
    {
        private readonly Subject _subject;
        private int? _value;

        public SubjectMark(Subject subject, int? value)
        {
            _subject = subject;
            _value = value;
        }

        public int SubjectId => _subject.Id;

        public string Subject => _subject.ShortName;

        public int? Value
        {
            get
            {
                return _value;
            }
            set
            {
                SetField(ref _value, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(value, default(T)))
            {
                throw new ValidationException("Пустое значение не допустимо!");
            }
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }
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