using System;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V7.Lib
{
    public class DataService ISprint1Task6V14
    {
        public int CalculateHours(double f)
        {
            // Часовая стрелка проходит 360 градусов за 12 часов
            // Значит 1 час = 30 градусов (360 / 12 = 30)
            double hours = f / 30.0;

            // Берем целую часть (полные часы)
            int fullHours = (int)hours;

            return fullHours;
        }
    }
}