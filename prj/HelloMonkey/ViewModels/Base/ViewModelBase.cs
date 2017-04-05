using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloMonkey.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public bool busy;
        public string title;

        /// <summary>
        /// Titulo
        /// </summary>
        /// <value>O titulo.</value>
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Ocupado
        /// </summary>
        /// <value>bool</value>      
        public bool Busy
        {
            get { return busy; }
            set
            {
                busy = value;
                OnPropertyChanged();
            }
        }

        bool loading;
        public bool Loading
        {
            get { return loading; }
            set
            {
                loading = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModelBase(string title)
        {
            Title = title;
        }
    }
}
