using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class ConvertCtoF
    {
        private double c;
        public double C
        {
            get { return c; }
            set { c = value; }
        }
      
        public ConvertCtoF()
        { }
        public ConvertCtoF(double c)
        {
            this.C = c;
        }

        public double ToF(double c)
        {
            double F = C * 1.8 + 32;
            return F;
        }
     
    }
}
