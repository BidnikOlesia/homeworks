using System;
using task6;


#region задание 1
/* 
 * Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
 * а) используя склеивание;
 * б) используя форматированный вывод;
 * в) используя вывод со знаком $.
  */
#endregion

namespace task1
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string name = methods.GetInfo("Пожалуйста, введите Ваше имя");
            string lastname = methods.GetInfo("Пожалуйста, введите Вашу фамилию");
            string age = methods.GetInfo("Пожалуйста, введите Ваш возраст");
            string weight = methods.GetInfo("Пожалуйста, введите Ваш рост");
            string height = methods.GetInfo("Пожалуйста, введите Ваш вес");

            //Вывод информации в одну строку, используя склеивание
            Console.WriteLine("Имя: " + name + ", фамилия: " + lastname + ", возраст: " + age + ", рост: " + height + ", вес: " + weight);
            //Вывод информации в одну строку, используя форматированный вывод
            Console.WriteLine("Имя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}", name, lastname, age, height, weight);
            //Вывод информации в одну строку, используя вывод со знаком $
            Console.WriteLine($"Имя: {name}, фамилия: {lastname}, возраст: {age}, рост: {height}, вес: {weight}");

        }
    }
}