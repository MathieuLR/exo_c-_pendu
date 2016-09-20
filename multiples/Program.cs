using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiples
{
    class Program
    {
        static void Main(string[] args)
        {   int i;
            int n;
            int x;


            Console.Write("**** les 7 Numero premiers multiples de 5 (V1.0, 07 / 07 / 2016) ****");
            Console.WriteLine();

            Console.WriteLine("Entrez un chiffre ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un chiffre ");
            x = Convert.ToInt32(Console.ReadLine());


            i = 1;
            while (i <= n )
            {
                Console.WriteLine("la multiplication de : " + i + " * " + x + " = " +(i*x));
                i++;
              
            }
           
            Console.ReadLine();




        }
    }
}
