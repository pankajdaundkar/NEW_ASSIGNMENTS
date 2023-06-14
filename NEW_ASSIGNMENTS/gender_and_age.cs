using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NEW_ASSIGNMENTS
{
    internal class gender_and_age
    {//5. Depending on age (decimal number and gender (m / f), print a personal title:

//“Mr.” – a man(gender “m”) – 16 or more years old.
//“Master” – a boy (gender “m”) under 16 years.
//“Ms.” – a woman(gender “f”) – 16 or more years old.
//“Miss” – a girl (gender “f”) under 16 years.
        static void Main(string[] args)
        {
            int age;
            char gender;

            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select gender");
            gender = Convert.ToChar(Console.ReadLine());

            if (age >= 16 && gender == 'M')
            {
                Console.WriteLine("The gender is man [Mr]");

            }
            else if (age <= 16 && gender == 'M')
            {
                Console.WriteLine("The gender is boy [Master]");

            }
            else if (age >= 16 && gender == 'F')
            {
                Console.WriteLine("The gender is women [Mrs]");
            }
            else if (age <= 16 && gender == 'F')
            {
                Console.WriteLine(" The gender is women [Miss]");
            }
            else
            {
                Console.WriteLine(" ");
            }


        }
    }
}
