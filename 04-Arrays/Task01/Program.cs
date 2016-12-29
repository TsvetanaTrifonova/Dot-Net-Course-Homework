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
            //Напишете програма, която намира сбора на всичките четни елементи в масив.
            int sumEven = 0;
            int[] ourArray = { 20, 25, 3451, 82, 232, 5465346, 4 };

            foreach (int number in ourArray)
            {
                if (number % 2 == 0)
                {
                    sumEven = sumEven + number;
                }
                else continue;              
            }
            Console.WriteLine(sumEven);
        }
    }
}
