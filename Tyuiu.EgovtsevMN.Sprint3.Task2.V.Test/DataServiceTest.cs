using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint3.Task1.V.Lib;
using Tyuiu.EgovtsevMN.Sprint3.Task1.V22.Lib;

namespace Tyuiu.EgovtsevMN.Sprint3.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 716;

            Assert.AreEqual(wait, res);
        }
    }
}
