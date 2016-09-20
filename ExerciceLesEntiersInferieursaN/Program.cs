using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLesEntiersInferieursaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string sti; 

            Console.Write("****les entiers inferieurs a N  (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();


           
            Console.WriteLine("Choisissez un chiffre");
            sti = Console.ReadLine();
            i = Convert.ToInt32(sti);
            while (i != -1)
            {
                Console.WriteLine( "{0}",i);
                i--;
            }
           
            Console.ReadLine();
        }
    }
}
