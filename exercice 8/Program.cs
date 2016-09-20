using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int nombre;
            int reste;


            Console.Write("****nombre pair ou impair (V1.0, 08 / 07 / 2016) ****");
            Console.WriteLine();


            Console.WriteLine("Entrez un nombre");
            saisie = Console.ReadLine();
            nombre = int.Parse(saisie);

            reste = nombre % 2;
            if (reste ==0)
            { Console.WriteLine("Entier paire ");
            }
            else
            { Console.WriteLine("Entier Impair!");
            }
            Console.ReadLine();

        }
    }
}
