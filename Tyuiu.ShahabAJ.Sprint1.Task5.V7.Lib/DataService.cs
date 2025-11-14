using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            // 360 градусов = 12 часов = 720 минут
            // 1 градус = 2 минуты времени
            double totalMinutes = f * 2;

            // Получаем целое количество минут
            int minutes = (int)Math.Round(totalMinutes);

            return minutes;
        }
    }
}