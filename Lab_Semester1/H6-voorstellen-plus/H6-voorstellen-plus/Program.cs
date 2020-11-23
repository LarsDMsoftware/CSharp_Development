using System;

namespace H6_voorstellen_plus
{
    class Program
    {
        static void MyIntro(string name, int age, string address)
        {
            Console.WriteLine("Ik ben {0}, ik ben {1} jaar oud en woon in de {2}", name, age, address);
        }
        static void Main(string[] args)
        {
            MyIntro("Lars De Maere", 23, "Marsstraat");
        }
    }
}
