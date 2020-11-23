using System;


#region задание 1
/* 
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
 */
#endregion

namespace task1
{
    public class MainClass
    {
        public static double GetValue(string message)
        {
            double value;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = double.TryParse(s, out value);
            }
            while (!flag);
            return value;
        }

        public static void Main(string[] args)
        {

            #region Вычитание комплексных чисел, используя структуру
            ComplexStruct complex1;
            complex1.re = 1;
            complex1.im = 2;

            ComplexStruct complex2;
            complex2.re = 3;
            complex2.im = 4;

            ComplexStruct result = complex1.Substruct(complex2);
            Console.WriteLine($"Результат вычитания = {result.ToString()}");
            #endregion

            #region Вычитание и умножение комплексных чисел, используя класс ComplexClass
            ComplexClass complex3 = new ComplexClass(5, 6);
            ComplexClass complex4 = new ComplexClass(7, 8);

            ComplexClass classResult;
            classResult = complex3.Substruct(complex4);
            Console.WriteLine($"Результат вычитания = {classResult.ToString()}");

            classResult = complex3.Multiply(complex4);
            Console.WriteLine($"Результат умножения = {classResult.ToString()}");
            #endregion

            #region диалог с использованием switch демонстрирующий работу класса
            double a1 = GetValue("Введите целую часть первого комплексного числа");
            double b1 = GetValue("Введите мнимую часть первого комплексного числа");
            double a2 = GetValue("Введите целую часть второго комплексного числа");
            double b2 = GetValue("Введите мнимую часть второго комплексного числа");

            ComplexClass complex5 = new ComplexClass(a1, b1);
            ComplexClass complex6 = new ComplexClass(a2, b2);

            int operation = Convert.ToInt32(GetValue("Для сложения комплексных чисел введите 1;\nДля вычитания комплексных чисел введите 2;\nДля умножения комплексных чисел введите 3;"));



            switch (operation)
            {
                case 1:
                    {
                        classResult = complex5.Plus(complex6);
                        Console.WriteLine($"{complex5.ToString()} + {complex6.ToString()} = {classResult.ToString()}");
                        break;
                    }
                case 2:
                    {
                        classResult = complex5.Substruct(complex6);
                        Console.WriteLine($"{complex5.ToString()} - {complex6.ToString()} = {classResult.ToString()}");
                        break;
                    }
                case 3:
                    {
                        classResult = complex5.Multiply(complex6);
                        Console.WriteLine($"{complex5.ToString()} * {complex6.ToString()} = {classResult.ToString()}");
                        break;
                    }
            }

            #endregion
        }
    }
}