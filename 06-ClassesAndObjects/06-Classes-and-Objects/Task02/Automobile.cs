using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Automobile : Car
    {       //Създайте клас Automobile, който наследява Car, и съдържа допълнително поле за разход на гориво.
     
        public int Fuel
        {
            get { return Fuel; }
            set { Fuel = value; }
        }

        public Automobile()
        { }

        public Automobile(int price, int fuel)
            :base(price)
        {
            this.Fuel = fuel;
        }

    }
}
