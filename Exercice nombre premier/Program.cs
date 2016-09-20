using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_nombre_premier
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int diviseur;

            Console.Write("****nombre premier (V1.0, 13 / 07 / 2016) ****");
            Console.WriteLine();

            Console.WriteLine("Entrez un nombre pour savoir si c'est un nombre premier");
            i = Convert.ToInt32(Console.ReadLine());


            diviseur = 2;
            while (i > 0)
            {
                (i / diviseur);  
            }
        }
    }
}
