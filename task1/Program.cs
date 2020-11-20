using System;


#region задание 1
/* 
 * Написать метод, возвращающий минимальное из трёх чисел.
 */
#endregion

namespace task1
{
    public class MainClass
    {
        public static int MinNumber(int a, int b, int c)
        {
            int min;

            if (a < b && a < c) { min = a; }
            else if (b < c) { min = b; }
            else { min = c; }
            return min;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            int c = int.Parse(Console.ReadLine());
            int min = MinNumber(a, b, c);

            Console.WriteLine($"Минимальное чило = {min}");
        }
    }
}