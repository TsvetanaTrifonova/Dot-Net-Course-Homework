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
            //Напишете програма, която попълва числата на Фибоначи в масив. Потребител въвежда колко да е голям масива.
            int length;
            
              Console.Write("Enter a length of array >0: ");
               length = int.Parse(Console.ReadLine());
            while (length<=0)
            {
                Console.Write("Enter a length of array >0: ");
                length = int.Parse(Console.ReadLine());
            }
            int[] arr = new int[length];

            arr[0] = 0;
            arr[1] = 1;
            Console.WriteLine("Show " + length + " Fibonacci numbers:");
            for (int i = 2; i < arr.Length; i++)
            {

                arr[i] = arr[i-1] + arr[i-2];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
