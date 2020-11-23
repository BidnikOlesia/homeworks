using System;
namespace task1
{
    public struct ComplexStruct
    {
        public double im;
        public double re;

        /// <summary>
        /// Метод сложения комплексных чисел
        /// </summary>
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        /// <summary>
        /// Метод вычитания комплексных чисел по формуле z=(a1−a2)+(b1−b2)i
        /// </summary>
        public ComplexStruct Substruct(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public override string ToString()
        {
            string result = im > 0 ? $"{re}+{im}i" : $"{re}{im}i";
            return result;
        }
    }
}
