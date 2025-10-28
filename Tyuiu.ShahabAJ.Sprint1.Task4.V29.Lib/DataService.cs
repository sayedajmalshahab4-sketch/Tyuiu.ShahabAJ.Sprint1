using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShahabAJ.Sprint1.Task4.V29.Lib
{
    public class DataService : ISprint1Task4V29
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sqrt(2 + Math.Abs(x - 2 * y));
            double denominator = 3 * x * Math.Pow(y, 2);
            double result = numerator / denominator;

            return Math.Round(result, 3);
        }
    }
}