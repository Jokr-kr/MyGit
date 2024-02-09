
using System.Windows;
using System.Windows.Controls;


namespace GameCenter_WPF.Pages
{
    /// <summary>
    /// Interaction logic for Load.xaml
    /// </summary>
    public partial class Load : Page
    {
        private MainWindow GoTo { get; }
        public Load(MainWindow mainWindow)
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
