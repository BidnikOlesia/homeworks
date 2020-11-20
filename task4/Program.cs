using System;

#region задание 4
/* 
 * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками. 
 */
#endregion

namespace task4
{
    class MainClass
    {
        public static bool Verify(string login, string password)
        {
            bool isCorrect = false;
            if (login == "root" && password == "GeekBrains")
            {
                isCorrect = true;
            }
            return isCorrect;
        }

        public static void Main(string[] args)
        {
            int count = 0;
            int maxCount = 3;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();
                if (Verify(login, password))
                {
                    Console.WriteLine("Логин и пароль корректны");
                    break;
                }
                else
                {
                    count++;
                    Console.WriteLine("Логин и пароль некорректны.");
                }
            }
            while (count <= maxCount-1);
        }
    }
}