using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace task5
{
    [Serializable]
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

        public Student() { }


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

        /// <summary>
        /// Метод,сохраняющий данные в формате xml
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="fileName">имя создаваемого файла</param>
        static void SaveAsXmlFormat(List<Student> obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }

        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <returns>The file.</returns>
        /// <param name="fileName">File name.</param>
        static List<Student> ReadFile(string fileName)
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

            }
            sr.Close();
            return students;
        }

        /// <summary>
        /// Converts to xml.
        /// </summary>
        /// <param name="fileNameCSV">File name csv.</param>
        /// <param name="fileNameXML">File name xml.</param>
        public static void ConvertToXml(string fileNameCSV, string fileNameXML)
        {
            List<Student> students = new List<Student>();
            students = ReadFile(fileNameCSV);
            SaveAsXmlFormat(students, fileNameXML);
        }
    }
}
