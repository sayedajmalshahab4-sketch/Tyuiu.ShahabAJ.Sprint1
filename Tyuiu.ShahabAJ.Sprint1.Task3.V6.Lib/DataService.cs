using System;

namespace Tyuiu.ShahabAJ.Sprint1.Task3.V6.Lib
{
    public class DataService
    {
        public double TravelCost(double distance, double fuelConsumption, double pricePerLiter)
        {
            // Расчет общего расстояния (туда и обратно)
            double totalDistance = distance * 2;

            // Расчет необходимого количества бензина
            double fuelNeeded = (totalDistance * fuelConsumption) / 100;

            // Расчет общей стоимости
            double totalCost = fuelNeeded * pricePerLiter;

            // Округление до 3 знаков после запятой
            return Math.Round(totalCost, 3);
        }
    }
}