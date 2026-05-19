using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint2.Task4.V4.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 10.841;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 6.54;
            Assert.AreEqual(wait, res);
        }
    }
}