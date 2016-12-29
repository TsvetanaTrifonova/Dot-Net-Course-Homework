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
            //Напишете метод, който при подадено име отпечатва в конзолата "Greetings, <name>!"(Напишете програма, която тества този метод.)
            Console.WriteLine("Enter the name:");
            string name =Convert.ToString(Console.ReadLine());
            
            PrintGreetings(name);
        }
        private static void PrintGreetings(string name)
        {
            Console.WriteLine("Greetings, " +name+"!");
        }
    }
}
