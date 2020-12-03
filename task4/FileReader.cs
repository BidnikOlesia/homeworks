using System;
using System.IO;

namespace task4
{
    public class FileReader
    {

        public static byte[] FileStreamRead(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] result = new byte[fs.Length];
            for (int i = 0; i < fs.Length; i++)
                result[i] = (byte)fs.ReadByte();
            fs.Close();
            return result;
        }


        public static string StreamRead(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string result = sr.ReadToEnd().ToString();
            sr.Close();
            fs.Close();
            return result;
        }


        public static int[] BinaryStreamReader(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] result = new int[fs.Length/4];

            for (int i = 0; i < fs.Length/4; i++)
                result[i] = br.ReadInt32();

            br.Close();
            fs.Close();
            return result;
        }
    }
}
