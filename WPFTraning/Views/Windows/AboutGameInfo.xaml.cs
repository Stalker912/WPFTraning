using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFTraning.Services;
using WPFTraning.ViewModels.Base;
using WPFTraning.ViewModels.IBase;

namespace WPFTraning.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AboutGameInfo.xaml
    /// </summary>
    public partial class AboutGameInfo : Window
    {
        public AboutGameInfo(GameInfo? gameInfo = null)
        {
            InitializeComponent();
            (this.DataContext as GameInfoAbout).GameI = gameInfo;
        }
    }
}
