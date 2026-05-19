using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint2.Task2.V14.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void InvalidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 0;
            int y = 0;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void OutOfBoundsCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 20;
            int y = 20;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}