using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int imaxi;
            int imini;
          
            Console.Write("****  maxi et mini  (V1.0, 12 / 07 / 2016) ****");
            Console.WriteLine();

            imaxi = 0;
            imini = 0;  
            i = 1;
            while (i != 0)
            {
                Console.WriteLine("Entrez des chiffres ");
                i = Convert.ToInt32(Console.ReadLine());
                if (imaxi == 0 & imini == 0)
                {
                    imaxi = i;
                    imini = i;
                }
                if (i > imaxi)
                {
                    imaxi = i;
                }
                if (i < imini & i != 0)
                {
                    imini = i;
                }
            }         
        

            Console.WriteLine(" le nombre maxi est : " + imaxi+  " le nombre mini est : " +imini);
            Console.ReadLine();
        }
    }
}
