using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Таск06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която намира най-често срещания елемент в масив. Нека максималната стойност на елементите в масива да е 100.
            int find = 0;
            int maxArrB = 0;
            int maxI = 0;
            int count = 0;
            int length;

            Console.Write("Enter a length of array >0: ");
            length = int.Parse(Console.ReadLine());

            int[] arrA = new int[length];
            int[] arrB = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrA.Length; i++)
            {
                find = arrA[i];
                for (int j = 0; j < arrA.Length; j++)
                {
                    if (arrA[j] == find)
                    {
                        count = count + 1;
                    }
                }
                arrB[i] = count;
                count = 0;
            }

            for (int i = 0; i < arrB.Length; i++)
            {
                if (maxArrB < arrB[i])
                {
                    maxArrB = arrB[i];
                    maxI = i;
                }
            }
            //Console.WriteLine(maxArrB);
            //Console.WriteLine(maxI);

            Console.WriteLine(arrA[maxI] + " was find " + maxArrB + " tims");

        }
    }
}
