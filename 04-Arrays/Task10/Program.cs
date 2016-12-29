using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ourArray = new int[4, 4];

            for (int i = 0; i < ourArray.GetLength(0); i++)
            {
                for (int j = 0; j < ourArray.GetLength(1); j++)
                {
                    ourArray[j, i] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("******************************");
            foreach (var item in ourArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
