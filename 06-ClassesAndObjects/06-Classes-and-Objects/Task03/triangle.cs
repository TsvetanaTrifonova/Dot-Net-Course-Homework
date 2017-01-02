using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle
    {
        private double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Triangle()
        { }
        public Triangle(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double Hypotenuse(double a, double b)
        {
            double H = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.Write("Hypotenuse is: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            return H;
        }

        public void Angle(double a, double b)
        {
            double angleOne = 0;
            double angleTwo = 0;
        
            //angleOne = (a / this.Hypotenuse(a, b) );
            angleOne = Math.Asin(a / this.Hypotenuse(a, b)) * (180 / Math.PI);
            angleTwo = Math.Asin(b / this.Hypotenuse(a, b)) * (180 / Math.PI);

            Console.WriteLine(   "angleOne" +  Convert.ToString(angleOne) + ", angleTwo" + Convert.ToString(angleTwo));
          

        }
    } 
}
