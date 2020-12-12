using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    
    class GuessNumber
    {
        int count;
        int number;
        int result;

        public int Count { get { return this.count; } }
        public int Number { get { return this.number; } }
        public int Result { 
            get { return this.result; } 
            set { this.result = value; } }

        
        /// <summary>
        /// Метод, задающий число
        /// </summary>
        public void GetNumber()
        {
            Random rnd = new Random();
            this.number = rnd.Next(1, 100);
        }

        /// <summary>
        /// Метод, проверяющий введенное число на соответствие с заданным
        /// </summary>
        /// <returns></returns>
        public bool CheckResult()
        {
            this.count++;
            bool isCorrect = this.result == this.number;
            return isCorrect;
        }

        /// <summary>
        /// Метод, проверяющий диапазон, в котором находится введенное число
        /// </summary>
        /// <returns></returns>
        public string CheckRange()
        {
            string message;
            if (this.result > this.number)
                message = "Введенное число больше загаданного";
            else
                message = "Введенное число меньше загаданного";

            return message;
        }

    }
}
