


namespace GameCenter
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
            App app = new();
            MainWindow mainWindow = new();
            app.Run(mainWindow);
        }
    }
}
