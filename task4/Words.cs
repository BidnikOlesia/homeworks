using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task4
{
    [Serializable]
    public class Words
    {
        public string word;
        public string translate;
        public Words()
        {
        }
        public Words(string word, string translate)
        {
            this.word = word;
            this.translate = translate;
        }
    }
}
