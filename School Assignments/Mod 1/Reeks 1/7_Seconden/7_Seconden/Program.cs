using System;

namespace _7_Seconden
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec, min = 0, h = 0;

            Console.Write("Please insert the time in seconds: ");
            sec = int.Parse(Console.ReadLine());

            min = sec / 60 % 60;
            h = sec / 3600;
            sec = sec % 60;

            Console.WriteLine("{0}:{1}:{2}", h, min, sec);
        }
    }
}
