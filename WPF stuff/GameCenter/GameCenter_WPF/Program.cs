
using System.Windows;

namespace GameCenter_WPF
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        
        {
            var app = new Application();
            var window = new MainWindow();
            app.Run(window);

        }
    }
}
