using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint2.Task1.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 16;
            int c = 14;
            int d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, true, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
