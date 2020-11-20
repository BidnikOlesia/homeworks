using System;

#region задание 7
/*
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b). 
 * б)*Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */
#endregion

namespace task7
{
    class MainClass
    {
        public static void Numbers(int min, int max)
        {
            Console.WriteLine(min);
            if (min < max)
            {
                Numbers(min + 1, max);
            }
        }

        public static int GetSum(int min, int max, int sum)
        {

            if (min == max)
            {
                return sum;
            }
            else
            {
                sum += min;
                min++;
            }
            return GetSum(min, max, sum);

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine($"Последовательность чисел от {min} до {max}: ");
            Numbers(min, max);

            int sum = 0;
            Console.WriteLine($"Сумма чисел от {min} до {max}:");
            Console.WriteLine(GetSum(min, max, sum));
        }
    }
}
