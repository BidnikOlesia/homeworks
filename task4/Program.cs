using System;
using System.IO;

#region
/*
 * Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
 * Создайте структуру Account, содержащую Login и Password.
 */
#region задача из урока 2
/*
 * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
#endregion
#endregion
namespace task4
{
    class MainClass
    {
        /// <summary>
        /// Метод, считывающий данные из файла
        /// </summary>
        /// <returns>массив</returns>
        /// <param name="filepath">путь к файлу.</param>
        public static string[] GetCredential(string filepath)
        {
            string s;
            if (File.Exists(filepath))
            {
                s = File.ReadAllText(filepath);
            }
            else
                throw new Exception("Файл не найден");

            string[] credential = s.Split(' ');
            return credential;
        }

        public static void Main(string[] args)
        {
            Account account = new Account();
            int count = 0;
            int maxCount = 3;

            do
            {
                string[] credential = GetCredential("//..//credential.txt");
                account.login = credential[0];
                account.password = credential[1];

                if (account.Verify())
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
            while (count <= maxCount - 1);
        }
    }
}
