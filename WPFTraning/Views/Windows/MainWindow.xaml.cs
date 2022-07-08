using System.Windows;
using System.Windows.Controls;

namespace WPFTraning
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender)?.Command.Execute(sender);
        }

        //IoC;
        //Ninject

        private void Button_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
