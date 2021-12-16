using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // разработать статический класс для работы с окружностью
            // первый метод, определяет длину окружности по заданному радиусу С = Math.PI * 2 * R
            // второй метод, определяет площадь круга по заданному радиусу S = Math.Pow(R, 2) * Math.PI
            // третий метод, проверяет принадлежность точки с координатами (x,y)
            // кругу с радиусом и координатом центра x0, y0
            // Math.Pow(R, 2) = Math.Pow((x - x0) *2) + Math.Pow((y - y0) *2)

            Console.WriteLine("Hello Инженер! \n введите радиус r окружности в милиметрах");
            double r = Convert.ToDouble(Console.ReadLine());
            double x, y;
            double C = AсircleVolar.Circle(r);
            double S = AсircleVolar.Triangl(r);
            double poit = AсircleVolar.Point(r, x, y);
            Console.WriteLine("Окружность C = {0} мм", C);
            Console.WriteLine("Площадь S = {0} мм", S);
            Console.WriteLine("X {0} и Y {1} принадлежат окружности", x, y);
            Console.ReadKey();
        }
    }

    
    static class AсircleVolar
    {        
            public static double Circle(double r) // первый метод, длину окружности по радиусу
            {
                return Math.PI*2*r;
            }

            public static double Triangl(double r) // второй метод, площадь круга по радиусу
            {
                return Math.Pow(r, 2) * Math.PI;
            }

            public static void Point(double r) // третий метод, проверяет принадлежность точки к окружности
            {
                double x0 = 0;
                double y0 = 0;
                int i, j;
                  
                int[,] array = new int[i, j]; // Где i - номер точки, j - кол-во точек = 360, R - радиус,
                                         // x[0] и y[0] - координаты центра окружности

                for(int i = 0 ; i < 360; i++)
                {
                  for(int j = 0; j < 360; j++)
                  {
                    double x = Math.Cos(2 * Math.PI * i / j) * r + x0;
                    double y = Math.Sin(2 * Math.PI * i / j) * r + y0;
                   }
                }
                return ;
            }
    }
               
}


//{ int[,] array = new int[n,m];
// for (int i = 1; i < n; i++)
// {
   // for (int j = 0; j < m; j++)
   // {
     //   array[i, j] = (i + j) % 2;
     //   Console.Write("{0,5 } ", array[i, j]);
  //  }
   // Console.WriteLine();
// }
// h.Sqrt(p * (p - X) * (p - Y) * (p - Z));
   //  Console.WriteLine("Площадь треугольника S = {0} кв. мм", S);
// }
