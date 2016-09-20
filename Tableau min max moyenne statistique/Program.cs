using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_min_max_moyenne_statistique
{
    class Program
    {     
        
        static void Main(string[] args)
        {
            int nombre;
            int valeurmaxi =0;
            int valeurmini =0;
            int somme = 0;
            int moyenne;


            int[] valeurs = new int[50];

            for (int i = 0; i <= valeurs.Length - 1; i++)
            {
                Console.WriteLine("Saisissez un nombre");
                nombre = Convert.ToInt32(Console.ReadLine());
                valeurs[i] = nombre;
                somme = somme + nombre;
                
            

            if (valeurmaxi == 0 & valeurmini == 0)
                {
                    valeurmaxi = nombre;
                    valeurmini = nombre;
                }
                if (nombre > valeurmaxi)
                {
                    valeurmaxi = nombre;
                }
                if (nombre < valeurmini)
                {
                    valeurmini = nombre;
                }
               
            }
            moyenne = somme / valeurs.Length;
            Console.WriteLine("Le nombre max est " + valeurmaxi);
            Console.WriteLine("Le nombre min est " + valeurmini);
            Console.WriteLine("La moyenne des nombres est : " + moyenne);
            Console.ReadLine();







        }
    }
}
