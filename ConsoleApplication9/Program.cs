using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void max(int[] chaussure)
        {
            int valeurmaxi = 0;
            foreach (int i in chaussure)
            {
                               

                if (valeurmaxi == 0)
                {
                    valeurmaxi = i;

                }
                if (i > valeurmaxi)
                {
                    valeurmaxi = i;
                    
                }
                
            }
            Console.WriteLine("la valeur max entrée dans votre tableau est : " + valeurmaxi);
        }

        static void moyenne(int[] chaussure)
        {
            int somme = 0;
            int addition = 0;
            int moyenne = 0;

            foreach (int i in chaussure)
            {
                            

                if (i != 0)
                {
                    somme = somme + i;
                    addition++;
                    moyenne = somme / addition;
                   
                }
               
            }
            Console.WriteLine("Voici la moyenne : " + moyenne);
        }

static void AfficheTab(int[] tab) //permet l'affichage des postes d'un tableau

        {
            
            foreach (int i in tab)
            {
                Console.Write("["+i +"] ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int taille = 0;
            int val = 0;
            int i = 0;    


            Console.WriteLine("Bonjour,saisissez la taille de votre tableau");
            taille = Convert.ToInt32(Console.ReadLine());

            int[] tableau;
            tableau = new int[taille];

            for (i = 0; i < taille; i++)
            {
                //Console.WriteLine("saisissez " + taille + " valeurs");
                Console.WriteLine("saisissez encore " + (taille-i) + " valeurs");
                val = Convert.ToInt32(Console.ReadLine());
                tableau[i] = val;
                                            
                                 
            }
            Console.WriteLine();
            Console.WriteLine("Les valeurs du tableau sont :");
            AfficheTab(tableau);
            max(tableau);
            moyenne(tableau);
            Console.ReadLine();

        }
    }
}
