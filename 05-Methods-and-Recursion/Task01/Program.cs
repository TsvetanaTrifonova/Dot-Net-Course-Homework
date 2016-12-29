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
            //Създайте метод MaxNumber() с два целочислени(int) параметъра, който връща по - голямото от двете числа.
            //Напишете програма, която прочита три цели числа от конзолата и отпечатва най - голямото от тях,използвайки метода MaxNumber().
            Console.WriteLine("Enter first number:");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var secondNumber = int.Parse(Console.ReadLine());

            int maxNumber = MaxNumber(firstNumber, secondNumber);
            Console.WriteLine("The Max number is:"+MaxNumber(firstNumber, secondNumber));
            Console.WriteLine("");
            Console.WriteLine("Now we will try the same with three numbers.");


            Console.WriteLine("Enter first number:");
            var numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var numberB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var numberC = int.Parse(Console.ReadLine());

            Console.WriteLine("The Max number is:" + MaxNumber(numberA, numberB, numberC));

        }

        private static int MaxNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber> secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
             }
        }

        private static int MaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
          return  Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
        }
    }
    
}
