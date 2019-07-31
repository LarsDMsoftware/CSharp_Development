using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Bankrekening
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konstante controle nummer van bankrekeningen
            const int BANK_REKENING_CONTROLE_NUMMER = 97;

            //Inlezen van de bankrekeningnummer
            Console.Write("Geef de eerste 3 cijfers van je bankrekeningnummer: ");
            string eersteDrieGetallenRekening = Console.ReadLine();

            Console.Write("Geef de volgende 7 cijfers van je bankrekeningnummer: ");
            long bankrekeningNummer = long.Parse(eersteDrieGetallenRekening + Console.ReadLine());

            Console.Write("Geef de laatste 2 cijfers van je bankrekeningnummer: ");
            int controleCijfersRekening = int.Parse(Console.ReadLine());

            //Controle of bankrekeningnummer geldig is.
            if(bankrekeningNummer % BANK_REKENING_CONTROLE_NUMMER == controleCijfersRekening)
                Console.WriteLine("De opgegeven bankrekeningnummer is geldig!");
            else
                Console.WriteLine("De opgegeven bankrekeningnummer is niet geldig!");
        }
    }
}
