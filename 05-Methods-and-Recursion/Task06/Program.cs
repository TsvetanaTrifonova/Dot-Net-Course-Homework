using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        //Напишете програма, която рекурсивно изчислява фактуриел.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, please:");
            int myNumber = int.Parse(Console.ReadLine());
            decimal factorial = Facturial(myNumber);
            Console.WriteLine(factorial);     
        }

        private static decimal Facturial(int n)
        {
            // The bottom of the ricursion
            if (n == 0)
            {
                return 1;
            }
            //Recursive call
            else
            {
                return n * Facturial(n - 1);
            }
        }

    }
}

