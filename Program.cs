

using ConsoleCollection.FriendFace;
using ConsoleCollection.Organtransplant;

namespace ConsoleCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var running = true;

            while (running)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Console.WriteLine(" ------------------------------------------------------------------------ \n" +
                                  "|                  this is a set of school assignments                   |\n" +
                                  "|      some are not finished or had to be put aside for others           |\n" +
                                  "|                                                                        |\n" +
                                  "|                      what would you like to do?                        |\n" +
                                  "|                  here is a list of possible commands                   |\n" +
                                  "|                           face, transplant                             |\n" +
                                  "|                                                                        |\n" +
                                  "|                                                                        |\n" +
                                  "|                                                                        |\n" +
                                  " ------------------------------------------------------------------------ ");

                Console.WriteLine("         if you see this you can write 'done' to exit the console");

                string? whatToDo = null;
                while (string.IsNullOrEmpty(whatToDo)) whatToDo = Console.ReadLine();
                running = (whatToDo.ToLower() != "done");
                GoTo(whatToDo);

            }
        }
        //------ first switch will get better with time------//
        public static void GoTo(string? whatToDo)
        {
            switch (whatToDo!.ToLower())
            {
                case "face":
                    MainSite.Start();
                    break;

                case "transplant":
                    OrganTransplant.Start();
                    break;
                //case "check30":

                //    break;
                //case "forloop":

                //    break;
                //case "foreach":

                //    break;
                //case "while":

                //    break;
                //case "crocodile":

                //    break;
                //case "testcode":

                //    break;
                //case "pikachu":

                //    break;
                //case "pokemon":

                //    break;
                //case "demo":

                //    break;
                //case "grade":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //break;
                default:
                    Console.WriteLine("not a valid input, try again.");
                    return;
            }
        }
    }
}
