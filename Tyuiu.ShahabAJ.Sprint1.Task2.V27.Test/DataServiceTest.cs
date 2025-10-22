using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task2.V27.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculatePerimetr()
        {
            DataService ds = new DataService();
            int a = 5;
            var res = ds.CalculatePerimetr(a);
            Assert.AreEqual(20, res);
        }
    }
}