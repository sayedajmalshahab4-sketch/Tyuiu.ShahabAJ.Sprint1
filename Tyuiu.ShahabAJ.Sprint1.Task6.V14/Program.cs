using System;
using Tyuiu.ShahabAJ.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckLowerCaseRusLetters(text);
            Console.WriteLine($"Строка состоит только из строчных русских букв: {result}");

            Console.ReadKey();
        }
    }
}



