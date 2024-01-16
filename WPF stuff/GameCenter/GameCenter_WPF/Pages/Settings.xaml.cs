
using System.Windows;
using System.Windows.Controls;

namespace GameCenter_WPF.Pages
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        private MainWindow GoTo { get; }
        public Settings(MainWindow mainWindow)
        {
            GoTo = mainWindow;
            InitializeComponent();
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
           GoTo.PageSelector("menu");
        }
    }
}
