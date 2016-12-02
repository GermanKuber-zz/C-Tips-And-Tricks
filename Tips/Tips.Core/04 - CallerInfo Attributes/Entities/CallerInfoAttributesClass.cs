using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tips.Entities
{
    public class CallerInfoAttributesClass : INotifyPropertyChanged
    {
        private int _age;
        private string _name;
        private string _information;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Information
        {
            get
            {
                return _information;
            }
            set
            {
                _information = value;
                OnPropertyChanged(nameof(Information));
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                var eventArgs = new PropertyChangedEventArgs(propertyName);

                PropertyChanged(this, eventArgs);
            }
        }
    }
}