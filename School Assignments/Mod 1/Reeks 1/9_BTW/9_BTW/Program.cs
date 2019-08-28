using System;

namespace _9_BTW
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo again;
            const double btwPercentage = 21;

            do
            {
                Console.Clear();

                Console.Write("Please insert the price excl. BTW: ");
                Console.WriteLine("price incl. BTW: " + Math.Round(((btwPercentage / 100 + 1) * double.Parse(Console.ReadLine())), 2));
                Console.Write("For another item press 1: ");

                again = Console.ReadKey();
            } while (again.Key == ConsoleKey.D1 || again.Key == ConsoleKey.NumPad1);
        }
    }
}
