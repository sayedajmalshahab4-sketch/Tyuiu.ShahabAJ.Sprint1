using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task4.V29.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            // √(2 + |2 - 2*1|) / (3*2*1²) = √(2 + |0|) / 6 = √2 / 6 ≈ 1.414 / 6 ≈ 0.236
            double wait = 0.236;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            // √(2 + |1 - 4|) / (3*1*4) = √(2 + 3) / 12 = √5 / 12 ≈ 2.236 / 12 ≈ 0.186
            double wait = 0.186;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            // √(2 + |3 - 2|) / (3*3*1) = √(2 + 1) / 9 = √3 / 9 ≈ 1.732 / 9 ≈ 0.192
            double wait = 0.192;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}