using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WPFTraning.Services;
using WPFTraning.ViewModels.IBase;
using WPFTraning.Views.Windows;

namespace WPFTraning.ViewModels.Base
{
    class ViewModel : IViewModel, INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }

        public List<GameInfo> GameInfoList { get; set; }

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }


        private void Delete(int id) {
            GameInfoList.Remove(GameInfoList[id]);
        }

        public ICommand ClickCommand
        {
            get
            {
                return new ActionCommand(() => {
                    if(Id != -1) Delete(Id);
                    OnPropertyChanged("Click");
                });
            }
        }

        public void CreateGameInfoView(GameInfo InfoAboutGame)
        {
            
        }

        public ViewModel()
        {
            Id = -1;
            GameInfoList = new List<GameInfo>();
            int id = -1;
            GameInfoList.Add(new GameInfo("Dota2", "Моба Игра", "Каждый раз зазный"));
            GameInfoList.Add(new GameInfo("CS", "Шутер", "Террарист или контр террарист"));
            GameInfoList.Add(new GameInfo("Шахматы", "Головоломка", "Белый или чёрный"));
            GameInfoList.Add(new GameInfo("MRG", "Преключение", "Raiden"));
        }

    }
}
