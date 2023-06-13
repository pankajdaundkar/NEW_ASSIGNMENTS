using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_ASSIGNMENTS
{//3. Write C# Program to check uppercase or lowercase alphabets

    internal class uppercase_lowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter alphabet");
            char alp = Convert.ToChar(Console.ReadLine());

            if (alp >= 'A' && alp <= 'Z')
            {
                Console.WriteLine(alp + " is uppercase");
            }
                
            else if (alp >= 'a' && alp <= 'z')
            {
                Console.WriteLine(alp + " is lowercase");
                
            }
            else
            {
                Console.WriteLine(alp + " is not alphabet");
            }
        }
    }
}
