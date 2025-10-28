using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ShahabAJ.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLowerCaseRus()
        {
            DataService ds = new DataService();
            string text = "приветмир";
            bool wait = true;
            bool result = ds.CheckLowerCaseRusLetters(text);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidWithYoLetter()
        {
            DataService ds = new DataService();
            string text = "ёлка";
            bool wait = true;
            bool result = ds.CheckLowerCaseRusLetters(text);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void InvalidWithUpperCase()
        {
            DataService ds = new DataService();
            string text = "Привет";
            bool wait = false;
            bool result = ds.CheckLowerCaseRusLetters(text);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void InvalidWithNumbers()
        {
            DataService ds = new DataService();
            string text = "привет123";
            bool wait = false;
            bool result = ds.CheckLowerCaseRusLetters(text);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void InvalidWithSpaces()
        {
            DataService ds = new DataService();
            string text = "привет мир";
            bool wait = false;
            bool result = ds.CheckLowerCaseRusLetters(text);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void InvalidEmptyString()
        {
            DataService ds = new DataService();
            string text = "";
            bool wait = false;
            bool result = ds.CheckLowerCaseRusLetters(text);
            Assert.AreEqual(wait, result);
        }
    }
}
