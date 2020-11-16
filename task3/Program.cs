using System;
using task6;

#region задание 3
/* 
 * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода. 
 */
#endregion

namespace task3
{
    class MainClass
    {
        public static double getLength(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        public static void Main(string[] args)
        {
            float x1 = float.Parse(methods.GetInfo("Введите значение x1"));
            float y1 = float.Parse(methods.GetInfo("Введите значение y1"));
            float x2 = float.Parse(methods.GetInfo("Введите значение x2"));
            float y2 = float.Parse(methods.GetInfo("Введите значение y2"));
            double result = getLength(x1, y1, x2, y2);

            Console.WriteLine("{0:f2}", result);
        }
    }
}
