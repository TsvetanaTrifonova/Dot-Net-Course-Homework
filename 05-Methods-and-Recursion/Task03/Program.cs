using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте фунцкия, която приема 3 параметъра - цели числа и ги умножава едно с друго.Извикайте функцията 10 пъти с рандом генерирани параметри.
            //Изведете резултата на екрана
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " time:");
                int firstNumber = rand.Next(1, 10);
                Console.WriteLine(firstNumber);
                int secondNumber = rand.Next(1, 10);
                Console.WriteLine(secondNumber);
                int thirdNumber = rand.Next(1, 10);
                Console.WriteLine(thirdNumber);

                Console.WriteLine("The Production is:" + Production(firstNumber, secondNumber, thirdNumber));
                Console.WriteLine();
            }
        }

        private static int Production(int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber * secondNumber * thirdNumber;
        }

    }
}
