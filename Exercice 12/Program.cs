using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string statut;
            string salmens;
            double nbmenfant;
            double salaire;
            double participation;
            string mioche;
            double C;
            double M;


            Console.Write("****La participation  (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();

            Console.WriteLine("Saisissez votre statut matrimonial   : ");
            statut = Console.ReadLine();

            Console.WriteLine("Combien avez vous d'enfants?   : ");
            mioche = Console.ReadLine();
            nbmenfant = Convert.ToDouble(mioche);

            Console.WriteLine("Quel est votre salaire mensuel ?   : ");
            salmens = Console.ReadLine();
            salaire=Convert.ToDouble(salmens);

            if (statut == "C" & salaire < 1200)
            {
                C = 20;
                salaire = 10;
                participation = C + salaire + 10 * nbmenfant;
                if (participation >50)
                {
                    participation = 50;
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                } 
                else
                {                    
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                }
            }

            else if (statut == "C" & salaire > 1200)
            {
                C = 20;
                salaire = 0;
                participation = C + salaire + 10 * nbmenfant;
                if (participation > 50)
                {
                    participation = 50;
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                }
                else
                {
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                }
            }

            else if (statut == "M" & salaire < 1200)
            {
                M = 25;
                salaire = 10;
                participation = M + salaire + 10 * nbmenfant;
                if (participation > 50)
                {
                    participation = 50;
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                }
                else
                {
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                }
            }


            else if (statut == "M" & salaire > 1200)
            {
                M = 25;
                salaire = 0;
                participation = M + salaire + 10 * nbmenfant;
                if (participation > 50)
                {
                    participation = 50;
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                }
                else
                {
                    Console.WriteLine("La participation de votre patron est de " + participation + "%");
                }
            }


            
            if (statut != "C" & statut != "M")
            {
                Console.WriteLine("statut non valide , recommencez ");
            }
            Console.ReadLine();


        }
    }
}
