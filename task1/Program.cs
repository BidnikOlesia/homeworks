using System;

#region задание 1
/*
 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 */
#endregion
namespace task1
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Functions.Table(Functions.MyFunc, -2, 2, 2);
            Functions.Table(Functions.FuncSin, -2, 2, 2);
        }
    }
}
