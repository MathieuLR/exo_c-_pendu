using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            double unicode;


            Console.Write("****unicode (V1.0, 07 / 07 / 2016) ****");
            Console.WriteLine();

            Console.WriteLine("Entrez un nombre entier");
            saisie = Console.ReadLine();
            unicode = Convert.ToInt32(saisie);
            unicode = 65;
            Console.Write("voici la lettre correspondante :"+ saisie +" correspond a la lettre A" );
            Console.ReadLine();

        }
    }
}
