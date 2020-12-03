using System;
using System.Collections.Generic;
using System.IO;

#region задание 3
/*
 * Переделать программу ​Пример использования коллекций​для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 * в) отсортировать список по возрасту студента;
 * г) *отсортировать список по курсу и возрасту студента;
 */
#endregion

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students = Student.ReadFile("students.csv"); 

            int count = Student.CheckStudentsCount(students, 5) + Student.CheckStudentsCount(students, 6);
            Console.WriteLine($"количество студентов учащихся на 5 и 6 курсах: {count}");

            Console.WriteLine("в возрасте от 18 до 20 лет учатся:");
            Dictionary<int, int> stud = Student.Frequency(students, 18, 20);
            foreach (var row in stud)
                Console.WriteLine($"{row.Value} студент(ов) на {row.Key} курсе");

            Console.WriteLine("Сортировка студентов по возрасту:");
            Student.SortByAge(students);
        }
    }
}
