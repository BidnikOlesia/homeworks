using System;
using System.IO;

namespace ArrayLib
{
    public class TwoDimArray
    {
        int[,] a;

        /// <summary>
        /// Конструктор, заполняющий массив случайным образом
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        public TwoDimArray(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
        }

        /// <summary>
        /// Конструктор, заполняющий массив, загружая данные из файла
        /// </summary>
        /// <param name="filepath"></param>
        public TwoDimArray(string filepath)
        {
            try
            {
                string[] s = File.ReadAllLines(filepath);
                a = new int[s.Length, s[0].Split(' ').Length];

                for (int i = 0; i < s.Length; i++)
                {
                    string[] t = s[i].Split(' ');
                    for (int j = 0; j < t.Length; j++)
                    {
                        a[i, j] = int.Parse(t[j]);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Файл не найден: {ex}");
            }

        }

        /// <summary>
        /// Cвойство, возвращающее минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];
                return min;
            }
        }

        /// <summary>
        /// Cвойство, возвращающее максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];
                return max;
            }
        }

        /// <summary>
        /// Метод, возвращающий сумму всех элементов массива
        /// </summary>
        /// <returns></returns>
        public int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                    sum += a[i, j];
            return sum;
        }

        /// <summary>
        /// Метод, возвращающий сумму всех элементов массива больше заданного
        /// </summary>
        /// <param name="el">значение элемента массива</param>
        /// <returns></returns>
        public int GetSum(int el)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                    if (a[i, j] > el)
                        sum += a[i, j];
            return sum;
        }

        /// <summary>
        /// Метод, возвращающий номер максимального элемента массива
        /// </summary>
        /// <param name="number">номер максимального элемента массива</param>
        public void GetMaxNumber(out string number)
        {
            number = string.Empty;
            int max = Max;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                    if (a[i, j] == max) number = $"[{i},{j}]";
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s += a[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
