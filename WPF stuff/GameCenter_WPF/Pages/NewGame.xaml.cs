
using System.Windows;
using System.Windows.Controls;



namespace GameCenter_WPF.Pages
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Page
    {
        private MainWindow GoTo { get; }
        public NewGame(MainWindow window)
        {
            GoTo = window;

            InitializeComponent();
        }

        private void GameStart(object sender, RoutedEventArgs e)
        {
            GoTo.PageSelector("startnewgame");
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
           GoTo.PageSelector("menu");
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
