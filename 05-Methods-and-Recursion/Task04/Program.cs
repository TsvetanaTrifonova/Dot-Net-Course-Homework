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
            //Дефинирайте функция, която приема един параметър – число, и принтира на екрана "четно", ако числото е четно, и "нечетно", ако числото е нечетно.
            //Демонстрирайте действието на фукцията с няколко примера

            Console.WriteLine("Please, enter a number:");
            int enteredNumber = int.Parse(Console.ReadLine());

            IsEven(enteredNumber);
        }   
        private static void IsEven(int myNumber)
        {
            if (myNumber%2==0)
            {
                Console.WriteLine("Even");
            }else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
