using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Suv : Car
    {   //Създайте клас SUV, който налседява Car,  и съдържа boolean поле дали джипа е високопроходим.

        private bool model;
        public bool Model
        {
            get { return model; }
            set { model = value; }
        }

        public Suv()
        { }

        public Suv(double price, bool model)
            :base(price)
        {
            this.model = model;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Price);
            Console.WriteLine(this.Model);
        }
    }
}
