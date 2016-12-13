using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете проргама която приема 2 целочислени числа за вход и извежда остатъка от делението на числата.
            int a;
            int b;


            Console.Write("a = ");
            a = Convert.ToByte(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToByte(Console.ReadLine());
            int s = a % b;
            Console.WriteLine("Остатъка от делението на числата  " + a +" и " +b + " е "+ s);
        }
    }
}
