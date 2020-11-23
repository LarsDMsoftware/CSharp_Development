using System;

namespace H0_eerste_programma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit is mijn eerste C# programma");
            Console.WriteLine("*******************************");
            Console.Write("Type je naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Hallo, " + naam + "!");
               
        }
    }
}
