using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidAngle90()
        {
            DataService ds = new DataService();
            double f = 90;
            int wait = 3;  // 90 / 30 = 3 часа
            int result = ds.CalculateHours(f);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidAngle180()
        {
            DataService ds = new DataService();
            double f = 180;
            int wait = 6;  // 180 / 30 = 6 часов
            int result = ds.CalculateHours(f);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidAngle45()
        {
            DataService ds = new DataService();
            double f = 45;
            int wait = 1;  // 45 / 30 = 1.5 → целая часть = 1
            int result = ds.CalculateHours(f);
            Assert.AreEqual(wait, result);
        }
    }
}