using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_somme_intervalle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int somme;

            Console.Write("****somme d'un intervalle a N  (V1.0, 12 / 07 / 2016) ****");
            Console.WriteLine();



            Console.WriteLine("Choisissez un chiffre");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Choisissez un deuxieme chiffre");
            n2 = Convert.ToInt32(Console.ReadLine());

            somme = n1;
            if (n1 < n2)
            {

                while (n1 != n2)
                {
                    Console.WriteLine("{0}", n1);
                    n1++;
                    somme = somme + n1;
                }
                Console.WriteLine("la somme est egale a : " + somme);
                Console.ReadLine();
            }
             if (n1 > n2)
            {
                while (n1 != n2)
                {
                    Console.WriteLine("{0}", n1);
                    n1--;
                    somme = somme + n1;
                }
                Console.WriteLine("la somme est egale a : " + somme);
                Console.ReadLine();

            }
        }
    }
}
