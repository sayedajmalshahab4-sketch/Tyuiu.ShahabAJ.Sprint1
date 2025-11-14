using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShahabAJ.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            throw new NotImplementedException();
        }

        public int CalculateHours(double f)
        {
            double hours = f / 30.0;
            int fullHours = (int)hours;
            return fullHours;
        }
    }
}