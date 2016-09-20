using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int somme;
            int moyenne;
            int division;

            Console.Write("****  somme et  moyenne  (V1.0, 12 / 07 / 2016) ****");
            Console.WriteLine();

            division = 0;
            somme = 0;
            i = 1;
            while(i != 0)
            {
                Console.WriteLine("Entrez des chiffres appuyez sur zéro pour obtenir le résultat");
                i = Convert.ToInt32(Console.ReadLine());
                somme = somme + i;
                division++;
               
               
            }
            moyenne = somme / (division - 1);
            Console.WriteLine("Voici la somme : " + somme + " et la moyenne : " + moyenne);
            Console.ReadLine();



        }
    }
}
