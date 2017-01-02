using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Cat
    {
        //Създайте клас Cat в две полета за име и години. Нека класа да има метод Say(), 
        //който да съобщава името и годините на котката. Направете масив от 10 котки и извикайте метода Say() на всяка една котка.
        //----1
        private string name;
        private string age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Cat()
        {
        }
        //-------2
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Say()
        {
            //Console.WriteLine(this.Name + " " + this.Age);
            Console.WriteLine("Name: {0}, Age:{1}", this.Name, this.Age);
        }
    }
}
