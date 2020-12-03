using System;
namespace task1
{
    public delegate double Fun(double x, double a);
    public class Functions
    {
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("---- A -------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(x, a));
                x += 1;
            }
            Console.WriteLine("----------------------------------");
        }

        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }

        public static double FuncSin(double x, double a)
        {
            return a * Math.Sin(x);
        }
    }
}
