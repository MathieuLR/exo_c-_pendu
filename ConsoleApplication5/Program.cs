using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void getstring (string phrase)
        {
            Console.WriteLine("entrez une phrase");
            phrase = Console.ReadLine();
        }

        static int GetInteger (string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

         static void multiples(int n, int x)
        {
            int i = 1;
            int resultat;

            //Console.WriteLine("Entrez un chiffre ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Entrez deuxieme chiffre ");
            //x = Convert.ToInt32(Console.ReadLine());

            //x = GetInteger("Entrez deuxieme chiffre ");

            while (i <= n)

            {
                resultat = i * x;
                Console.WriteLine("la multiplication de : " + i + " * " + x + " = " + (i * x));
                i++;
            }

        }
          static void somme_moyenne()
            {
            int i;
            int somme;
            int moyenne;
            int division;

            division = 0;
            somme = 0;
            i = 1;
         
            while (i != 0)
            {
                Console.WriteLine("Entrez des chiffres , appuyez sur zéro pour obtenir le résultat ");
                i = Convert.ToInt32(Console.ReadLine());

                somme = somme + i;
                division++;


            }
            moyenne = somme / (division - 1);
            Console.WriteLine("Voici la somme : " + somme + " et la moyenne : " + moyenne);
            Console.ReadLine();

        }
        static int comptagevoyelle(string mot)
        {
            string voyelles = "aeiouyAEIOUY";
            int nombvoy;
            int i;

            i = 0;
            nombvoy = 0;
           
            while (i < mot.Length)
            {
                if (voyelles.IndexOf(mot.Substring(i, 1)) != -1)
                {
                    nombvoy++;
                }
                i++;
            }
            return nombvoy;
        }


        static int compterlettre(string phrase, string lettre)
        {
            int i = 0;
            int comptage = 0;
            

           
            while (i < phrase.Length)
            {
                if (lettre == phrase.Substring(i, 1))
                {
                    comptage++;
                   
                }

                i++;
         
            }
            return comptage;

        }

        /* static void monmenu (int ichoixmenu)
       {

           Console.WriteLine("1-multiples");
           Console.WriteLine("2-Somme et moyenne");
           Console.WriteLine("3-Recherche du nombre de voyelle");
           Console.WriteLine("4-Recherche du nombre de caracteres suivants");
           Console.WriteLine("Entrez votre option");

       }
       */
        static void Main(string[] args)
        {
            int ichoixmenu = 0;

            do
            {


                Console.WriteLine("0-Quitter");
                Console.WriteLine("1-multiples");
                Console.WriteLine("2-Somme et moyenne");
                Console.WriteLine("3-Recherche du nombre de voyelle");
                Console.WriteLine("4-Recherche du nombre de caracteres suivants");
                Console.WriteLine("Entrez votre option");
                ichoixmenu = Convert.ToInt32(Console.ReadLine());


                
                    if (ichoixmenu == 1)
                    {
                        
                        multiples(5, 7);
                    }
                     if (ichoixmenu == 2)
                    {
                        //int chiffre = 0;
                        somme_moyenne();
                    }
                     if (ichoixmenu == 3)
                    {
                        string mot;
                        Console.WriteLine("Entrez un mot pour savoir combien il y a de voyelles");
                        mot = Console.ReadLine();
                    //int nb = comptagevoyelle(mot);
                        int nb = comptagevoyelle("bonjour");
                        Console.WriteLine("Il y a " + nb + " voyelle(s) dans " + mot);
                        Console.ReadLine();
                }
                    if (ichoixmenu == 4)
                    {
                        string phrase;
                        string lettre;

                        Console.WriteLine("Tapez une phrase");
                        phrase = Console.ReadLine();

                        Console.WriteLine("Tapez une lettre pour savoir combien de fois elle se trouve dans la phrase");
                        lettre = Console.ReadLine();
                        int nb = compterlettre(phrase, lettre);
                        Console.WriteLine("Dans la phrase , il y a  " + nb + " " + lettre);

                        Console.ReadLine();
                }

                }
                while (ichoixmenu != 0) ;

            

         }
    }
}
