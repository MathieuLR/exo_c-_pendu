using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("****calculatrice v2 (V1.0, 07 / 07 / 2016) ****");
            Console.WriteLine();

            double resultat;
            double saisie;
            string comb;
            string deuxcomb;
            double deuxsaisie;

            Console.WriteLine("Entrez un chiffre : ");
            comb = Console.ReadLine();
            saisie = Double.Parse(comb);

            Console.WriteLine("Entrez un deuxieme chiffre : ");
            deuxcomb = Console.ReadLine();
            deuxsaisie = double.Parse(deuxcomb);

            resultat = saisie / deuxsaisie;
            Console.Write("resultat " + resultat);
            Console.WriteLine();

            Console.ReadLine();






        }
    }
}
