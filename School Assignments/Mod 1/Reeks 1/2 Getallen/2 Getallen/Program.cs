using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Getallen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablen declareren
            int getal1;
            int getal2;
            int som;
            int deling;
            double doubleSom;
            double doubleDeling;

            // Ints inlezen
            Console.WriteLine("Geef 2 getallen in: ");
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            
            // Ints/Doubles verwerken
            //Ints optellen
            som = getal1 + getal2;

            //Ints delen
            deling = getal1 / getal2;

            //Doubles optellen
            doubleSom = (double)getal1 + getal2;

            //Doubles delen
            doubleDeling = (double)getal1 / getal2;

            //Delingen en sommen afdrukken
            Console.WriteLine("Som van de 2 getallen is: " + som);
            Console.WriteLine("Deling van de 2 getallen is: " + deling);
            Console.WriteLine("Som als double van de 2 getallen is: " + doubleSom);
            Console.WriteLine("Delins als double van de 2 getallen is: " + doubleDeling);
        }
    }
}
