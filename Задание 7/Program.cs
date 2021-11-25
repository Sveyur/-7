using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод вычисления объема и площади поверхности куба.");
            Console.Write("Введите длину ребра куба: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Cubevol_sq(x);
            Console.ReadKey();
        }
        static void Cubevol_sq(int x)
        {

            Console.WriteLine("Объем куба равен - " + (x * x * x));
            Console.WriteLine("Площадь поверхности куба равна - " + (6 * x * x));
        }
    }
}
