using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint2.Task7.V5.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.0, 0.5));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.0, 0.0));

            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.0, 1.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.0, -0.1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2.0, 0.5));
        }
    }
}