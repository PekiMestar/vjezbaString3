using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaString3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            Console.WriteLine("Unesite neki tekst.");

            tekst = Console.ReadLine();

            string sVelika = tekst.ToUpper();
            string sMala = tekst.ToLower();
            string sPrvaTri = tekst.Substring(0, 3);
            string sZadnjihPet = tekst.Substring(tekst.Length - 5, 5);
            string s8_11 = tekst;

            Console.WriteLine("ISPIS:");

            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);

            if (tekst.Length > 11)
            {
                s8_11 = (tekst.Substring(8, 3));
                Console.WriteLine(s8_11);
            }

            else
            {
                Console.WriteLine("Tekst je prekratak.");
            }

            Console.ReadKey();

        }
    }
}
