using System;
using ArrayLib;

#region задание 5
/*
 * *а) Реализовать библиотеку с классом для работы с двумерным массивом. 
 * Реализовать конструктор, заполняющий массив случайными числами. 
 * Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, 
 * свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, 
 * метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
 * **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * **в) Обработать возможные исключительные ситуации при работе с файлами.
 */
#endregion
namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TwoDimArray array = new TwoDimArray(2, 1, 100);
            Console.WriteLine($"Создан массив:\n{array.ToString()}");
            Console.WriteLine($"Сумма всех элементов массива: {array.GetSum()}");
            Console.WriteLine($"Сумма всех элементов массива больше заданного: {array.GetSum(1)}");
            Console.WriteLine($"Минимальный эллемент массива: {array.Min}");
            Console.WriteLine($"Максимальный элемент массива: {array.Max}");
            string number;
            array.GetMaxNumber(out number);
            Console.WriteLine($"Номер максимального элемента массива: {number}");

            string filepath = "/Users/OlesiaBidnik/Desktop/test/twodimArray.txt";

            //создание массива из файла
            TwoDimArray array2 = new TwoDimArray(filepath);
            Console.WriteLine($"Создан массив:\n{array2.ToString()}");
        }
    }
}
