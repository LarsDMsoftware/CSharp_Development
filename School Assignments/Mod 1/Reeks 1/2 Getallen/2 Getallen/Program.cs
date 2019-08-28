using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Getallen
{
    class Program
    {
        static void Main(string[] args)
        {
            int intnum1, intnum2;
            double doublenum1, doublenum2;

            Console.WriteLine("Please insert 2 integer numbers: ");
            intnum1 = int.Parse(Console.ReadLine());
            intnum2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", intnum1, intnum2, intnum1 + intnum2);
            Console.WriteLine("{0} / {1} = {2}", intnum1, intnum2, intnum1 / intnum2);
            
            Console.WriteLine("Please insert 2 double numbers: ");
            doublenum1 = double.Parse(Console.ReadLine());
            doublenum2 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", doublenum1, doublenum2, doublenum1 + doublenum2);
            Console.WriteLine("{0} / {1} = {2}", doublenum1, doublenum2, doublenum1 / doublenum2);
        
        }
    }
}
