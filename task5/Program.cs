using System;

#region задание 5
/* 
 * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 * б) *Сделать задание, только вывод организовать в центре экрана.
 * в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y). 
 */
#endregion

namespace task5
{
    class MainClass
    {
        public static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        public static void Main(string[] args)
        {
            string text = "Олеся Бидник, г. Саратов";

            //вывод на экран
            Console.WriteLine(text);

            //вывод в центре экрана
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), Console.WindowHeight / 2);
            Console.WriteLine(text);

            //вывод в заданной позиции с использованием метода
            Print(text, 15, 15);
        }

    }
}