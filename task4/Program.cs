using System;

#region задание 4
/* 
 * Написать программу обмена значениями двух переменных:
 * а) с использованием третьей переменной;
 * б) *без использования третьей переменной. */
#endregion

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"a = {a}, b = {b}");

            //с использованием третьей переменной
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}, b = {b}");

            //без использования третьей переменной
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}