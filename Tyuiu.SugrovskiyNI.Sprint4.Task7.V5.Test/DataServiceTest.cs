using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint4.Task7.V5.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "246813579";
            DataService ds = new DataService();
            double res = ds.Calculate(n, m, str);
            double wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
