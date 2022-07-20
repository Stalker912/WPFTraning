using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFTraning.Services;

namespace WPFTraning.ViewModels.Base
{
    public class VM_AddNewInfoAboutGame : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

        private Action<GameInfo> AddToAction
        {
            get;
            set;
        }

        private Action Close
        {
            get;
            set;
        }

        private GameInfo newGameInfo = new GameInfo("", "", "");
        

        public GameInfo NewGameInfo { 
            get {
                return newGameInfo;
            } 
            set {
                if (value != newGameInfo && value != null)
                    newGameInfo = value;
            } }

        public VM_AddNewInfoAboutGame()
        {
        }

        public VM_AddNewInfoAboutGame(Action<GameInfo> AddToAction, Action CloseWindow)
        {
            this.AddToAction += AddToAction;
            this.Close = CloseWindow;
        }

        public bool FullInfoCorrect()
        {
            if (NewGameInfo.Name != String.Empty && NewGameInfo.About != String.Empty && NewGameInfo.MainHero != String.Empty)
                return true;
            else
                return false;
        }

        public void AddNewGameTolist()
        {
            AddToAction(NewGameInfo);
            Close();
        }

        public ICommand AddNewGameTolistCommand
        {
            get
            {
                return new ActionCommand(() =>
                {
                    AddNewGameTolist();
                });
            }
        }
    }
}
