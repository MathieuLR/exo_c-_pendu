using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somme_d_un_intervalle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int somme;

            Console.Write("****somme d'un intervalle a N  (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();



            Console.WriteLine("Choisissez un chiffre");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Choisissez un deuxieme chiffre");
            n2 = Convert.ToInt32(Console.ReadLine());

            somme = 0;

            while (n1 <0 && n2<0)
            {
                Console.WriteLine("{0}", n1,n2);
                n1++;
                somme = n1 + n2;
            }
            Console.WriteLine("la somme est egale a : " + somme);
            Console.ReadLine();
        }
    }
}
