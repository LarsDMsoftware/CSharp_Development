using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting("Lars", "Lana");

            Console.WriteLine(greeting.ToString());
            
        }
    }
}
