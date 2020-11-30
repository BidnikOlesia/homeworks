using System;

#region задание 3
/*
 * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой
 * Например: badc ​являются перестановкой ​abcd.​
 */
#endregion

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку 1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите строку 2:");
            string s2 = Console.ReadLine();
            StringClass.CheckStrings(s1, s2);
        }
    }
}
