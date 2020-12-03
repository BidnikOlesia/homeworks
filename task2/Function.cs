using System;
using System.IO;
using System.Collections.Generic;
namespace task2
{
    public delegate double Func(double x);

    public static class Function
    {
        public static void SaveFunc(string fileName, double a, double b, double step, Func f)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double [] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] values = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();

                values[i] = d;
                if (d < min)
                    min = d;
            }
            bw.Close();
            fs.Close();
            return values;

        }

        /// <summary>
        /// Метод вывода значений
        /// </summary>
        /// <param name="a"></param>
        /// <param name="step"></param>
        /// <param name="values"></param>
        public static void Table(double a, double step, double[] values)
        {
            Console.WriteLine("----- X ----- Y -----");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", a, values[i]);
                a += step;
            }
            Console.WriteLine("--------------------");
        }

        /// <summary>
        /// Функция sin(x)
        /// </summary>
        /// <returns>The sin.</returns>
        /// <param name="x">The x coordinate.</param>
        public static double FuncSin(double x)
        {
            return Math.Sin(x);
        }

        /// <summary>
        /// Функция cos(x)
        /// </summary>
        /// <returns>The cos.</returns>
        /// <param name="x">The x coordinate.</param>
        public static double FuncCos(double x)
        {
            return Math.Cos(x);
        }

        /// <summary>
        /// Функция возведения в квадрат
        /// </summary>
        /// <returns>The sqrt.</returns>
        /// <param name="x">The x coordinate.</param>
        public static double FuncSqr(double x)
        {
            return x * x;
        }

        /// <summary>
        /// Функция возведения в куб
        /// </summary>
        /// <returns>The cube.</returns>
        /// <param name="x">The x coordinate.</param>
        public static double FuncCube(double x)
        {
            return x * x * x;
        }

        public static List<Func> functions = new List<Func>() 
        { 
        new Func(FuncSin),
        new Func(FuncCos),
        new Func(FuncSqr),
        new Func(FuncCube),
        };
    }
}
