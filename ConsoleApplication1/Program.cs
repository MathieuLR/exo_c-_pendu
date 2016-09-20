using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmb;
            int d;
            int test;

            int i;
            Console.Write("****les nombres premier (V1.0, 22 / 07 / 2016) ****");
            Console.WriteLine();

                     
             Console.WriteLine("Entrez un nombre entier pour savoir si il s'agit d'un nombre premier");
             nmb = Convert.ToInt32(Console.ReadLine());
            /* d = nmb - 1;
             test = nmb / d;
             */
            i = 1;

            
            if (nmb == 1)
            {
                Console.WriteLine(nmb + " est 1er");
                Console.ReadLine();
                return;
            }
             do
                    {
                        i++;
                //Console.WriteLine("test pour "+i+" : " + nmb % i);
                if (i == nmb)
                        {
                            Console.WriteLine(nmb + " est 1er");
                            Console.ReadLine();
                            return;
                        }
                    } while (nmb %i!= 0) ;
                    Console.WriteLine(nmb + " est pas 1er");
                    Console.ReadLine();





                }

             
             
            }
    }