using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace exo_pendu
{
    class Program
    {
        static void dessin(int pouet)
        {
            switch (pouet)
            {
                case 0:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    Console.WriteLine("- | -");
                    Console.WriteLine("  |");
                    Console.WriteLine(" / \\");
                    Console.WriteLine("Ne scie pas la branche sur laquelle tu es assis, à moins qu'on ne veuille t'y pendre.");
                    Console.WriteLine("La prochaine fois scie la branche car aujourd'hui tu es pendu!!");
                    break;

                case 1:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    Console.WriteLine("- | -");
                    Console.WriteLine("  |");
                    Console.WriteLine(" / \\");
                    break;
                case 2:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    Console.WriteLine("- | -");
                    Console.WriteLine("  |");
                    Console.WriteLine(" /");
                    break;
                case 3:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    Console.WriteLine("- | -");
                    Console.WriteLine("  |");
                    break;
                case 4:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    Console.WriteLine("- | -");

                    break;
                case 5:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    Console.WriteLine("- |");
                    break;
                case 6:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    Console.WriteLine("  |");                    
                    break;
                case 7:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  O");
                    break;
                case 8:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    break;
                case 9:
                    Console.WriteLine("__");
                    Console.WriteLine("  |");
                    break;
                case 10:
                    Console.WriteLine("__");
                    break;
                case 11:
                    Console.WriteLine("_  ");
                    break;

            }
        }

        static void Main(string[] args)
        {
            string joueur1;
            string joueur2;
            string LettreSaisie;
            string MotATrouver;
            int NombreDeVieRestante = 11;
            bool validationjoueur1 = false;
            bool validationjoueur2 = false;
            bool validationmotsecret = false;
            bool validationlettre = false;


            do
            {
                Console.WriteLine("Nom du joueur 1");
                joueur1 = Console.ReadLine();
                string lettresok = @"^[a-z]{2,50}$";
                if (Regex.IsMatch(joueur1, @lettresok))
                {
                    validationjoueur1 = true;
                }
                else
                    Console.WriteLine("Saisissez un nom valide (a-Z)");
            }
            while (validationjoueur1 == false);
            do
            {
                Console.WriteLine("Nom du joueur 2");
                joueur2 = Console.ReadLine();
                string lettresok = @"^[a-z]{2,50}$";
                if (Regex.IsMatch(joueur2, @lettresok))
                {
                    validationjoueur2 = true;
                }
                else
                    Console.WriteLine("Saisissez un nom valide (a-Z)");
            }
            while (validationjoueur2 == false);

            do
            {
                Console.WriteLine(joueur1 + " Saisissez un mot de dix lettres ou moins");
                MotATrouver = Console.ReadLine();
               
                string lettresok = @"^[a-z]{1,10}$";
                if (Regex.IsMatch(MotATrouver, @lettresok))
                {
                    validationmotsecret = true;
                    Console.Clear();
                }
                else
                    Console.WriteLine("Saisissez un mot valide (a-Z) et de moins de dix lettres");
            }
            while (validationmotsecret == false);



            string[] Mot = new string[MotATrouver.Length];
            string[] ARemplir = new string[MotATrouver.Length];


            int j = 0;
            int erreur = 1;
            string listelettreerreur = "";
            bool gagne = false;


            for (int k = 0; k < MotATrouver.Length; k++)
            {
                Mot[k] = MotATrouver.Substring(k, 1);
                ARemplir[k] = "_";

            }



            while (erreur < 12 && !gagne)
            {
                validationlettre = false;
                do
                {
                    Console.WriteLine(joueur2 + " Saisissez une lettre");
                    LettreSaisie = Console.ReadLine();
                    string lettresok = "^[a-z]$";
                    if (Regex.IsMatch(LettreSaisie, @lettresok) && LettreSaisie.Length == 1)
                    {
                        validationlettre = true;
                    }
                    else
                        Console.WriteLine("Saisissez une lettre valide (a-Z)");
                }
                while (validationlettre == false);
                bool perdunevie = true;


                j = 0;
                while (j < MotATrouver.Length)
                {
                    if (LettreSaisie == Mot[j])
                    {

                        ARemplir[j] = Mot[j];
                        perdunevie = false;
                    }

                    j++;
                }

                Console.Clear();
                if (perdunevie == true)
                {
                    listelettreerreur += LettreSaisie;
                    Console.WriteLine(LettreSaisie + " ne se trouve pas dans le mot a trouver");
                    erreur++;
                    NombreDeVieRestante--;
                    dessin(NombreDeVieRestante);

                }

                
                Console.WriteLine("précédent échec " + listelettreerreur);
                Console.WriteLine("Nombre de vie restante " + NombreDeVieRestante);
                

                gagne = true;
                for (int i = 0; i < ARemplir.Length; i++)
                {
                    if (ARemplir[i] == "_")
                    {
                        gagne = false;
                    }
                    Console.Write(ARemplir[i]);
                }

                Console.WriteLine();


            }
            if (gagne)
                Console.WriteLine("You WIN");

            else
                Console.WriteLine("NOOB , you LOOSE");

            Console.ReadLine();








        }
    }
}
