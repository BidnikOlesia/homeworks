using System;
using System.IO;

#region задание 2
/*
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 * а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
 * Использовать массив (или список) делегатов, в котором хранятся различные функции.
 * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
 * Пусть она возвращает минимум через параметр (с использованием модификатора out).
 */
#endregion
namespace task2
{
    class MainClass
    {
        public static double GetValue(string message)
        {
            double value;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = double.TryParse(s, out value);
            }
            while (!flag);
            return value;
        }

        public static void Main(string[] args)
        {
            string fileName = "data.bin";

            double funcNum = GetValue("Пожалуйста, выберети функцию:\n0 - f(x) = sin(x)\n1 - f(x) = cos(x)\n2 - f(x) = x^2\n3 - f(x) = x^3");
            double a = GetValue("Введите значение первой точки");
            double b = GetValue("Введите значение второй точки");
            double step = GetValue("Введите значение шага");

            Function.SaveFunc(fileName, a, b, step, Function.functions[Convert.ToInt32(funcNum)]);
            double [] values = Function.Load(fileName, out double min);
            Function.Table(a, step, values);
            Console.WriteLine($"Минимальное значение функции: {min}");


        }
    }
}
