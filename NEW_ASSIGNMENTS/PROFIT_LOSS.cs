using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_ASSIGNMENTS
{///1. Write a C# Sharp program to calculate profit and loss on a transaction

    internal class PROFIT_LOSS
    {
        static void Main(string[] args)
        {
            int cost , sell, pl;
            Console.WriteLine("calculate profit and loss");
                
            Console.WriteLine("enter cost prise");
            cost = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter selling prise");
            sell = Convert.ToInt32(Console.ReadLine());

            if (sell > cost)
            {
                pl = sell - cost;
                Console.WriteLine("you get profit" + pl);
            }
            else if (cost > sell)
            {
                pl = cost - sell;
                Console.WriteLine("you get loss " + pl);
            }
            else
            {
                Console.WriteLine("you dont get profit or loss");
            }



        }
    }
}
