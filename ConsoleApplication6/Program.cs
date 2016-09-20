using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static double factorielle (double N)
        {
            double resultat = 1;
            for (double i = N; i > 1; i--)
            {
                resultat *= i;
            }
            return resultat;
        }

        static void Main(string[] args)
        {
            int nombre = 0;
            int i = 0;


            Console.WriteLine("entrez un numéro pour calculer la factorielle");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Le résultat de la factorielle est " + factorielle(nombre));
            Console.ReadLine();
        }
    }
}
