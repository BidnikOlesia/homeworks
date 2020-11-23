using System;

#region задание 3
/* 
 * *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
 * Добавить свойства типа int для доступа к числителю и знаменателю;
 * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
 * *Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 * **Добавить упрощение дробей. 
 */
#endregion

namespace task3
{
    class MainClass
    {
        public static int GetValue(string message)
        {
            int value;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = int.TryParse(s, out value);
            }
            while (!flag);
            return value;
        }

        public static void Main(string[] args)
        {
            int n1 = GetValue("Введите числитель первой дроби");
            int d1 = GetValue("Введите знаменатель первой дроби");
            int n2 = GetValue("Введите числитель второй дроби");
            int d2 = GetValue("Введите знаменатель второй дроби");

            if(d1 ==0 || d2 == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен 0");
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }

            Fractions f1 = new Fractions(n1, d1);
            Fractions f2 = new Fractions(n2, d2);

            Fractions result;
            result = f1.Plus(f2);
            Console.WriteLine($"Результат сложения: {result.ToString()}");

            result = f1.Substract(f2);
            Console.WriteLine($"Результат вычитания: {result.ToString()}");

            result = f1.Multiple(f2);
            Console.WriteLine($"Результат умножения: {result.ToString()}");

            result = f1.Divide(f2);
            Console.WriteLine($"Результат деления: {result.ToString()}");

        }
    }
}
