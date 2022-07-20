using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTraning.Services
{
    public class GameInfo
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

        //public static bool operator == (GameInfo a, GameInfo b)
        //{
        //    if (a == null && b == null) return true;
        //    else
        //    {
        //        if (a.Name == b.Name && a.About == b.About && a.MainHero == b.MainHero) return true;
        //        else return false;
        //    }
            
        //}

        //public static bool operator != (GameInfo a, GameInfo b)
        //{
        //    return !(a == b);
        //}
    }
}
