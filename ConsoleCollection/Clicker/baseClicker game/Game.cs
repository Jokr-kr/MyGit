using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        void start(Game game)
        {
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(0,3);
                Console.WriteLine($"Score: {_score}");
            }
        }
    }

}
