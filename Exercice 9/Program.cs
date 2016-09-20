using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int date = DateTime.Now.Year;
            int datedenaissance;
            int resultat;
     

            Console.Write("****date de naissance / age (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();


            Console.WriteLine("Entrez votre date de naissance");
            saisie = Console.ReadLine();
            datedenaissance = Convert.ToDateTime(saisie).Year;


            resultat = date - datedenaissance;

            Console.WriteLine("Vous avez " + resultat + " ans");
            if (resultat < 18)
            Console.WriteLine("Quand on joue encore au lego , on ne devient pas acoolo");
            else
            Console.WriteLine("Tchin");
            Console.ReadLine();
























        }
    }
}
