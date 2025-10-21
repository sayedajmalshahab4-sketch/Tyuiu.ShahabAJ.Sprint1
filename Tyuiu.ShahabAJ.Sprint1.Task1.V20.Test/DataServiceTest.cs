using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task1.V20.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Test case 1
            double x1 = 5;
            double y1 = 8;
            double wait1 = (5 * 8 / 2) + 10; // 30
            double result1 = ds.Calculate(x1, y1);
            Assert.AreEqual(wait1, result1);

            // Test case 2
            double x2 = 10;
            double y2 = 4;
            double wait2 = (10 * 4 / 2) + 10; // 30
            double result2 = ds.Calculate(x2, y2);
            Assert.AreEqual(wait2, result2);

            // Test case 3
            double x3 = 0;
            double y3 = 15;
            double wait3 = (0 * 15 / 2) + 10; // 10
            double result3 = ds.Calculate(x3, y3);
            Assert.AreEqual(wait3, result3);

            // Test case 4 - Additional test for variant 20
            double x4 = 12;
            double y4 = 3;
            double wait4 = (12 * 3 / 2) + 10; // 28
            double result4 = ds.Calculate(x4, y4);
            Assert.AreEqual(wait4, result4);
        }
    }
}