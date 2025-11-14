using Microsoft.CSharp.RuntimeBinder;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShahabAJ.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
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