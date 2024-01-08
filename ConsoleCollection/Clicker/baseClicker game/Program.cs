using System.Windows;

namespace baseClicker_game
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            string? username = null;
            while (string.IsNullOrEmpty(username))
            {
                username = Console.ReadLine();
                Console.WriteLine("name not viable, please try again");
            }


            Game game = new(username);

            Application.Current.Dispatcher.Invoke(game.Start);

        }
    }


}
