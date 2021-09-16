using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S1.1");
            Console.WriteLine("{0:F2}", 888.8888124);

            Console.WriteLine("S1.2");
            Console.WriteLine("{0:F1}", Math.E);

            Console.WriteLine("S1.3");
            Console.WriteLine("Введите число:");
            double inputs13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели число {0}", inputs13);

            Console.WriteLine("S1.4");
            Console.WriteLine("Введите число:");
            double inputs14 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} - вот такое число Вы ввели", inputs14);

            Console.WriteLine("task2.1");

            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуй, " + name + "!");
            Console.ReadKey();

            Console.WriteLine("task2.2");

            double a, b;
            Console.WriteLine("Введите делимое:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите делитель:");
            b = Convert.ToDouble(Console.ReadLine());
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }

            Console.ReadKey();
        }
    }
}
