using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("*** version 25/07/2015  chiffre magique");
                    
            Console.WriteLine("Bonjour , Allez vous trouver le chiffre magique , entrez un nombre");

            Random alea = new Random();
            int nb = alea.Next(1, 100);

            i = 0;
            while(i!=nb)
            { 
                Console.WriteLine("");
                i = Convert.ToInt32(Console.ReadLine());

                
                if (i<nb)
                {
                    Console.WriteLine("entrez un chiffre plus grand");
                }
                if (i>nb)
                {
                    Console.WriteLine("entrez un chiffre plus petit");
                }
                
            }
            Console.WriteLine("GG");
            Console.ReadLine();
        }
    }
}



























/* int i;


Console.Write("****nombre magique (V1.0, 25 / 07 / 2016) ****");
            Console.WriteLine();
           
           

            Random alea = new Random();
int nb = alea.Next(1, 100);

i = 0;
            while (i!=nb)
            {

                Console.WriteLine("Quel est le chiffre magique?! Saisissez un nombre entre 1 et 100");
                i = Convert.ToInt32(Console.ReadLine());

                if (i<nb)
                { Console.WriteLine("entrez un nombre plus grand");
                    
                }

                if (i > nb)
                {
                    Console.WriteLine("entrez un nombre plus petit");
                    
                }


            }
                            
                Console.Write("GG");

            
            Console.ReadLine();*/
