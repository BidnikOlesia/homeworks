using System;


#region задание 6
/*
 *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 *«Хорошим» называется число, которое делится на ​сумму своих цифр.
 *​ Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 */
#endregion

namespace task6
{
    class MainClass
    {
        public static bool isDivide(int n)
        {
            int i = n;
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            bool a = n % sum == 0 ? a = true : a = false;
            return a;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Начало выполнения операции");
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (isDivide(i))
                    count++;
            }
            Console.WriteLine($"Количество 'хороших' чисел от 1 до 1 000 000 000: {count}");
            DateTime end = DateTime.Now;
            Console.WriteLine($"Время выполнения: {end - start}");

        }
    }
}
