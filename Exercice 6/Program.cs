using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int h;
            int m;
            int s;
  
            Console.Write("****conversion d'une duree h,m,s en heure (V1.0, 07 / 07 / 2016) ****");
            Console.WriteLine();

            Console.WriteLine("Entrez un nombre de secondes");
            saisie = Console.ReadLine();
            s = Convert.ToInt32(saisie);
            h = s / 3600;
            s = s % 3600;
            m = s / 60;
            s = s % 60;

            Console.Write("voici la decomposition : " + saisie + "en secondes est "+ h + "H" + m + "M" + s + "S");
            Console.ReadLine();
            

        

           
        }
    }
}
