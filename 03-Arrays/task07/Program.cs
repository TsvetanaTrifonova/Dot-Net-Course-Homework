using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Прекопирайте един масив от цели числа в друг масив.
            int length;

            Console.Write("Enter a length of array >0: ");
            length = int.Parse(Console.ReadLine());
            while (length <= 0)
            {
                Console.Write("Enter a length of array >0: ");
                length = int.Parse(Console.ReadLine());
            }
            int[] arrA = new int[length];
            int[] arrB = new int[length];
            //въвеждаме елементите на А
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("For ArrA enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }
            //прекопираме елементите на А в B
            for (int i = 0; i < arrA.Length; i++)
            {
                arrB[i] = arrA[i];
            }
            Console.WriteLine("");
            //Визуализираме елементите на В
            for (int i = 0; i < arrB.Length; i++)
            {
                //Console.WriteLine("ArrB element " + i + ": " + arrB[i]);
                Console.Write("ArrB element {0}: ", i);
                Console.WriteLine(arrB[i]);
            }
        }
    }
}
