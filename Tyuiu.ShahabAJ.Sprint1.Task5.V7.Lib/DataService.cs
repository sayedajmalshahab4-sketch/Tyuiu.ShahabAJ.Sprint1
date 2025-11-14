using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V0.Lib
{
    public class DataService :ISprint1Task5V7
    {
        public double Calculate(double x)
        {
            double result = Math.Pow(x, 2) / Math.Sqrt(x);
            return result;
        }
    }
}