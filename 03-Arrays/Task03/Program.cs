using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която създава масив с 10 елемента от целочислен тип и инициализира елементите със стойност индекса  умножен по 10.
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i * 10;
                //Console.WriteLine(arr[i]); 
            }
            foreach (int number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }
}
