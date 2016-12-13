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
            //Напишете булев израз, който да проверява дали даден низ от символи (string)е равен на „Hello World”. 
            //    Отпечатайте в конзолата резултата от проверката.
            string yourString;
            string myString;

            myString = "Hello World";
            Console.WriteLine("Wtite your string: ");
            yourString = Convert.ToString(Console.ReadLine());
            Console.WriteLine(yourString == myString);
        }
    }
}
