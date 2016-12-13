using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която приема 2 символни низа (string)като вход, 
            //и изведете като резултат конкатениран string със „|“ между двата входни низа.
            string firstString;
            string secondString;

            Console.WriteLine("Wtite first string: ");
            firstString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wtite second string: ");
            secondString = Convert.ToString(Console.ReadLine());
            Console.WriteLine(firstString + "|" + secondString);
        }
    }
}
