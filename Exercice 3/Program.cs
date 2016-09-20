using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            double saisie;
            double resultat;

            Console.Write("****conversion temperature (V1.0, 07 / 07 / 2016) ****");
            Console.WriteLine();

                     
            Console.WriteLine("Entrez une temperature  en degrès Fahrenheit: ");
            temp = Console.ReadLine();
            saisie = Double.Parse(temp);

            resultat = ((double)5 / 9)*(saisie - 32);
            Console.Write("La température est de :" + resultat + " degrès celsius");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
