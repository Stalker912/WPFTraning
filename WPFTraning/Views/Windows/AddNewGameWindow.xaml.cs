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

namespace WPFTraning.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddNewGameWindow.xaml
    /// </summary>
    public partial class AddNewGameWindow : Window
    {

        public AddNewGameWindow(Action<GameInfo> AddToListAction)
        {
            InitializeComponent();
            this.DataContext = new VM_AddNewInfoAboutGame(AddToListAction, this.Close);
        }

        private void AddNewGameInfoButtonButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.GMI_Content_About.Text != String.Empty
                && this.GMI_Content_MC.Text != String.Empty
                && this.GMI_Content_Name.Text != String.Empty)
            {
                (this.DataContext as VM_AddNewInfoAboutGame)?.AddNewGameTolist();
            }
            else
            {
                if (this.GMI_Content_Name.Text == String.Empty)
                    SetWarring(this.GMI_ContentBlock_Name);
                else
                    SetHidden(this.GMI_ContentBlock_Name);

                if (this.GMI_Content_MC.Text == String.Empty)
                    SetWarring(this.GMI_ContentBlock_MC);
                else
                    SetHidden(this.GMI_ContentBlock_MC);

                if (this.GMI_Content_About.Text == String.Empty)
                    SetWarring(this.GMI_ContentBlock_About);
                else
                    SetHidden(this.GMI_ContentBlock_About);
            }
        }

        private void SetWarring(StackPanel Conteiner)
        {
            if (Conteiner.Children[0] != null)
                ((TextBox)Conteiner.Children[0]).BorderBrush = Brushes.Red;
            if (Conteiner.Children[1] != null)
            {
                ((TextBlock)Conteiner.Children[1]).Text = "Это обязательное поле!";
                ((TextBlock)Conteiner.Children[1]).Style = (Style)Application.Current.Resources["Warring"];
            }
        }

        private void SetHidden(StackPanel Conteiner)
        {
            if(Conteiner.Children[0] != null)
                ((TextBox)Conteiner.Children[0]).BorderBrush = Brushes.Gray;
            if (Conteiner.Children[1] != null)
            {
                ((TextBlock)Conteiner.Children[1]).Text = "";
                ((TextBlock)Conteiner.Children[1]).Style = (Style)Application.Current.Resources["Hiden"];
            }
                
        }
    }
}
