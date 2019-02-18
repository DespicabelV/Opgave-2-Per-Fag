using System;
using System.Threading;

namespace Opgave_2_Per_Fag
{
    class Program
    {
        static void Main(string[] args)
        {
            string navn, adresse, bynavn;
            int postnr, antal;
            double pris, rabat_pris, moms_pris, rabat_ialt, moms_ialt, pris_ialt;
            double moms = 1.25;
            double rabat = 0.95;

            Console.WriteLine("What is your full name?");
            navn = Console.ReadLine();
            Console.WriteLine("What is the name of the city you live in?");
            bynavn = Console.ReadLine();
            Console.WriteLine("What zip code does the city you live in have?");
            postnr = int.Parse(Console.ReadLine());
            Console.WriteLine("And on what adresse do you live in that city?");
            adresse = Console.ReadLine();

            Console.WriteLine("So how many do you want to buy, and you can ofcourse only buy in whole numbers");
            antal = int.Parse(Console.ReadLine());
            if (antal >= 10)
            {
                Console.WriteLine("Lucky for you we are running a sale where you get a 5% discound when you buy more then 10");
            }

            Console.WriteLine("I cant remeber the price, what was it again?");
            pris = double.Parse(Console.ReadLine());
            Console.WriteLine("Great, now let me just print you a Faktura");

            pris_ialt  = pris * antal;

            if (antal >= 10)
            {
                 rabat_pris = pris_ialt * 0.05;
                 rabat_ialt = pris_ialt * rabat;
            }
            else
            {
                 rabat_pris = 0;
                 rabat_ialt = pris_ialt;
            }
            moms_pris  = rabat_ialt * 0.25;
            moms_ialt  = rabat_ialt * moms;

            Console.WriteLine("" +
                " __________________________________________________\n" +
                "|                    Faktura                       \n" +
                "| Name   : {0}                                     \n" +
                "| Adresse: {1}                                     \n" +
                "| City   : {2} {3}                                 \n" +
                "|                                                  \n" +
                "| Number of items: {4}                             \n" +
                "| Price          : {5}                             \n" +
                "|                                                  \n" +
                "|                                                  \n" +
                "|--------------------------------------------------\n" +
                "| Price w/o discount: {6:0.00}                     \n" +
                "| Your saving is    : {7:0.00}                     \n" +
                "| Price w/ discount : {8:0.00}                     \n" +
                "| Tax               : {9:0.00}                     \n" +
                "| Price w/ Tax      : {10:0.00}                    \n" +
                "|          Thank you for shopping whit us          \n" +
                "|                 Have a nice day                  \n" +
                "|__________________________________________________", 
                navn, adresse, postnr, bynavn, antal, pris, pris_ialt, rabat_pris, rabat_ialt, moms_pris, moms_ialt);
        }
    }
}
