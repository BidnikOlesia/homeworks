using System;
using System.IO;

namespace task2
{
    public static class ArrayClass
    {
        /// <summary>
        /// Метод, заполняющий массив рандомными значениями и выводящий в консоль количество пар элементов массива, в которых только одно число делится на 3
        /// (под парой подразумевается два подряд идущих элемента массива)
        /// </summary>
        /// <param name="array">массив</param>
        public static void FillRandomAndGetPairs(int[] array)
        {
            int min = -10000;
            int max = 10000;
            int count = 0;
            Random rnd = new Random();
            //заполнение массива случайными значениями
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            //поиск пар элементов массива, в которых только одно число делится на 3
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
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {count}");
        }


        /// <summary>
        /// Метод создащий массив, загружая данные из файла
        /// </summary>
        /// <returns>The array from file.</returns>
        /// <param name="filepath">путь к файлу</param>
        public static int[] GetArrayFromFile(string filepath)
        {
            string s;
            if (File.Exists(filepath))
            {
                s = File.ReadAllText(filepath);
            }
            else
                throw new Exception("Файл не найден");

            int[] array = new int[s.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(s[i].ToString());
                Console.WriteLine($"array{i} = {array[i]}, s{i} = {s[i]}");
            }
            return array;
        }
    }
}
