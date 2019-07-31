using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Vierkant
{
    class Program
    {
        static void Main(string[] args)
        {
            int oppervlakte;
            int omtrek;

            //Input inlezen
            Console.WriteLine("Geef de lengte en breedte op van het vierkant: ");
            int lengte = int.Parse(Console.ReadLine());
            int breedte = int.Parse(Console.ReadLine());

            //Berekeningen uitvoeren
            oppervlakte = lengte * breedte;
            omtrek = (lengte + breedte) * 2;

            //Afdrukken berekeningen
            Console.WriteLine("Het oppervlakte van het vierkant is: " + oppervlakte);
            Console.WriteLine("De omtrek van het vierkant is: " + omtrek);
        }
    }
}
