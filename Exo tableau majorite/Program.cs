using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_tableau_majorite
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, d, r=0;
            a = 5;
            d = 4;

            Calcul(a, d, ref r);
            Console.WriteLine(r);


            Console.WriteLine("Entrez un nombre");
            string saisie = Console.ReadLine();
            int z = Convert.ToInt32(saisie);

            int z = GetInteger("Entrez un nombre");

        }

        static void Calcul (int a, int b, ref int resultat)
        {
            //int resultat;

            resultat = a + b;

            //return resultat;
        }

        static int GetInteger(string message)
        {
            Console.WriteLine(message);
            string saisie = Console.ReadLine();
            int resultat = Convert.ToInt32(saisie);
            return resultat;
        }
    }
}
