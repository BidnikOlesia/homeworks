using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
namespace task2
{
    public static class Message
    {
        /// <summary>
        /// Метод, выводящий только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <param name="length">длина слова</param>
        public static void RequiredLengthWords(string message, int length)
        {

            string[] words = GetWords(message);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= length)
                    Console.WriteLine(words[i]);
            }
        }

        /// <summary>
        /// Метод, удаляющий из сообщения все слова, которые заканчиваются на заданный симво
        /// </summary>
        /// <param name="message">Message.</param>
        public static void DeleteWords(string message, char n)
        {
            string[] words = GetWords(message);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].EndsWith(n.ToString()))
                    sb.Append(words[i]+" ");
                else
                    Console.WriteLine($"Удалено слово: '{words[i]}'");
            }
            message = sb.ToString();
            Console.WriteLine($"Обновленный текст: {message}");
        }


        /// <summary>
        /// Метод, находящий самое длинное слово сообщения
        /// </summary>
        /// <param name="message">Message.</param>
        public static string GetLongestWord(string message)
        {
            string[] words = GetWords(message);
            string longestWord = words[0];
            StringBuilder sb = new StringBuilder(message);
            for (int i = 1; i < words.Length; i++)
                if (words[i].Length > longestWord.Length)
                    longestWord = words[i];
            return longestWord;
        }

        /// <summary>
        /// Метод, формирующий строку из самых длинных слов сообщения
        /// </summary>
        /// <returns>The words.</returns>
        /// <param name="message">Message.</param>
        public static string LongestWords(string message)
        {
            string[] words = GetWords(message);
            string maxWord = GetLongestWord(message);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length == maxWord.Length)
                    sb.Append(words[i] + " ");
            string s = sb.ToString();
            return s;
        }

        /// <summary>
        /// Метод, который производит частотный анализ текста
        /// </summary>
        /// <param name="words">Words.</param>
        /// <param name="message">Message.</param>
        public static void Frequency(string[] words, string message)
        {
            string[] messageWords = GetWords(message);
            Dictionary<string, int> frequency = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
                frequency.Add(words[i], 0);

            for (int i = 0; i < messageWords.Length; i++)
                if (frequency.ContainsKey(messageWords[i]))
                    frequency[messageWords[i]]++;

            foreach (var row in frequency)
                Console.WriteLine($"Частота вхождения слова {row.Key}  в сообщение: {row.Value}");
        }

        /// <summary>
        /// Метод, возвращающий сообщение без знаков препинания
        /// </summary>
        /// <param name="message">Message.</param>
        public static string[] GetWords(string message)
        {
            string[] words;
            StringBuilder sb = new StringBuilder(message);
            for (int i = 0; i < sb.Length;)
                if (char.IsPunctuation(sb[i]))
                    sb.Remove(i, 1);
                else ++i;
            message = sb.ToString();
            words = message.Split(' ');
            return words;
        }
    }
}