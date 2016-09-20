using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisieprenom;
            

            string[] tabprenom;
            tabprenom = new string[20] { "sebastien", "aurélien", "cindy", "gaetan", "christophe", "xavier", "arnaud", "quentin", "malik", "clement", "manu", "mathieu", "françois", "régis", "scarlett", "mégane", "camille", "amandine", "jean", "paul" };
           
            Console.WriteLine("Saisissez un prénom d'un membre de la formation");
            saisieprenom = Console.ReadLine();

            int position = -1;
            for (int i = 0; i < tabprenom.Length; i++)
            {
                if (tabprenom[i] == saisieprenom)
                {
                    position = i;
                }
            }

            if (position!= -1)
            {
                Console.WriteLine("Trouvé en position " + position);
                for (int i = position; i < tabprenom.Length-1; i++)
                {
                    tabprenom[i] = tabprenom[(i + 1)];
                    //Console.WriteLine(i);
                                   
                    
                                                                        
                }
                tabprenom[(tabprenom.Length - 1)] = "";
                Console.ReadLine();
            }

            Console.WriteLine(tabprenom);

        }
    }
}
