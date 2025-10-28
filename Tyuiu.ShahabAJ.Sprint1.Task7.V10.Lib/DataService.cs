using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShahabAJ.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double ctg = 1.0 / Math.Tan(3 * x);
            double lnCos = Math.Log(Math.Cos(x));
            double lnDenominator = Math.Log(1 + Math.Pow(x, 2));

            double z = 2 * ctg - (lnCos / lnDenominator);

            return Math.Round(z, 3);
        }
    }
}