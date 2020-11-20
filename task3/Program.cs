using System;
using System.Collections.Generic;

#region задание 3
/* 
 * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. 
 */
#endregion

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ВВедите числа");
            List<int> numbers = new List<int>();
            //do
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    numbers.Add(n);
            //    if (n == 0) { break; }
            //}
            //while (true);

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                numbers.Add(n);
                if (n == 0) { break; }
            }

            int sum = 0;
            foreach(var r in numbers)
            {
                if(r>0 && r%2 != 0)
                {
                    sum += r;
                }
            }
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {sum}");
        }
    }
}
