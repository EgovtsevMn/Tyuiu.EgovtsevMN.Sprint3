using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint3.Task4.V13.Lib;

namespace Tyuiu.EgovtsevMN.Sprint3.Task4.V.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = -44.313;
            Assert.AreEqual(wait, res);
        }
    }
}
