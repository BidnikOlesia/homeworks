using System;
using System.Collections.Generic;

#region задание 2
/* 
 * С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
 * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse. 
 */
#endregion

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int n = 0;
            bool res = false;

            Console.WriteLine("Введите числа");
            do
            {
                res = int.TryParse(Console.ReadLine(), out n);
                if (!res)
                    Console.WriteLine("Необходимо вводить числа");
                else if (n == 0) { break; }
                else if (n > 0 && n % 2 != 0)
                {
                    numbers.Add(n);
                }
            }
            while (true);

            int sum = 0;
            Console.WriteLine("Введенные нечетные положительные числа;");
            foreach(var row in numbers)
            {
                Console.WriteLine(row);
                sum += row;
            }
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {sum}");

        }
    }
}
