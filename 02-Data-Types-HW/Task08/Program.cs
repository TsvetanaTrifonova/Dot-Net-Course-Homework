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
            //    Напишете програма, която приема два стринга като вход.
            //    След това проверява дали 2рия стринг се съдържа в 1вия.
            //    Покажете резултата от проверката на конзолата. *
            string firstString;
            string secondString;
            Console.WriteLine("first string is:");
            firstString = Console.ReadLine();
            Console.WriteLine("second string is:");
            secondString = Console.ReadLine();

            Console.WriteLine(firstString.Contains(secondString));
           // firstString.Contains(secondString);


        }
    }
}
