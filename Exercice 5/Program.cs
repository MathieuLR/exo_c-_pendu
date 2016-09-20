using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string note1;
            string note2;
            string note3;
            double saisie1;
            double saisie2;
            double saisie3;
            double resultat;

            Console.Write("****calcul de la moyenne ponderee (V1.0, 07 / 07 / 2016) ****");
            Console.WriteLine();

         
            Console.WriteLine("Entrez la note du devoir surveillé");
            note1 = Console.ReadLine();
            saisie1 = Double.Parse(note1);


            Console.WriteLine("Entrez la note de l'interrogation écrite");
            note2 = Console.ReadLine();
            saisie2 = Double.Parse(note2);


            Console.WriteLine("Entrez la note de travaux pratique");
            note3 = Console.ReadLine();
            saisie3 = Double.Parse(note3);

            resultat = (((saisie1 * 3) + (saisie2 * 2) + (saisie3* 1)) / 6);
            Console.Write("Votre moyenne ponderee est de :" + resultat + " sur 20");
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
