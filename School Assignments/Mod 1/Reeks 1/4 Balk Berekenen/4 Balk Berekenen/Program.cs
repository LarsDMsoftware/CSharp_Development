using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Balk_Berekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            int inhoud;
            int oppervlakte;

            //Inlezen waardes van gebruiker
            Console.WriteLine("Geef de hoogte, breedte en lengte van de balk:");
            int hoogte = int.Parse(Console.ReadLine());
            int breedte = int.Parse(Console.ReadLine());
            int lengte = int.Parse(Console.ReadLine());

            //Berekenen van inhoud en oppervlakte
            //Inhoud = L * B * H
            inhoud = lengte * breedte * hoogte;

            //Oppervlakte = 2(L*B*H + H * B)
            oppervlakte = 2 * (lengte * breedte * hoogte + hoogte * breedte);

            //Afrduken berekende waardes
            Console.WriteLine("De inhoud van de balk is: " + inhoud);
            Console.WriteLine("Het oppervlakte van de balk is: " + oppervlakte);

        }
    }
}
