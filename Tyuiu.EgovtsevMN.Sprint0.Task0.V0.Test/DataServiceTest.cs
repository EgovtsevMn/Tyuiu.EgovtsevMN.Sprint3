using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint0.Task0.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint0.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 55217.446;
            double res = ds.GetMultiplySeries(0.25, 1, 8);

            Assert.AreEqual(wait, res, 6);
        }
    }
}
