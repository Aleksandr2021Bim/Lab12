using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Инженер! \nвведите радиус r окружности в милиметрах");
            double r = Convert.ToDouble(Console.ReadLine());
            double C = AсircleVolar.Circle(r);
            double S = AсircleVolar.Triangl(r);
            Console.WriteLine("Окружность C = {0} мм", C);
            Console.WriteLine("Площадь S = {0} мм", S);
            Console.WriteLine("Введите точку на плоскости:");
            Console.Write("X=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y=");
            double y = Convert.ToDouble(Console.ReadLine());
            double x0 = 0;
            double y0 = 0;
            if (AсircleVolar.Point_on_Round(x0,y0,r,x,y))
            {
                Console.WriteLine("Точка лежит на окружности");
            }
            else
            {
                Console.WriteLine("Точка лежит на окружности");
            }
            Console.ReadKey();
        }
    }
    static class AсircleVolar
    {
        public static double Circle(double r) 
        {
            return Math.PI * 2 * r;
        }

        public static double Triangl(double r) 
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public static bool Point_on_Round(double x, double y, double r, double x0, double y0) 
        {
            if (((x-x0)*(x-x0)+(y-y0)*(y-y0)) == (r*r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
