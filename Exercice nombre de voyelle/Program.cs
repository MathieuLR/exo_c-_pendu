using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_nombre_de_voyelle
{
    class Program
    {
        static void Main(string[] args)
        {
            string voyelles = "aeiouyAEIOUY";
            int nombvoy;
            int i;
            string mot;


            Console.Write("**** compter les voyelles  (V1.0, 12 / 07 / 2016) ****");
            Console.WriteLine();


            Console.WriteLine("Entrez un mot pour savoir combien il y a de voyelles");
            mot = Console.ReadLine();

            i = 0;
            nombvoy = 0;
            while ( i < mot.Length)
            {
                if (voyelles.IndexOf(mot.Substring(i, 1)) != -1)
                {
                    nombvoy++;
                }
                i++;
            }
            Console.WriteLine("Il y a " + nombvoy + " voyelle(s) dans " + mot);
            Console.ReadLine();





        }
    }
}
