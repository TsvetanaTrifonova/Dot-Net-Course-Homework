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
            // Напишете програма, която изчислява бонус точки на база резултат от игра. 
            // Потребителят трябва да въведе своите точки в интервалa[1; 9].
            // Ако точките са в интервала[1; 3], добавете 5 към тях. Ако точките са в интервала[4; 6], умножете ги по 12.
            // Ако точките са в интервала[7; 9], умножете ги по 50 и ги разделете целочислено на 3.Резултатът изведете на екрана.
            Console.WriteLine("Enter Number from 1 to 9:");
            int myNumber = int.Parse(Console.ReadLine());

            if (myNumber >= 1 && myNumber <= 3)
            {
                Console.WriteLine("The result is: " + (myNumber + 5));
            }
            else if (myNumber >= 4 && myNumber <= 6)
            {
                Console.WriteLine("The result is: " + myNumber * 12);
            }
            else if (myNumber >= 7 && myNumber <= 9)
            {
                Console.WriteLine("The result is: " + (myNumber * 50 % 3));
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
        }
    }
}
