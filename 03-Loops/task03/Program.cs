using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата поредица от цели числа(примерно 5 числа) и отпечатва най - малкото и най-голямото от тях.
            int min;
            int max;
            int myNumber;

            Console.WriteLine("Моля, въведете число");
            min = int.Parse(Console.ReadLine());
            max = min;
            
            for (int i = 0; i < 4; i++)
            {
               Console.WriteLine("Моля, въведете число");
               myNumber = int.Parse(Console.ReadLine());
                if (myNumber < min)
                {
                    min = myNumber;
                }
                if (myNumber > max)
                {
                    max = myNumber;
                }
            }
            Console.WriteLine("Най-малкото число е: " + min);
            Console.WriteLine("Най-голямото число е: " + max);
        }
    }
}
