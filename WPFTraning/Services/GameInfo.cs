using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraning.Services
{
    internal class GameInfo
    {
       // public int id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string MainHero { get; set; }

        public GameInfo()
        {
            Name = "None";
            About = "None";
            MainHero = "None";
        }

        public GameInfo(string Name, string About, string MainHero)
        {
            this.Name = Name;
            this.About = About;
            this.MainHero = MainHero;
        }
    }
}
