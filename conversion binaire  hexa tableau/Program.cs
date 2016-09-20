using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion_binaire__hexa_tableau
{
    class Program
    {
        static string decimal_binaire (int nb)
        {


            int resultat = nb;
            int reste;

            string valeur_dec_bin = "";
            
            while (resultat != 0)
            {
                reste = resultat % 2;
                valeur_dec_bin = Convert.ToString(reste) + valeur_dec_bin;
                resultat = resultat / 2;
             
            }

            return valeur_dec_bin;
            
        }

          static string binaire_decimal (int nb)
        {
            int multiplicateur = 0;

            string valeur_bin_dec = "";
            string [] puissance = new string[valeur_bin_dec.Length];
            for (int i = 0; i < valeur_bin_dec.Length; i++)
                
            {
                puissance[i] = Math.Pow(2, multiplicateur);
                multiplicateur++;
            }
       

        }
        static void Main(string[] args)
        {
            int ichoixmenu = 0;

            do
            {


                Console.WriteLine("0-Quitter");
                Console.WriteLine("1-Conversion decimal en binaire");
                Console.WriteLine("2-Conversion binaire en decimal");
                Console.WriteLine("3-Conversion binaire en hexadecimal");
                Console.WriteLine("4-Conversion hexadecimal en binaire");

                ichoixmenu = Convert.ToInt32(Console.ReadLine());
                if (ichoixmenu == 1)
                {

                    int valeur;
                    Console.WriteLine("Entrez un nombre");
                    valeur = Convert.ToInt32(Console.ReadLine());
                    string nb = decimal_binaire(valeur);
                    Console.WriteLine("Le resultat de " + valeur + "en binaire est " + nb);
                    Console.Read();
                    Console.Read();

                }
                if (ichoixmenu == 2)
                {
                    int valeur;
                    Console.WriteLine("Entrez un nombre");
                    valeur = Convert.ToInt32(Console.ReadLine());
                    string nb = binaire_decimal(valeur);
                    Console.WriteLine("Le resultat de " + valeur + "en decimal est " + nb);
                    Console.Read();
                    Console.Read();
                }
                if (ichoixmenu == 3)
                {

                }
                if (ichoixmenu == 4)
                {

                }
            }
            while (ichoixmenu != 0);
        }
    }
}
