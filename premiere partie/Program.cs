using System;
using System.Collections.Generic;
using System.Text;

namespace TPCSharp
{
    class Cercle
    {
        static void Main()
        {

            Console.Write("****Périmètre et surface du Cercle (V1.0, 07 / 07 / 2016) ****");
            Console.WriteLine();
            //Declaration de variables. 
            string saisie; // variable recevant la saisie
            double rayon; // rayon
            double perimetre; // périmètre
            double surface;//surface
                           // Etape 1 : lecture du rayon
            Console.WriteLine("Entrez la valeur du rayon : ");
            saisie = Console.ReadLine();
            // Etape 2 : calcul et affichage du périmètre
            rayon = Convert.ToDouble(saisie);
            //Calcul du perimetre
            perimetre = 2 * Math.PI * rayon;
            Console.Write("Le cercle de rayon " + rayon);
            Console.Write("a pour périmetre : " + perimetre);
            Console.WriteLine();
            //calcul de la surface d'un cercle
            surface = rayon * rayon * Math.PI;
            Console.Write("surface du cercle :" + surface);
            Console.WriteLine();

            // Permet de conserver l'affichage de la console
            Console.ReadLine();
        }
    }
}
