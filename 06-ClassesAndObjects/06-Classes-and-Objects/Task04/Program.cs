using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напрате клас, който конвертира градуси от Целзий във Ференхайт.
            Console.WriteLine("Моля въведете градуси C° : ");
            double c = double.Parse(Console.ReadLine());
            ConvertCtoF myConvertCtoF = new ConvertCtoF(c);
            Console.WriteLine( "Във °F стойността е: "+ Math.Round( myConvertCtoF.ToF(c),2 ) ); 
        }
    }
}
