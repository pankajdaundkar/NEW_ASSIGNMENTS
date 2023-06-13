using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* A student has to travel n kilometers. He can choose between three types of transportation:
Taxi. Starting fee: 5 INR/KM. Day rate: 8 INR/km. Night rate: 9 INR/km.
Bus. Day / Night rate: 9 EUR/km. Can be used for distances of minimum 20 km.
Train. Day / Night rate: 6 EUR/km. Can be used for distances of minimum 100 km.
Write a program that reads the number of kilometers n and period of the day (day or night) 
and calculates the fare amount
 */
namespace SwitchCase
{
    internal class Transportation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Taxi");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Train");
            Console.WriteLine("Select any one number to perform the operation.");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter KM:");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Day/Night");
            char time = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 1:

                    if (time == 'd')
                    {
                        Console.WriteLine("Available");
                        double day_charge = (km * 8) + 5;
                        Console.WriteLine("Day Charges is :" + day_charge);
                    }
                    else if (time == 'n')
                    {
                        double night_charge = (km * 9) + 5;
                        Console.WriteLine("Night Charge is :" + night_charge);
                    }
                    else
                    {
                        Console.WriteLine("Not Available.");
                    }
                    break;

                case 2:
                    if (km >= 20 && time == 'd')
                    {
                        Console.WriteLine("Available");
                        double day_charge1 = km * 9;
                        Console.WriteLine("Day Charges is :" + day_charge1);
                    }
                    else if (km > 20 && time == 'n')
                    {
                        double night_charge1 = km * 9;
                        Console.WriteLine("Night Charge is :" + night_charge1);
                    }
                    else
                    {
                        Console.WriteLine("Not Available.");
                    }
                    break;

                case 3:
                    if (km >= 100 && time == 'd')
                    {
                        Console.WriteLine("Available");
                        double day_charge2 = km * 9;
                        Console.WriteLine("Day Charges is :" + day_charge2);
                    }
                    else if (km > 20 && time == 'n')
                    {
                        double night_charge2 = km * 9;
                        Console.WriteLine("Night Charge is :" + night_charge2);
                    }
                    else
                    {
                        Console.WriteLine("Not Available.");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error!!!!");
                        break;
                    }

            }
        }
    }
}