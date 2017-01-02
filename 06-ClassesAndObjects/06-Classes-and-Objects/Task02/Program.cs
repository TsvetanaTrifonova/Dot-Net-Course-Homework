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
        {   //Създайте масив от тип Car и въведете в него 5 коли и 5 джипа.O тпечатайте данните за КОЛИТЕ в конзолата

            Car car1 = new Car();
            car1.Price = 25535.55;
            Car car2 = new Car(55000.00);
            Car car3 = new Car(60000.00);
            Car car4 = new Car(25030.00);
            Car car5 = new Car(180000.00);

            Suv suv1 = new Suv();
            suv1.Price = 78;
            suv1.Model = true;
            Suv suv2 = new Suv();
            suv2.Price = 300000.00;
            suv2.Model = true;
            Suv suv3 = new Suv(100000.00, false);
            Suv suv4 = new Suv(250000.00, true);
            Suv suv5 = new Suv(255000.80, true);

                      
            Car[] arrayOfCars = new Car[10] { car1, car2, car3, car4, car5, suv1, suv2, suv3, suv4, suv5 };
            //Car[] arrayOfSuv = new Suv[5] {  suv1, suv2, suv3, suv4, suv5 };
            foreach (Car item in arrayOfCars)
                
            {
                if (item.GetType()!= suv1.GetType())  // Проверявам дали е car или suv
                {
                    Console.WriteLine(item.GetType() + ": Price:" + item.Price);
                }
                
            }
            //foreach (Suv item in arrayOfSuv)
            //{
            //    Console.WriteLine(item.Price+":"+item.Model);
            //}
        }
    }
}
