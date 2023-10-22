using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint3.Task0.V22.Lib;

namespace Tyuiu.EgovtsevMN.Sprint3.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;
            double wait = 1.629;


            double res = ds.GetSumSeries(startValue, stopValue);


            Assert.AreEqual(wait, res);

        }
    }
}
