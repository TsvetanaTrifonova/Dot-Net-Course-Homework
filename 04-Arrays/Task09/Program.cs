using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали един масив е симетричен.
            int length;
            int myN;
            bool symmetric = true;

            Console.Write("Enter a length of array >0: ");
            length = int.Parse(Console.ReadLine());
            while (length <= 0)
            {
                Console.Write("Enter a length of array >0: ");
                length = int.Parse(Console.ReadLine());
            }
            int[] arrA = new int[length];

            //въвеждаме елементите на А
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("For ArrA enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            //Проверка за симетрия
            for (int i = 0; i < arrA.Length; i++)
            {
                myN = arrA.Length - 1 - i;


                if (arrA[i] != arrA[myN]) 
                {
                    symmetric = false;
                    break;
                }

                if (i > myN)
                {
                    Console.WriteLine("*");
                    break;
                }

            }

            //Резултат
            if (symmetric)
            {
                Console.WriteLine("The Array is symmetric");
            }
            else
            {
                Console.WriteLine("The Array is NOT symmetric");
            }
        }
    }
}
