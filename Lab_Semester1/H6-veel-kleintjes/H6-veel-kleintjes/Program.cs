using System;

namespace H6_veel_kleintjes
{
    class Program
    {
        public static double Square(double getal)
        {
            double resultaat = getal * getal;
            return resultaat;
        }

        public static double Radius(double diameter)
        {
            double straal = diameter / 2;

            return straal;
        }
        public static double Circumference(double diameter)
        {
            double circumference = Math.PI * 2 * (diameter / 2);

            return circumference;
        }

        public static double Surface(double diameter)
        {
            double surface = Square((diameter / 2)) * Math.PI;

            return surface;
        }

        public static double LargestNumber(double numberOne, double numberTwo)
        {
            double result;
            if (numberOne > numberTwo)
                result = numberOne;
            else
                result = numberTwo;

            return result;
        }

        public static string IsEven(int number)
        {
            bool even = false;
            if (number % 2 == 0)
                even = true;
            else
                even = false;

            if (even)
                return String.Format("Het getal is even");
            else
                return String.Format("Het getal is oneven");

        }

        public static void ShowOdd(int limit)
        {
            for(int counter = 0; counter < limit; counter++)
                if(counter % 2 != 0)
                    Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            int number;
            int number2;

            
            // Methode Square uittesten
            Console.WriteLine("Wat moet ik kwadrateren?");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(Square(number));
            Console.WriteLine();

            // Methode Diameter berekenen
            Console.WriteLine("Wat is de diameter?");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(Radius(number));
            Console.WriteLine();

            // Methode Circumference en Surface
            Console.WriteLine("Wat is de diameter?");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("De omtrek is: " + Circumference(number));
            Console.WriteLine("Het oppervlakte is: " + Surface(number));
            Console.WriteLine();

            // Methode voor grootste getal
            Console.WriteLine("Welke twee getallen wil je vergelijken?");
            number = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(LargestNumber(number, number2) + " is het grootste getal");
            Console.WriteLine();

            // Methdoe Even getallen tonen
            Console.WriteLine("Geef een getal en ik zeg of het even is:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsEven(number));
            Console.WriteLine();

            // Methode Tonen alle oneven getallen
            Console.WriteLine("Geef een getal en ik zoek de oneven getallen");
            number = int.Parse(Console.ReadLine());
            ShowOdd(number);



        }       
    }
}
