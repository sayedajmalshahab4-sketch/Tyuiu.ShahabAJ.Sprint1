using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task4.V29.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.577; // sqrt(2 + |1-2|) / (3*1*1) = sqrt(1) / 3 = 1/3 ≈ 0.333
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 0.408; // sqrt(2 + |2-2|) / (3*2*1) = sqrt(2) / 6 ≈ 1.414/6 ≈ 0.236
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.354; // sqrt(2 + |1-4|) / (3*1*4) = sqrt(5) / 12 ≈ 2.236/12 ≈ 0.186
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}