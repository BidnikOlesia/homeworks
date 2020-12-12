using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Doubler
    {
        int goal;
        int steps;
        int result;

        public Doubler()
        {
            this.goal = 0;
            this.steps = 0;
            this.result = 0;
        }

        public int Goal { get { return this.goal; } }
        public int Steps { get { return this.steps; } }
        public int Result { get { return this.result; } }

        public void GetGoal()
        {
            Random rnd = new Random();
            goal = rnd.Next(2, 100);
        }

        public bool CheckResult()
        {
            bool isCorrect = result == goal;
            return isCorrect;
        }

        public void Reset()
        {
            result = 0;
            steps = 0;
        }

        public void Increment()
        {
            result++;
            steps++;
        }

        public void Double()
        {
            result = result* 2;
            steps++;
        }
    }
}
