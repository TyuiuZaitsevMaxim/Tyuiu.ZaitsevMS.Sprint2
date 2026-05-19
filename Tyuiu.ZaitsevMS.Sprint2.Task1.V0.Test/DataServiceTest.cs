using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint2.Task1.V24.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod] 
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}