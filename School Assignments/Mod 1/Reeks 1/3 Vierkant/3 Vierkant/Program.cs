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
            double zijde;

            //Input inlezen
            Console.Write("Typ de zijde van de vierkant in: ");
            zijde = double.Parse(Console.ReadLine());

            //Berekeningen uitvoeren en afdrukken
            Console.WriteLine("zijde: " + zijde);
            Console.WriteLine("omtrek: " + 4 * zijde);
            Console.WriteLine("oppervlakte: " + zijde * zijde);
        }
    }
}
