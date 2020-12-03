using System;

#region задание 4
/*
 * Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. 
 * Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader 
 * и массив int для BinaryReader.
 */
#endregion
namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;

            FileWriter.FileStreamSample("bigdata0.bin", size);
            FileWriter.BinaryStreamSample("bigdata1.bin", size);
            FileWriter.StreamWriterSample("bigdata2.bin", size);

            byte[] result = FileReader.FileStreamRead("bigdata0.bin");
            int[] result1 = FileReader.BinaryStreamReader("bigdata1.bin");
            string result2 = FileReader.StreamRead("bigdata2.bin");
        }
    }
}
