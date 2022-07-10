using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTraning.Services;

namespace WPFTraning.ViewModels.Base
{
    internal class GameInfoAbout
    {
        public GameInfo GameI {get; set;}

        public GameInfoAbout(GameInfo GameI)
        {
            this.GameI = GameI;
        }
    }
}
