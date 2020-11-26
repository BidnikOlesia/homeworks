using System;
using System.Collections.Generic;
using ArrayLib;

#region задание 3
/*
 * а) Дописать класс для работы с одномерным массивом. 
 * Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
 * Создать свойство Sum, которое возвращает сумму элементов массива, 
 * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
 * метод Multi, умножающий каждый элемент массива на определённое число, 
 * свойство MaxCount, возвращающее количество максимальных элементов. 
 * б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
 * е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
 */
#endregion
namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int size = 10;
            int firstValue = 1;
            int step = 2;
            int number = 2;

            OneDimArray array = new OneDimArray(size, firstValue, step);
            Console.WriteLine($"Сумма элементов массива: {array.Sum}");
            Console.WriteLine($"Количество максимальных элементов массива: {array.MaxCount}");
            Console.WriteLine($"Элементы массива, умноженные на {number}");
            array.Multi(number);
            Console.WriteLine(array.ToString());

            Console.WriteLine($"Частота вхождения каждого элемента в массив");
            Dictionary<int, int> f = new Dictionary<int, int>();
            f = array.Frequency();
            foreach (var row in f)
            {
                Console.WriteLine($"Колличество вхождений элемента {row.Key} в массив: {row.Value}");
            }

            Console.WriteLine($"Изменение знаков массива");
            int[] newArray;
            newArray = array.Inverse();
            foreach (var r in newArray)
            {
                Console.WriteLine(r);
            }
        }
    }
}
