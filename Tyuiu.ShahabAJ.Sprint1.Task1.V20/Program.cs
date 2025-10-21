using System;
using Tyuiu.ShahabAJ.Sprint1.Task1.V20.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double result = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат вычисления (X * Y / 2) + 10 = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}