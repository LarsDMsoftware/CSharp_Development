using System;

namespace H1_Optellen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het eerste getal:");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef het tweede getal:");
            int getal2 = int.Parse(Console.ReadLine());
            int som = getal1 + getal2;
            Console.WriteLine("De som is: " + som );
        }
    }
}
