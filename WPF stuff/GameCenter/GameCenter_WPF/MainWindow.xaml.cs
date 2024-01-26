
using System.Windows;
using System.Xml.XPath;
using GameCenter_WPF.Pages;



namespace GameCenter_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PageSelector("menu");
        }

        internal void PageSelector(string page)
        {
            if (page == "quit") { Environment.Exit(0); }
            dynamic result = page switch
            {
                "menu"         => new Menu(this),
                "newgame"      => new NewGame(this),
                "Load"         => new Load(this),
                "settings"     => new Settings(this),
                "startnewgame" => new ClickerGame(this),
                //  "Save" =>,
                //  "" =>,
                _ => @" ¯\_(ツ)_ /¯ "
            };

            MainFrame.Navigate(result);
        }


        //internal void Menu()
        //{
        //    MainFrame.Navigate(new Menu(this));
        //}
        //internal void NewGame()
        //{
        //    MainFrame.Navigate(new NewGame(this));
        //}
        //internal void Load()
        //{
        //    MainFrame.Navigate(new Load(this));
        //}
        //internal void Settings()
        //{
        //    MainFrame.Navigate(new Settings(this));
        //}
        //internal void Save()
        //{

        //}



    }


}
