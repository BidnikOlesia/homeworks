using System;

#region задание 5
/*
 * Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 */
#endregion

namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string fileNameCSV = "students.csv";
            string fileNameXML = "studentsXml.xml";
            Student.ConvertToXml(fileNameCSV, fileNameXML);
        }
    }
}
