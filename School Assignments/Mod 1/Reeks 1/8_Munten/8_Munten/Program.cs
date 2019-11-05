using System;

namespace _8_Munten
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneCent = 0, twoCent = 0, fiveCent = 0, tenCent = 0, twentyCent = 0, fiftyCent = 0, oneEuro = 0, twoEuro = 0;
            int sumCent, sumEuro;

            Console.WriteLine("Please insert the amount of the following coins:");
            Console.Write("1 Cent: ");
            oneCent = int.Parse(Console.ReadLine());
            Console.Write("2 Cent: ");
            twoCent = int.Parse(Console.ReadLine());
            Console.Write("5 Cent: ");
            fiveCent = int.Parse(Console.ReadLine());
            Console.Write("10 Cent: ");
            tenCent = int.Parse(Console.ReadLine());
            Console.Write("20 Cent: ");
            twentyCent = int.Parse(Console.ReadLine());
            Console.Write("50 Cent: ");
            fiftyCent = int.Parse(Console.ReadLine());
            Console.Write("1 Euro: ");
            oneEuro = int.Parse(Console.ReadLine());
            Console.Write("2 Euro: ");
            twoEuro = int.Parse(Console.ReadLine());

            sumCent = oneCent + 2 * twoCent + 5 * fiveCent + 10 * tenCent + 20 * twentyCent + 50 * fiftyCent + 100 * oneEuro + 200 * twoEuro;
            sumEuro = sumCent / 100;
            sumCent %= 100;

            Console.WriteLine("Sum = {0} euro(s) and {1} cent(s).", sumEuro, sumCent);
        }
    }
}
