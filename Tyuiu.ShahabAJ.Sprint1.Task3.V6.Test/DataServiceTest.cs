using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task3.V6.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTravelCost()
        {
            DataService ds = new DataService();
            double distance = 67;
            double fuelConsumption = 8.5;
            double pricePerLiter = 6.5;
            double wait = 74.035;
            double result = ds.TravelCost(distance, fuelConsumption, pricePerLiter);
            Assert.AreEqual(wait, result);
        }
    }
}