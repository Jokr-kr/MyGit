
namespace ConsoleCollection.Organtransplant
{
    internal class human
    {
        private string _name { get; }
        private int _age { get; set; }
        private int _kidney { get; set; }

        private int _Compatability;
        
        //generaly i wanted the compatability to be random
        //but i put in a possibility to choose
        //so i can test both a true and false test
        //also i needed to learn about default values
        public human(string Name, int Comp = -1)
        {
            _name = Name;
            _age = 0;
            _kidney = 2;
            _Compatability = (Comp == -1) ? Compatability() : Comp;
        }

        //simple compatability in humans
        //they each get either 0 or 1
        private int Compatability()
        {
            Random rnd = new();
            if (rnd.Next(0, 2) == 0) return 1;
            return 0;
        }

        //--- Returns name---//
        internal string Name()
        {
            return _name;
        }
        //---Returns Age---//
        internal int Age()
        {
            return _age;
        }
        //---returns kidney amount---//
        internal int KidneyStatus()
        {
            return _kidney;
        }

        //---removes one kidney---//
        public void LoseKidney()
        {
            _kidney--;
        }

        //---transfer kidney from one to another---//

        internal static void TransferKidney(human human1,human human2)
        {
            human1._kidney--;
            human2._kidney++;
        }



        //1/1 and 0/0 are copmatible
        //1/0 and 0/1 are not
        public static void Compatabilitycheck(human human1, human human2)
        {
            
            var result = human1._Compatability == human2._Compatability ? "positive":"negative";

            Console.WriteLine($"compatability test\n\n" +
                              $"  {human1._name} and {human2._name}\n" +
                              $"    {result}\n");
        }
    }
}
