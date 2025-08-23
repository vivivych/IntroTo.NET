//#define STRING_OPERATIONS
#define DATA_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if STRING_OPERATIONS

            //Console.Write("Hello.NET\n");
            //Console.WriteLine("Hello");

            Console.Write("Введите ваше имя :");
            string first_name = Console.ReadLine();

            Console.Write("Введите вашу фамилию :");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст :");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age); //Конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age)); //Форматирование строк
            Console.WriteLine($"{first_name} {last_name} {age}"); //Интерполяция строк

#endif
            //ТИПЫ ДАННЫХ
            //C# - это полностью объектно-ориентированный язык. Абсолютно все в нем является объектами. Все типы данных также являются объектами.
            //Все они унаследованы от базового типа "object". Все типы данных в языке можно разделить на : 1.значимые типы(ValueTypes) - которые хранят значения, 2.Ссылочные (ReferenceTypes) 
            // Ссылочные хранят ссылку (указатель) на значение в динамической памяти 
            //К значимым типам относятся все примитивные типы данных(bool, short, double, int и тд)
            //К ссылочным относятся массивы, в частности строки, также структуры и классы. Для значений ссылочных типов всегда выделяется память с помощью new. 

            //ЗНАЧИМЫЕ ТИПЫ
            //Делятся на категории : 1. Логические типы (bool,1 байт) У типа-данных bool есть класс-обертка Boolean. У каждого примитивного типа в C# есть класс-обвертка, который хранит основные свойства типа.
            //Такие как мин и макс значения.
            //2.Символьные типы(char) Класс-обвертка - Character. Занимает 2 байта, хранит один символ кодировки юникод.
            //3.Числовые типы. То же что в С++, но в C# отсутствует ключевое слово unsigned. Вместо него для беззнаковых типов используются отдельные спецификаторы.
            //Примеры : short - ushort, int - uint, long - ulong. Самым маленьким целочисл типом является байт. Он по умолчанию беззнаковый. Чтобы создать знаковый, используется sbyte.


            //Вещественные типы - только знаковые. (float,double, decimal)
            //Как и в С++ double и float хранят приблизительные значения. Поэтому они не подходят для финанс вычислений.
            //Был добавлен decimal - занимает 16 байт памяти, хранит 28 знаков после запятой, с такой же точностью как целочисл типы. 

            //float  Single;
            //double Double;
            //decimal Decimal;
#if DATA_TYPES

            Console.WriteLine(sizeof(bool));
            //Console.WriteLine(Boolean.);
            byte var = 0;
            Console.WriteLine($"{var.GetType()} занимет {sizeof(byte)} Байт памяти, и принимает значения в диапазоне : {byte.MinValue} ... {byte.MaxValue}");


#endif
        }
    }
}
