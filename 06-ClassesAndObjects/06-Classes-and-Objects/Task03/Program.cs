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

            Console.Write("First side: ");
            double a =Double.Parse(Console.ReadLine());
            Console.Write("Second side: ");
            double b = Double.Parse(Console.ReadLine());

            Triangle myTriangle = new Triangle();
            //Console.WriteLine( "H: "+myTriangle.Hypotenuse(a, b) );
            //Console.WriteLine( "Angle 1: "+ Math.Round(myTriangle.Angle(a, b),2) );
            myTriangle.Angle(a, b);
        }
    }
}
