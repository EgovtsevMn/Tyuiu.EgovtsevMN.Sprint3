using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint3.Task6.V.Lib;

namespace Tyuiu.EgovtsevMN.Sprint3.Task6.V.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(12, 18);
            Assert.AreEqual(res, 29);
        }
    }
}
