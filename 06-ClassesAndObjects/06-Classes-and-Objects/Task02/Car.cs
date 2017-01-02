using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Car
    {
        //Дефинирайте клас Car с единствено поле цена. 
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car()
        { }

        public Car(double price)
        {
            this.price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Price);
        }
    }
}
