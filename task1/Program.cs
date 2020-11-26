using System;

#region задание 1
/*
 * Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. 
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
 * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
 */
#endregion

namespace task1
{
    class MainClass
    {
        /// <summary>
        /// Метод, позволяющий найти количество пар элементов массива, в которых только одно число делится на 3.
        /// </summary>
        /// <returns>количество пар</returns>
        /// <param name="array">Массив</param>
        static int GetPairs(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0)
                {
                    if (array[i + 1] % 3 != 0) count++;
                }
                else
                {
                    if (array[i + 1] % 3 == 0) count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Метод, заполняющий массив рандомными значениями
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        static void FillRandom(int[] array, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
        }

        public static void Main(string[] args)
        {
            int[] array = new int[20];
            FillRandom(array, -10000, 10001);
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {GetPairs(array)}");
        }
    }
}
