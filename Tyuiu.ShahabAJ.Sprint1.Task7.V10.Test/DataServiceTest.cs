using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task7.V10.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double wait = -1.128; // Примерное ожидаемое значение
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateZero()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double wait = 0.318; // Примерное ожидаемое значение
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }
    }
}