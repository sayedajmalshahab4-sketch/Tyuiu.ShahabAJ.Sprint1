using System;
using Tyuiu.ShahabAJ.Sprint1.Task2.V27.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task2.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Шахаб А. Дж. | АСОиУБ-25-1";
            Console.WriteLine("*************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. Дж. | АСОиУБ-25-1                                   *");
            Console.WriteLine("*************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Формулировка задания: Известна длина стороны квадрата.                  *");
            Console.WriteLine("* Вычислить периметр квадрата.                                            *");
            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите длину стороны квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*************************");

            Console.WriteLine("Периметр квадрата = " + ds.CalculatePerimetr(a));
            Console.ReadKey();
        }
    }
}