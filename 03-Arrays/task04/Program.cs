using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която търси число в масив от числа и връща индекса на първото намерено число.
            bool canNotFind = true;
            int toFind;
            int[] ourArray = { 20, 25, 3451, 82, 232, 5465346, 4 };
            Console.Write("Enter int number to find: ");
            toFind = int.Parse(Console.ReadLine());
            for (int i = 0; i < ourArray.Length; i++)
            {
                if (ourArray[i] == toFind)
                {               
                    Console.WriteLine("\nThe index of the number is " + i);
                    canNotFind = false;
                    break;
                }                               
            }
            if (canNotFind) Console.WriteLine("\nOurArray Does not contain this number.");
        }
    }
}
