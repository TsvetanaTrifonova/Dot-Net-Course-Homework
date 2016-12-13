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
            //Направете програма, която приема две цели числа -съответно страните на правоъгълник.
            //Пресметнете лицето на дадения правоъгълник и я изведете на конзолата.
            byte a;
            byte b;
            

            Console.Write("a = ");
            a = Convert.ToByte(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToByte(Console.ReadLine());
            int s = a * b;
            Console.WriteLine("s =  " + s );


        }
    }
}
