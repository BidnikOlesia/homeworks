using System;
using System.IO;
using System.Diagnostics;
namespace task4
{
    public static class FileWriter
    {
        public static long FileStreamSample(string fileName, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            for (int i = 0; i < size; i++)
            {
                fs.WriteByte(0);
            }
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        public static long BinaryStreamSample(string fileName, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < size; i++)
            {
                bw.Write((byte)0);
            }
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long StreamWriterSample(string fileName, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < size; i++)
            {
                sw.Write(0);
            }
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}
