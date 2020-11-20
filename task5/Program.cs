using System;

#region задание 5
/* 
* а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
* б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/
#endregion

namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double minIndex = 18.5;
            double maxIndex = 24.9;
            double requiredMass = 0;

            Console.WriteLine("Введите ваш вес(кг)");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рос(см)");
            double h = double.Parse(Console.ReadLine())/100;

            double i = m / (h*h);
            Console.WriteLine($"Индекс = {i}");
            if(i< minIndex)
            {
                Console.WriteLine($"Вам стоит набрать вес");
                requiredMass = (minIndex - i) * h * h;
                Console.WriteLine($"Вам стоит набрать {requiredMass} кг");
            }
            else if (i> maxIndex)
            {
                Console.WriteLine($"Вам стоит похудеть");
                requiredMass = (i - maxIndex) * h * h;
                Console.WriteLine($"Вам стоит похудеть на {requiredMass} кг");
            }
            else { Console.WriteLine($"Вы в прекрасной форме"); }
        }
    }
}