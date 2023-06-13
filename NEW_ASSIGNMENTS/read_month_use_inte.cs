using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_ASSIGNMENTS
{//2. Write C# Sharp program to read any Month Number in integer and display Month name(use switch case
    internal class read_month_use_inte
    {
        static void Main(string[] args)
        {
         Console.WriteLine("enter any number");

            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("january");
                    break;
                case 2:
                    Console.WriteLine("february");
                    break;
                case 3:
                    Console.WriteLine("march");
                    break;
                case 4:
                    Console.WriteLine("april");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("june");
                    break;
                case 7:
                    Console.WriteLine("jully");
                    break;
                case 8:
                    Console.WriteLine("aug");
                    break;
                case 9:
                    Console.WriteLine("sept");
                    break;
                case 10:
                    Console.WriteLine("oct");
                     break;
                 case 11:
                    Console.WriteLine("nov");
                    break;
                case 12:
                    Console.WriteLine("dec");
                    break;
                default: Console.WriteLine("invalid option");
                    break;
        }
        }
    }
}
