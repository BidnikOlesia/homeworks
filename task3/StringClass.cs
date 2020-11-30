using System;
namespace task3
{
    public class StringClass
    {
        /// <summary>
        /// Checks the strings.
        /// </summary>
        /// <param name="s1">S1.</param>
        /// <param name="s2">S2.</param>
        public static void CheckStrings(string s1, string s2)
        {
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            s1 = new string(ch1);
            s2 = new string(ch2);


            if (s1 == s2)
                Console.WriteLine("Одна строка является перестановкой другой");
            else
                Console.WriteLine("Одна строка не является перестановкой другой");
        }
    }
}
