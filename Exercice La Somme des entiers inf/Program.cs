using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_La_Somme_des_entiers_inf
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int somme;

            Console.Write("****la somme des entiers inferieurs a N  (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();



            Console.WriteLine("Choisissez un chiffre");
            i = Convert.ToInt32(Console.ReadLine());

            somme = 0;

            while (i > 0)
            {
                Console.WriteLine("{0}", i);
                i--;
                somme = somme + i;
            }
            Console.WriteLine("la somme est egale a : " + somme);
            Console.ReadLine();
        }
    }
}
