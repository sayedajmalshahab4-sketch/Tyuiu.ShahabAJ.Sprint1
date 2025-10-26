using System;
using Tyuiu.ShahabAJ.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите угол поворота часовой стрелки f (0 < f < 360) -> ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");

            int result = ds.CalculateHours(f);
            Console.WriteLine($"Количество полных часов: {result} ч.");

            Console.ReadKey();
        }
    }
}