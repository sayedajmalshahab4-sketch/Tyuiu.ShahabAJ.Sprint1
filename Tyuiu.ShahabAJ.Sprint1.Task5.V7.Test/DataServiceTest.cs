using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task5.V0.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private const int V = 45;

        [TestMethod]
        public void ValidAngleToHoursMinutes()
        {
            DataService ds = new DataService();
            double f = V;
            int wait = 1;  // 45 / 30 = 1.5 → целая часть = 1
            int result = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidAngleToHoursMinutes2()
        {
            DataService ds = new DataService();
            double f = 90;
            int wait = 3;  // 90 / 30 = 3
            int result = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidAngleToHoursMinutes3()
        {
            DataService ds = new DataService();
            double f = 180;
            int wait = 6;  // 180 / 30 = 6
            int result = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, result);
        }
    }
}