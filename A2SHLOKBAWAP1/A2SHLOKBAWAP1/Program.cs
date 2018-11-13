using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SHLOKBAWAP1
{
    class Program
    {
        static int fees;
        static void Main(string[] args)
        {
            Console.WriteLine("press Y if you are a canadian citizen student else press N if you are an international student");
            string C = Console.ReadLine();
            Console.WriteLine("Enter the age");
            string age = Console.ReadLine();
            int a = int.Parse(age);
            
            if (C == "Y" && a <= 18)
            {
                Console.WriteLine("CANADIAN CITIZEN STUDENT");
                 fees = 300 + 39;
                Console.WriteLine("Total fees with 13% HST is " + fees);
            }
            if (C == "Y" && a > 18 && a < 50)
            {
                Console.WriteLine("CANADIAN CITIZEN STUDENT");
                 fees = 500 + 65;
                Console.WriteLine("Total fees with 13% HST is " + fees);
            }
            if (C == "Y" && a > 50)
            {
                Console.WriteLine("CANADIAN CITIZEN STUDENT");
                 fees = 400 + 52;
                Console.WriteLine("Total fees with 13% HST is " + fees);
            }
            else if (C == "N" && a <= 18)
            {
                Console.WriteLine("INTERNATIONAL STUDENT");
                 fees = 300 + 100 + 39;
                Console.WriteLine("Total fees with 13% HST is " + fees);
            }
            else if (C == "N" && a > 18 && a < 50)
            {
                Console.WriteLine("INTERNATIONAL STUDENT");
                 fees = 500 + 100 + 65;
                Console.WriteLine("Total fees with 13% HST is " + fees);
            }
            if (C == "Y" && a > 50)
            {
                Console.WriteLine("INTERNATIONAL STUDENT");
                 fees = 400 + 100 + 52;
                Console.WriteLine("Total fees with 13% HST is " + fees);
            }
            Console.WriteLine("enter Registeration month:");
            Console.WriteLine("1.FALL(september,october,november,december)");
            Console.WriteLine("2.WINTER(january, february, march, april)");
            Console.WriteLine("3.SUMMER(may, june, july, august)");
            string choice = Console.ReadLine();
            int choicee = int.Parse(choice);
            double regfees;
            switch (choicee)
            {
                case 1:
                    regfees = 250 + 32.5;
                    Console.WriteLine("REGISTRATION FEES FOR SEMESTER $" + regfees);
                    double Final = fees + regfees;
                    Console.WriteLine("FINAL TOTAL FEES $" + Final);
                    break;
                case 2:
                    regfees = 220 + 28.6;
                    Console.WriteLine("REGISTRATION FEES FOR SEMESTER $" + regfees);
                    Final = fees + regfees;
                    Console.WriteLine("FINAL TOTAL FEES $" + Final);
                    break;
                case 3:
                    regfees = 150 + 19.5;
                    Console.WriteLine("REGISTRATION FEES FOR SEMESTER $" + regfees);
                    Final = fees + regfees;
                    Console.WriteLine("FINAL FEES $" + Final);
                    break;
                default:
                    Console.WriteLine("please select appropriate option");
                    break;
            }
        }
    }
}
