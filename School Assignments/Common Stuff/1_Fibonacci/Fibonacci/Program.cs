using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int getal1 = 0;
            int getal2 = 1;

            Console.WriteLine("Enter the number of elements: ");
            int elements = int.Parse(Console.ReadLine());

            Console.Write(getal1 + " " + getal2 + " "); // Print off first 2 numbers, they are our starting point later aswell

            for(int number = 2; number < elements; number++ ) // Start loop at 2, because 0 and 1 the first 2 numbers were already printed
            {
                som = getal1 + getal2;
                Console.Write(som + " ");
                getal1 = getal2;
                getal2 = som;
            }

            Console.WriteLine();
            
            /*

             Different way of doing the Fibonacci numbers
             Here we cannot change the size of the array while the program runs, but it does run with fewer lines of code

             */
            const int LENGTE_ARRAY = 15;
                int[] array = new int[LENGTE_ARRAY];
                array[0] = 0;   
                array[1] = 1;   
            Console.Write(array[0] + " " + array[1] + " ");
                for(int i = 2; i < array.Length;i++)
                {
                    array[i] = array[i - 1] + array[i - 2];
                    Console.Write(array[i] + " ");
                }
                    
            
        }
    }
}
