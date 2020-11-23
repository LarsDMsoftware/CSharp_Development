using System;
using static H4_Ruimte_Specifiek.Planets;

namespace H4_Ruimte_Specifiek
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PlanetsList planetChoice;
            int choice;
            double weight, weightOnPlanet = 0;

            Console.WriteLine("Hoeveel weeg je? ");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Voor welke planeet wil je je gewicht kennen? \n 1. Mercurius \n 2. Venus" +
                "\n 3. Aarde \n 4. Mars \n 5. Jupiter \n 6. Saturnus \n 7. Uranus \n 8. Neptunus \n 9. Pluto");
            choice = int.Parse(Console.ReadLine());
            planetChoice = (PlanetsList)choice;
            switch(planetChoice)
            {
                case (PlanetsList)1:
                    weightOnPlanet = weight * 0.38;
                    break;
                case (PlanetsList)2:
                    weightOnPlanet = weight * 0.91;
                    break;
                case (PlanetsList)3:
                    weightOnPlanet = weight * 1;
                    break;
                case (PlanetsList)4:
                    weightOnPlanet = weight * 0.38;
                    break;
                case (PlanetsList)5:
                    weightOnPlanet = weight * 2.34;
                    break;
                case (PlanetsList)6:
                    weightOnPlanet = weight * 1.06;
                    break;
                case (PlanetsList)7:
                    weightOnPlanet = weight * 0.92;
                    break;
                case (PlanetsList)8:
                    weightOnPlanet = weight * 1.19;
                    break;
                case (PlanetsList)9:
                    weightOnPlanet = weight * 0.06;
                    break;
            }
            Console.WriteLine("Daar weeg je " + weightOnPlanet + "kg.");
            Console.ReadLine();
            
        }
    }
}

/*
Mercurius: 0.38 (een persoon van 100kg voelt zich alsof hij 38kg weegt) 
Venus: 0.91
Aarde: 1.00 (een persoon van 100kg voelt zich alsof hij 100kg weegt)
Mars: 0.38
Jupiter: 2.34
Saturnus: 1.06
Uranus: 0.92
Neptunus: 1.19
Pluto: 0.06
*/
