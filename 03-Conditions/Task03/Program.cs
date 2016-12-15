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
            //Класическото тесте карти се състои от 13 различни вида карти съответно 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
            //Направете програма, която приема от конзолата един символ и принтира "Валидна карта", 
            //ако символът представлява валидна карта, и съответно принтира "Невалидна карта", ако символът е на невалидна карта.
            Console.WriteLine("Enter your Choice:");
            string str = Console.ReadLine();
            Console.WriteLine();

            switch (str)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("Валидна карта");
                    break;

                default:
                    Console.WriteLine("Невалидна карта");
                    break;
            }
        }
    }
}
