using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която приема реално число като вход, и изкарва на конзолата резултата от делението му с цяло число.
            double realNumber;
            double result;
            uint intNumber;
            Console.WriteLine("Wtite your real number: ");
            realNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wtite your integer number: ");
            intNumber = Convert.ToUInt16(Console.ReadLine());
            result = realNumber / intNumber;
            Console.WriteLine(result);
        }
    }
}
