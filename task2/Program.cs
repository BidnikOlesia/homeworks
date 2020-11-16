using System;
using task6;

#region задание 2
/* 
 * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. 
 */
#endregion

namespace task2
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            double m = double.Parse(methods.GetInfo("Пожалуйста, введите вес(кг)"));
            double h = double.Parse(methods.GetInfo("Пожалуйста, введите рост(м)"));

            double i = m / (h * h);
            Console.WriteLine($"ИМТ = {i}");
        }
    }
}
