using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            // Часовая стрелка: 360° = 12 часов, значит 1 час = 30°
            // Для первой половины дня (0-12 часов)
            double hours = f / 30.0;

            // Берем целую часть часов
            int fullHours = (int)hours;

            return fullHours;
        }

        public double Calculate(double x)
        {
            throw new NotImplementedException();
        }
    }
}