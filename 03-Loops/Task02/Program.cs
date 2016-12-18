using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят на 3 и 7.Числото N се въвежда от конзолата.
            int number;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (i % 7 != 0 || i % 3 != 0)
                {
                     Console.WriteLine(i);
                }
                continue;
            }

        }
    }
}
