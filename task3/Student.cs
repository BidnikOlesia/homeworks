using System;
using System.IO;
using System.Collections.Generic;
namespace task3
{
    public class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;


        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }


        public static List<Student> ReadFile(string fileName)
        {
            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

            }
            sr.Close();
            return list;
        }

        /// <summary>
        /// Метод, подсчитывающий количество студентов на заданном курсе
        /// </summary>
        /// <returns>The students count.</returns>
        /// <param name="students">Students.</param>
        /// <param name="course">Course.</param>
        public static int CheckStudentsCount(List<Student> students, int course)
        {
            int count = 0;
            foreach (var row in students)
                if (row.course == course)
                    count++;
            return count;
        }

        /// <summary>
        /// подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
        /// </summary>
        /// <returns>The frequency.</returns>
        /// <param name="students">Students.</param>
        /// <param name="minAge">Minimum age.</param>
        /// <param name="maxAge">Max age.</param>
        public static Dictionary<int, int> Frequency(List<Student> students, int minAge, int maxAge)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (var row in students)
                if(!frequency.ContainsKey(row.course))
                    frequency.Add(row.course, 0);

            foreach (var row in students)
            {
                if (row.age > minAge && row.age < maxAge)
                    frequency[row.course]++;
            }
            return frequency;
        }


        static int MyDelegate(Student st1, Student st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }


        /// <summary>
        /// Метод сортировки и вывода студентов по возрасту
        /// </summary>
        /// <param name="students">Students.</param>
        public static void SortByAge(List<Student>students)
        {
            students.Sort(new Comparison<Student>(MyDelegate));
            foreach (var row in students)
                Console.WriteLine($"{row.firstName} {row.lastName}, {row.age}");
        }
    }
}


