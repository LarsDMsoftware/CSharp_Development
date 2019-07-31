using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Gemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AANTAL_GETALLEN = 3;
            int getal1, getal2, getal3;
            double gemiddelde;

            Console.WriteLine("Geef je eerste getal: ");
            getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef je tweede getal: ");
            getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef derde getal in: ");
            getal3 = int.Parse(Console.ReadLine());

            gemiddelde = (double)(getal1 + getal2 + getal3) / AANTAL_GETALLEN;

            Console.WriteLine("Het gemiddelde van je 3 opgegeven getallen is: " + gemiddelde);
        }
    }
}
