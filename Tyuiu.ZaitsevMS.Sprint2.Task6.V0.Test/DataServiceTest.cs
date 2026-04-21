using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint2.Task6.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Январь", ds.FindMonthName(1));
            Assert.AreEqual("Февраль", ds.FindMonthName(2));
            Assert.AreEqual("Март", ds.FindMonthName(3));
            Assert.AreEqual("Апрель", ds.FindMonthName(4));
            Assert.AreEqual("Май", ds.FindMonthName(5));
            Assert.AreEqual("Июнь", ds.FindMonthName(6));
            Assert.AreEqual("Июль", ds.FindMonthName(7));
            Assert.AreEqual("Август", ds.FindMonthName(8));
            Assert.AreEqual("Сентябрь", ds.FindMonthName(9));
            Assert.AreEqual("Октябрь", ds.FindMonthName(10));
            Assert.AreEqual("Ноябрь", ds.FindMonthName(11));
            Assert.AreEqual("Декабрь", ds.FindMonthName(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(13);
            });
        }
    }
}
