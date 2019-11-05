using System;

namespace H1_variabelen_hoofdletters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wilt u herhaald zien worden in hoofdletters?");
            string input = Console.ReadLine();
            input = input.ToUpper();
            Console.WriteLine("Uw invoer in hoofdletters: " + input);
            Console.WriteLine("Druk op een willekeurige toets om het programma te beeindigen...");
            Console.ReadKey();
        }
    }
}
