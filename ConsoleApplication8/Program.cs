using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void AfficheTab(int[] tab) //permet l'affichage des postes d'un tableau

        {
            //int taille = 0;
            //int[] tableau = new int[taille];
            foreach (int i in tab)
            {
                System.Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int taille = 0;
            int val =0;
            int i = 0;


            Console.WriteLine("Bonjour,saisissez la taille de votre tableau");
            taille = Convert.ToInt32(Console.ReadLine());

            int[] tableau;
            tableau = new int[taille];

            for (i = 0; i < taille; i++)
            {
                Console.WriteLine("saisissez " + taille + " valeurs");
                val = Convert.ToInt32(Console.ReadLine());

                tableau[i] = val;
              
            }

            AfficheTab(tableau);
            Console.ReadLine();


        }
    }
}
