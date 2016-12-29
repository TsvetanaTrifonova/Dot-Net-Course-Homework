using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Направете програма с функция, която принтира всички симетрични числа в интервала[10 ; 999]
            for (int i = 10; i <= 999; i++)
            {
                int c = (i % 10);
                int m = (i / 10);

                while (m / 10 != 0)
                {
                    m = m / 10;
                }
                if (c == m)
                {
                    Console.WriteLine(i+"; ");
                }
            }
        }
    }
}
