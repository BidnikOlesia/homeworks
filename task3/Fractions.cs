using System;

namespace task3
{
    public class Fractions
    {
        int numerator;
        int denominator;

        public Fractions()
        {
            numerator = 0;
            denominator = 0;
        }

        public Fractions(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int Numerator { get; set; }
        public int Denominator { get; set; }


        /// <summary>
        /// Метод упрощения дробей
        /// </summary>
        public void Simple(Fractions x)
        {
            int a = x.numerator;
            int b = x.denominator;
            if (a != 0 && b != 0)
            {
                while (a != b)
                {

                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }

                x.numerator = x.numerator / a;
                x.denominator = x.denominator / a;
            }

        }

        /// <summary>
        /// Метод сложения дробей
        /// </summary>
        public Fractions Plus(Fractions x2)
        {
            Fractions x3 = new Fractions();
            x3.numerator = numerator * x2.denominator + denominator * x2.numerator;
            x3.denominator = denominator * x2.denominator;
            Simple(x3);
            Simple(x3);
            return x3;
        }

        /// <summary>
        /// Метод вычитания дробей
        /// </summary>
        public Fractions Substract(Fractions x2)
        {
            Fractions x3 = new Fractions();
            x3.numerator = numerator * x2.denominator - denominator * x2.numerator;
            x3.denominator = denominator * x2.denominator;
            Simple(x3);
            return x3;
        }

        /// <summary>
        /// Метод умножения дробей
        /// </summary>
        public Fractions Multiple(Fractions x2)
        {
            Fractions x3 = new Fractions();
            x3.numerator = numerator * x2.numerator;
            x3.denominator = denominator * x2.denominator;
            Simple(x3);
            return x3;
        }
        /// <summary>
        /// Метод деления дробей
        /// </summary>
        public Fractions Divide(Fractions x2)
        {
            Fractions x3 = new Fractions();
            x3.numerator = numerator * x2.denominator;
            x3.denominator = denominator * x2.numerator;
            Simple(x3);
            return x3;
        }

        public override string ToString()
        {
            string result;
            if (numerator == 0 || denominator == 0) { result = "0"; }
            else if (denominator == 1) { result = $"{numerator}"; }
            else { result = $"{numerator}/{denominator}"; }
            return result;
        }
    }
}
