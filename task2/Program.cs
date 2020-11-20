using System;

#region задание 2
/* 
 * Написать метод подсчета количества цифр числа 
 */
#endregion

namespace task2
{
    class MainClass
    {

        public static int GetDigits(int n)
        {
            int digits = 0;
            while (n > 0)
            {
                digits++;
                n = n / 10;
            }
            return digits;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр в числе: {GetDigits(number)}");
        }
    }
}
