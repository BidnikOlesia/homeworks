using System;
using System.Reflection;

#region задание 1
/*
 * С помощью рефлексии выведите все свойства структуры DateTime
 */
#endregion

namespace task1
{
    class MainClass
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        public static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();

            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").Attributes);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CustomAttributes);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").DeclaringType);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetMethod);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").IsSpecialName);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").MemberType);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").MetadataToken);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").Module);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").Name);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").PropertyType);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").ReflectedType);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").SetMethod);
        }
    }
}
