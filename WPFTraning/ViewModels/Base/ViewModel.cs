using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WPFTraning.Services;
using WPFTraning.ViewModels.IBase;
using WPFTraning.Views.Windows;
using System.Linq;
using WPFTraning.Models;

namespace WPFTraning.ViewModels.Base
{
    class ViewModel : IViewModel, INotifyPropertyChanged 
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

        public ViewModel()
        {
            GameInfoList = new PsGameInfoDB();
        }

        private PsGameInfoDB gameInfoList;

        private GameInfo gridSelectedItem;

        public PsGameInfoDB GameInfoList {
            get { 
                return gameInfoList;
            }
            
            set {
                if(value != gameInfoList)
                {
                    gameInfoList = value;
                    OnPropertyChanged("GameInfoList");
                }
            } 
        }

        public GameInfo GridSelectedItem
        {
            get
            {
                return gridSelectedItem;
            }
            set
            {
                if(value != null)
                {
                    gridSelectedItem = value;
                    OnPropertyChanged("GridSelectedItem");
                }
                                 
            }
        }

        public void Delete() {
            if (gridSelectedItem != null)
            {
                GameInfoList.Remove(gridSelectedItem);
                OnPropertyChanged("GameInfoList");
            }
        }

        public void LineDoubleClick()
        {
            var VAGI = new AboutGameInfo(gridSelectedItem);
            VAGI.Show();
        }

        public void CreateAddNewGameInfoWindow()
        {
            var NewWindow = new AddNewGameWindow(gameInfoList.GameInfoList.Add);
            NewWindow.Show();
        }

        #region Commands
        public ICommand DeleteCommand
        {
            get
            {
                return new ActionCommand(() =>
                {
                    Delete();
                });
            }
        }

        public ICommand AddNewGameInfoWindowCommand
        {
            get
            {
                return new ActionCommand(() =>
                {
                    CreateAddNewGameInfoWindow();
                });
            }
        }

        #endregion
    }
}
