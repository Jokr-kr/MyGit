using System.Windows;


namespace baseClicker_game
{
    
    internal class Game
    {
        private string _playername;
        private int _score = 0;
        private int _clicks = 0;
        private int _upgrades = 1;
        private double _feeincrease = 1.2;

        public Game(string name)
        {
            _playername = name;
        }

        [STAThread]
        internal void Start()
        {
            Application app = new Application();
            app.Run(new ClickerWindow.MainWindow());
        }
    }

}
