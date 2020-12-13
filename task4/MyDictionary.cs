using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace task4
{
    class MyDictionary
    {
        List<Words> words;
        public string fileName;
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public MyDictionary(string fileName)
        {
            this.fileName = fileName;
            words = new List<Words>();
        }

        public void Add(string word, string translate)
        {
            words.Add(new Words(word, translate));
            dictionary.Add(word, translate);
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Words>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, words);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Words>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            words = (List<Words>)xmlFormat.Deserialize(fStream);
            fStream.Close();

            foreach (var row in words)
            {
                dictionary.Add(row.word, row.translate);
            }
        }

        public bool CheckWord(string word)
        {
            bool isExist = false;
            if (dictionary.ContainsKey(word))
                isExist = true;
            return isExist;
        }

        public string ShowTranslate(string word)
        {
            string message;
            if (CheckWord(word))
                message = dictionary[word];
            else
                message = $"Слово {word} еще не добавлено в словарь";
            return message;
        }

    }
}
