using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateHours()
        {
            DataService ds = new DataService();
            double f = 90;
            int wait = 3;
            int result = ds.CalculateHours(f);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateHours2()
        {
            DataService ds = new DataService();
            double f = 180;
            int wait = 6;
            int result = ds.CalculateHours(f);
            Assert.AreEqual(wait, result);
        }
    }
}