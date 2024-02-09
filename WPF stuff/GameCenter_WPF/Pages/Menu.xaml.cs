using System.Windows;
using GameCenter_WPF;

namespace GameCenter_WPF.Pages
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu
    {
        private MainWindow GoTo { get; }

        public Menu(MainWindow mainWindow)
        {
            GoTo = mainWindow;

            InitializeComponent();
        }
        
        private void NewGamebtn(object sender, RoutedEventArgs e) { GoTo.PageSelector("newgame"); }

        private void Loadbtn(object sender, RoutedEventArgs e) { GoTo.PageSelector("Load"); }

        private void Settingsbtn(object sender, RoutedEventArgs e) { GoTo.PageSelector("settings"); }

        private void QuitBtn(object sender, RoutedEventArgs e) { GoTo.PageSelector("quit"); }
    }
}
