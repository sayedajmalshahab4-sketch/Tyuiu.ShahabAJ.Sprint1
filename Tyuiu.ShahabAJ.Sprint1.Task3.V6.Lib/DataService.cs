using System;

namespace Tyuiu.ShahabAJ.Sprint1.Task3.V6.Lib
{
    public class DataService
    {
        public double TravelCost(double distance, double fuelConsumption, double pricePerLiter)
        {
            double totalCost = distance;
            totalCost *= 2;         // Умножаем на 2 (туда и обратно)
            totalCost *= fuelConsumption; // Умножаем на расход бензина
            totalCost *= pricePerLiter;   // Умножаем на цену бензина
            totalCost /= 100;        // Делим на 100 (норма расхода на 100 км)

            return Math.Round(totalCost, 3);
        }
    }
}