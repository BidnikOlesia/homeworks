using System;
namespace task1
{
    public class ComplexClass
    {
        double im;
        double re;

        public ComplexClass()
        {
            im = 0;
            re = 0;
        }

        public ComplexClass(double re, double im)
        {
            this.im = im;
            this.re = re;
        }

        /// <summary>
        /// Метод вычитания комплексных чисел по формуле z=(a1−a2)+(b1−b2)i
        /// </summary>
        public ComplexClass Substruct(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }

        /// <summary>
        /// Метод сложения комплексных чисел по формуле z=(a1+a2)+(b1+b2)i
        /// </summary>
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = x2.re + re;
            x3.im = x2.im + im;
            return x3;
        }


        /// <summary>
        /// Метод умножения комплексных чисел по формуле z=z1⋅z2=(a1a2−b1b2)+(a1b2+b1a2)i
        /// </summary>
        public ComplexClass Multiply(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re * x2.re - im * x2.im;
            x3.im = re * x2.im + im * x2.re;
            return x3;
        }

        /// <summary>
        /// Возвращает строковое представление косплексного числа
        /// </summary>
        public override string ToString()
        {
            string result = im > 0 ? $"{re}+{im}i" : $"{re}{im}i";
            return result;
        }
    }
}
