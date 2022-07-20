using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFTraning.Services;

namespace WPFTraning.ViewModels.Base
{
    internal class GameInfoAbout : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

        protected GameInfo gameI;

        internal Action? Close;

        public GameInfo GameI { 
            get{ return gameI; }
            set { 
                if(value != null)
                {
                    gameI = value;
                    OnPropertyChanged("GameI");
                }
            }
        }

        public GameInfoAbout()
        {
            this.gameI = new GameInfo("None", "None", "None");
        }

        public GameInfoAbout(GameInfo? GameI)
        {
            if (GameI == null)
                this.gameI = new GameInfo("None", "None", "None");
            else this.gameI = GameI;
        }


    }
}
