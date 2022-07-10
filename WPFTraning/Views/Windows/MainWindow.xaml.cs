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
        private ViewModel MainWindowVM;

        public MainWindow()
        {
            
            InitializeComponent();
            MainWindowVM = new StandardKernel(new NinjectConfigModule()).Get<ViewModel>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender)?.Command?.Execute(sender);
        }

        private void GameInfoGrid_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var VAGI = new AboutGameInfo();
            var VMAGI = new GameInfoAbout((sender as DataGrid)?.SelectedItem as GameInfo);
            VAGI.DataContext = VMAGI;
        }
    }
}
