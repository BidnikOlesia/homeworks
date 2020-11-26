using System;

#region
/*
 * Реализуйте задачу 1 в виде статического класса StaticClass;
 * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 * б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 * в) **Добавьте обработку ситуации отсутствия файла на диске.
 */
#endregion
namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = new int[20];
            ArrayClass.FillRandomAndGetPairs(array);


            string filepath = "//..//array.txt";
            int[] array2 = ArrayClass.GetArrayFromFile(filepath);
        }
    }
}
