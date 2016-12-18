using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N). *

            int dividend;
            int divisor;
            int factorielDividend = 1;
            int factorielDivisor = 1;
            int finalResult;

            Console.Write("Моля, въведете фактуриел числител N: ");
            dividend = int.Parse(Console.ReadLine());

            while (dividend < 1)
            {
                Console.WriteLine("Въведете число, което е >= 1! ");
                Console.WriteLine();
                Console.Write("Моля, въведете фактуриел числител N: ");
                dividend = int.Parse(Console.ReadLine());
            }

            Console.Write("Моля, въведете фактуриел знаменател K: ");
            divisor = int.Parse(Console.ReadLine());

            while (divisor < 1 || divisor >= dividend)
            {
                Console.WriteLine("Въведете число, което е >= 1 и е < " + dividend + "!");
                Console.WriteLine();
                Console.Write("Моля, въведете фактуриел знаменател K: ");
                divisor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("N = " + dividend);
            Console.WriteLine("K = " + divisor);
            Console.WriteLine();

            for (int i = 1; i <= dividend; i++)
            {
                factorielDividend = i * factorielDividend;
            }

            for (int i = 1; i <= divisor; i++)
            {
                factorielDivisor = i * factorielDivisor;
            }

            Console.WriteLine("N! =  " + factorielDividend);
            Console.WriteLine("K! = " + factorielDivisor);
            finalResult = factorielDividend / factorielDivisor;
            Console.WriteLine("N!/K! = " + finalResult);
        }
    }
}
