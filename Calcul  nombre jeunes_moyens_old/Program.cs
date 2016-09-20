using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul__nombre_jeunes_moyens_old
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int jeune;
            int moyen;
            int vieux;

            Console.Write("****calcul du nombre de jeunes, de moyens et de vieux  (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();

           

            jeune = 0;
            moyen = 0;
            vieux = 0;
            i = 1;
            while (i <= 100)
            {
                Console.WriteLine("Entrez des ages ");
                i = Convert.ToInt32(Console.ReadLine());
               


                if (i < 20)
                {
                    jeune++;

                }

                if (i >= 20 && i < 40)
                {
                    
                    moyen++;

                }

                if (i > 40)
                {
                    
                    vieux++;
                }
                i++;
            }
                Console.WriteLine("Vous êtes " + jeune + " a avoir moins de 20 ans");
                Console.WriteLine("Vous êtes " + moyen + " a avoir entre 20 et 40 ans");
                Console.WriteLine("Vous êtes " + vieux + " a avoir plus de 40 ans");
                Console.ReadLine();
            }        
    }
}
