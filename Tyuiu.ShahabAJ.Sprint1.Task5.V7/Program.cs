using System;
using Tyuiu.ShahabAJ.Sprint1.Task5.V0.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}