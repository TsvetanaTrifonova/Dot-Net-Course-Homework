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
            //Напишете програма, която по избор на потребителя прочита от конзолата променлива от тип int, double или string.
            //Ако променливата е int или double, трябва да се увеличи с 1.Ако променливата е string, трябва да се прибави накрая символа "*".
            //Отпечатайте получения резултат на конзолата. 
            Console.WriteLine("Enter your Choice: \n I - for integer, D - for real number or S - for string");
            char str = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (str)
            {
                case 'I':
                    //Console.WriteLine("Enter number");
                    //int number = int.Parse(Console.ReadLine());
                    //Console.WriteLine(++number);
                    //break;

                case 'D':
                    Console.WriteLine("Enter real number");
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(++realNumber);
                    break;

                case 'S':
                    Console.WriteLine("Enter a text");
                    string myText = Console.ReadLine();
                    Console.WriteLine(myText + "*");
                    break;

                default:
                    Console.WriteLine("Your choice is not correct");
                    break;
            }
        }
    }
}
