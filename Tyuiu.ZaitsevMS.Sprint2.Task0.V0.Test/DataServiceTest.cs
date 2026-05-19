using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint2.Task0.V15.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations() 
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 275;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] expected = new bool[6] { false, false, true, true, false, false };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}