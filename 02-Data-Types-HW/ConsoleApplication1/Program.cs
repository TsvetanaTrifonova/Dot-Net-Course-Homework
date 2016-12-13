using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която приема стринг от конзолата, и извежда N-тия символ от стринга, като резултат. 
             string String;
            int n;
            Console.WriteLine("Write string please");
            String = Console.ReadLine();
            Console.WriteLine("Write int number");
            n =Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(String[n-1]);
        }
    }
}
