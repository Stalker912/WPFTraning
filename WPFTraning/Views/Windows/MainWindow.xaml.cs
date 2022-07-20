using Ninject;
using System.Windows;
using System.Windows.Controls;
using WPFTraning.IoC;
using WPFTraning.Services;
using WPFTraning.ViewModels.Base;
using WPFTraning.ViewModels.IBase;
using WPFTraning.Views.Windows;

namespace WPFTraning
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GameInfoGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            (this.DataContext as ViewModel).LineDoubleClick();
        }

        private void GameInfoGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }
    }
}
