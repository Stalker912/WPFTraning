using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTraning.Services;

namespace WPFTraning.Models
{
    public class PsGameInfoDB
    {
        public ObservableCollection<GameInfo> GameInfoList { get; private set; }

        public PsGameInfoDB()
        {
            GameInfoList = new ObservableCollection<GameInfo>()
            {
                new GameInfo("Dota2", "Моба Игра", "Каждый раз зазный"),
                new GameInfo("CS", "Шутер", "Террарист или контр террарист"),
                new GameInfo("Шахматы", "Головоломка", "Белый или чёрный"),
                new GameInfo("MRG", "Преключение", "Raiden")
            };
        }
        
        public bool Remove(GameInfo GameI)
        {
            return GameInfoList.Remove(GameI);
        }
    }
}
