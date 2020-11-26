using System;
using System.Collections.Generic;

namespace ArrayLib
{
    public class OneDimArray
    {

        int[] a;

        /// <summary>
        /// конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <param name="firstValue">начальное значение</param>
        /// <param name="step">шаг</param>
        public OneDimArray(int n, int firstValue, int step)
        {
            a = new int[n];
            a[0] = firstValue;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        /// <summary>
        /// Свойство, возвращающее максимальный эдемент массива
        /// </summary>
        /// <value>The max.</value>
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max) max = a[i];
                }
                return max;
            }
        }

        /// <summary>
        /// Свойство, возвращающее минимальный эдемент массива
        /// </summary>
        /// <value>The max.</value>
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] < min) min = a[i];
                }
                return min;
            }
        }

        /// <summary>
        /// Свойство, возвращающее сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }

        /// <summary>
        /// Свойство, возвращающее количество максимальных элементов.
        /// </summary>
        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = Max;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == max) count++;
                }
                return count;
            }
        }

        /// <summary>
        /// Метод, возвращающий новый массив с измененными знаками у всех элементов массива
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = a[i] * -1;
            }
            return newArray;
        }

        /// <summary>
        /// метод, умножающий каждый элемент массива на определённое число
        /// </summary>
        /// <returns></returns>
        public void Multi(int number)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * number;
            }
        }


        /// <summary>
        /// Метод, возвращающий частоту вхождения каждого элемента в массив)
        /// </summary>
        /// <returns>The frequency.</returns>
        public Dictionary<int, int> Frequency()
        {
            Dictionary<int, int> frequecy = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (frequecy.ContainsKey(a[i])) frequecy[i]++;
                else frequecy.Add(a[i], 1);
            }
            return frequecy;
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
