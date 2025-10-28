using System;
using Tyuiu.ShahabAJ.Sprint1.Task7.V10.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");

            double result = ds.Calculate(x);
            Console.WriteLine($"z = 2 * ctg(3x) - ln(cos x) / ln(1 + x^2) = {result}");

            Console.ReadKey();
        }
    }
}