using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint3.Task5.V27.Lib;

namespace Tyuiu.EgovtsevMN.Sprint3.Task5.V.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 79.988;
            Assert.AreEqual(wait, ds.GetSumSumSeries(1, 1, 3, 1, 6));
        }
    }
}
