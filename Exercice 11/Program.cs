using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            string saisie2;
            double PU;
            double QTECOM;
            double TOT;
            double port;
            double PAP;
            double remise;


            Console.Write("****Remise  (V1.0, 11 / 07 / 2016) ****");
            Console.WriteLine();

            Console.WriteLine("Saisissez le prix unitaire du produit: ");
            saisie = Console.ReadLine();
            PU = Convert.ToDouble(saisie);

            Console.WriteLine("Saisissez la quantite souhaitee: ");
            saisie2 = Console.ReadLine();
            QTECOM = Convert.ToDouble(saisie2);


            TOT = PU * QTECOM;

            if (TOT > 500)
            {
                port = 0;
                remise = (TOT * 0.1);
                PAP = (TOT - remise);
                Console.WriteLine("les frais de port sont de  : " + 0 + "%");
                Console.WriteLine("la remise est de  : " + 10 + "%");
                Console.WriteLine("le prix est de : " + PAP + "euros");
            }

            else if (TOT >= 100 & TOT <= 200)
            {
                port = (TOT * 0.02);
                remise = (TOT * 0.05);

                if (port < 6)
                {
                    port = 6;

                    PAP = (TOT - remise) + port;
                    Console.WriteLine("les frais de port sont de  : " + 6 + "euros");
                    Console.WriteLine("la remise est de  : " + 5 + "%");
                    Console.WriteLine("le prix est de : " + PAP + "euros");
                }

                else
                {
                    PAP = (TOT - remise) + port;
                    Console.WriteLine("les frais de port sont de  : " + port + "euros");
                    Console.WriteLine("la remise est de  : " + remise + "euros");
                    Console.WriteLine("le prix est de : " + PAP + "euros");
                }
            }
            else if (TOT > 200 & TOT <= 500)
            {
                port = (TOT * 0.02);
                remise = (TOT * 0.1);
                if (port < 6)
                {
                    port = 6;

                    PAP = (TOT - remise) + port;
                    Console.WriteLine("les frais de port sont de  : " + 6 + "euros");
                    Console.WriteLine("la remise est de  : " + 5 + "%");
                    Console.WriteLine("le prix est de : " + PAP + "euros");

                }
                else
                {
                    PAP = (TOT - remise) + port;
                    Console.WriteLine("les frais de port sont de  : " + port + "euros");
                    Console.WriteLine("la remise est de  : " + remise + "euros");
                    Console.WriteLine("le prix est de : " + PAP + "euros");
                }
            }
            else if (TOT < 100)
            {
                port = 6;
                PAP = (TOT + port);
                Console.WriteLine("les frais de port sont de  : " + port + "euros");
                Console.WriteLine("le prix est de : " + PAP + "euros");
            }

                    Console.ReadLine();

                }
            }
          }

