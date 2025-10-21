using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task0.V28.Lib;

namespace Tyuiu.Shahab1.Sprint1.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}