using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static int compterlettre(string phrase ,string lettre)
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
        static void Main(string[] args)
        {
            string phrase;
            string lettre;

            Console.WriteLine("Tapez une phrase");
            phrase = Console.ReadLine();

            Console.WriteLine("Tapez une lettre pour savoir combien de fois elle se trouve dans la phrase");
            lettre = Console.ReadLine();

            Console.WriteLine("Dans la phrase , il y a  " + compterlettre(phrase,lettre) + lettre);

            Console.ReadLine();

        }
    }
}
