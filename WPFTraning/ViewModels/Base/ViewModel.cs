using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WPFTraning.Services;

namespace WPFTraning.ViewModels.Base
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private int clicks;
        public int Clicks
        {
            get => clicks;
            set
            {
                clicks = value;
                OnPropertyChanged();
            }
        }

       public void Click()
       {
            Clicks++;
       }

        public ICommand ClickCommand
        {
            get
            {
                return new ActionCommand(() => { 
                    Click();
                    OnPropertyChanged("Click");
                });
            }
        }

        public ViewModel()
        {

        }

    }
}
