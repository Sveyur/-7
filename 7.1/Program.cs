using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 4;
            int z1 = 5;
            int x2 = 6;
            int y2 = 8;
            int z2 = 10;
            double S1 = Ger(x1, y1, z1);
            double S2 = Ger(x2, y2, z2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника");
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника больше площади первого треугольника");
            }
            Console.WriteLine("Площадь первого треугольника = {0}, площадь второго треугольника = {1}", S1, S2);
            Console.ReadKey();
        }
        static double Ger(int x, int y, int z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}






