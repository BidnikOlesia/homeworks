using System;
using System.Text.RegularExpressions;

namespace task1
{
    public class Login
    {
        /// <summary>
        /// Метод, проверяющий корректность воода логина без использования регулярных выражений.
        /// </summary>
        /// <param name="login">Login.</param>
        public static void CheckLogin(string login)
        {
            bool isCorrect = false;
            if (login.Length >= 2 && login.Length <= 10)
                if (!char.IsDigit(login[0]))
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (char.IsLetterOrDigit(login[i]))
                        {
                            isCorrect = true;
                        }
                        else break;
                    }
                }
            if (isCorrect)
                Console.WriteLine("Логин корректен");
            else
                Console.WriteLine("Логин некорректен");
        }


        /// <summary>
        /// Метод, проверяющий корректность воода логина с использованием регулярных выражений.
        /// </summary>
        /// <param name="login">Login.</param>
        public static void CheckLoginReg(string login)
        {
            Regex correctLogin = new Regex("^[a-zA-Z]{1}[a-zA-Z0-9]${1,9}");

            bool isCorrect = correctLogin.IsMatch(login);
            if (isCorrect)
                Console.WriteLine("Логин корректен");
            else
                Console.WriteLine("Логин некорректен");
        }
    }
}
