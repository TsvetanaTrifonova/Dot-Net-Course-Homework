using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която обръща стойностите на един масив.
            int length;
            int myN;
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
            //преОбръщаме елементите на А в B  
                     
            for (int i = 0; i < arrA.Length; i++)
            {
                myN = arrA.Length-1 - i;
                arrB[i] = arrA[myN];
                //Console.WriteLine(myN);
            }
            Console.WriteLine("");

            //преКопираме елементите на Б отново в А, но вече в обратен ред 

            for (int i = 0; i < arrB.Length; i++)
            {
                arrA[i] = arrB[i];
            }
            Console.WriteLine("");
            //Визуализираме елементите на новия A
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("new ArrА element {0}: ", i);
                Console.WriteLine(arrA[i]);
            }

        }
    }
}
