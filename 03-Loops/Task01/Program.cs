using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която за дадени две числа, намира най - големия им общ делител.
            int a;
            int b;
            Console.WriteLine("Enter a number one");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number two");
            b = int.Parse(Console.ReadLine());

            //Wariant 1
            int temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            //Wariant 2
            //while (a!=b)
            //{
            //    if (a>b)
            //    {
            //        a = a - b;
            //    }
            //    else
            //    {
            //        b = b - a;
            //    }
            //}

            Console.WriteLine(a);
    
        }
    }
}
