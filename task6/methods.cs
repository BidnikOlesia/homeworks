using System;

namespace task6
{
    #region задание 6
    /* 
     * Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
     */
    #endregion
    public class methods
    {
        /// <summary>
        /// Получение информации от пользователя
        /// </summary>
        /// <returns>введенное значение в виде string</returns>
        /// <param name="message">Задаваемый вопрос</param>
        public static string GetInfo(string message)
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine();
            return answer;
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }


}