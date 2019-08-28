using System;

namespace _2_Factioral
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;

            Console.Write("Enter any number: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
                fact *= i;

            Console.WriteLine("Factorial of " + number + " is " + fact);


        }
    }
}
