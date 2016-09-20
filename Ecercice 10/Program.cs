using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercice_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;
            int saisie;
            string comb;
            string deuxcomb;
            int deuxsaisie;
            string operateur;

            Console.Write("****Calculette avec opérateur (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();
         

            Console.WriteLine("Entrez un chiffre : ");
            comb = Console.ReadLine();
            saisie = int.Parse(comb);

            Console.WriteLine("Entrez un deuxieme chiffre : ");
            deuxcomb = Console.ReadLine();
            deuxsaisie = int.Parse(deuxcomb);

            Console.WriteLine("Entrez un operateur : ");
            operateur = Console.ReadLine();

          

            if (operateur == "+")
            {
                resultat = saisie + deuxsaisie;
                Console.WriteLine(resultat);
            }

            if (operateur == "-")
            {
                resultat = saisie - deuxsaisie;
                Console.WriteLine(resultat);
            }

            if (operateur == "*")
            {
                resultat = saisie * deuxsaisie;
                Console.WriteLine(resultat);
            }

            if (operateur == "/" & deuxsaisie != 0)
            {
                resultat = saisie / deuxsaisie;
                Console.WriteLine(resultat);
            }


            if (operateur == "/" & deuxsaisie == 0)
            {
                Console.WriteLine("on ne divise pas par 0 péon ");
            }

           if (operateur != "+" & operateur != "-" & operateur != "/" & operateur != "*")
                {
                    Console.WriteLine("operateur error noob ");
                }
            Console.ReadLine();







                
        }
    }
}
