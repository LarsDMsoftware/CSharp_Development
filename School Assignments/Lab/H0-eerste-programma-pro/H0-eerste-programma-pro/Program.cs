using System;

namespace Programeren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit is mijn eerste C# programma");
            Console.WriteLine("*******************************");
            Console.Write("Type je voornaam: ");
            string voorNaam = Console.ReadLine();
            Console.Write("Type je achternaam: ");
            string achterNaam = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Dus je naam is: " + achterNaam + " " + voorNaam);
            Console.WriteLine("Of: " + voorNaam + " " + achterNaam);
        }
    }
}
