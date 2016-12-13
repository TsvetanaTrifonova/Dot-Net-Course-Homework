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
            int firstNumber;
            int secondNumber;
            Console.WriteLine("firstNumber:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("secondNumber:");
            secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = firstNumber + secondNumber;
            Console.WriteLine("The Result Is:");
            Console.WriteLine(thirdNumber);

        }
    }
}
