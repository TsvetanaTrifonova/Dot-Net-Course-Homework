using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Създайте клас Cat в две полета за име и години. Нека класа да има метод Say(), 
            //който да съобщава името и годините на котката.Направете масив от 10 котки и извикайте метода Say() на всяка една котка.
            Cat cat1 = new Cat("Mur",2);          
            
            Cat cat2 = new Cat();
            cat2.Name = "Miki";
            cat2.Age = 5;

            Cat cat3 = new Cat("Koly", 3);
            Cat cat4 = new Cat("Fil", 5);
            Cat cat5 = new Cat("Ani", 7);
            Cat cat6 = new Cat("Vera", 4);
            Cat cat7 = new Cat("Tom", 4);
            Cat cat8 = new Cat("Prea", 12);
            Cat cat9 = new Cat("Lila", 3);
            Cat cat10 = new Cat("Maya", 1);

            //Cat[] arrayOfCats = new Cat[10];
            //arrayOfCats[0] = cat1;
            //arrayOfCats[1] = cat2;
            //arrayOfCats[2] = cat3;
            //arrayOfCats[3] = cat4;
            //arrayOfCats[4] = cat5;
            //arrayOfCats[5] = cat6;
            //arrayOfCats[6] = cat7;
            //arrayOfCats[7] = cat8;
            //arrayOfCats[8] = cat9;
            //arrayOfCats[9] = cat10;
            Cat[] arrayOfCats = new Cat[10] { cat1, cat2, cat3, cat4, cat5, cat6, cat7, cat8, cat9, cat10 };

            foreach (Cat item in arrayOfCats)
            {
                item.Say();
            }
        }
    }
}
