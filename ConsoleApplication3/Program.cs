using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void multiplication(int nombre)
        {
            int resultat;
            int i;


            for (i = 0; i <= 10; i++)
            {
                resultat = (nombre * i);
                Console.WriteLine(+nombre + " * " + i + " = " + resultat);
                
            }
            Console.ReadLine();
        }
             
        static void Main(string[] args)
        {
            int nombre;

            Console.WriteLine("entrez un nombre");
            nombre = Int32.Parse(Console.ReadLine());
            multiplication(nombre);
            Console.ReadLine();

        }
    }
}
