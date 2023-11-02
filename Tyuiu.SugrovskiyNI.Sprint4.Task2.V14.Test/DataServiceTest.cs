using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint4.Task2.V14.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = new int[12];

            int res = ds.Calculate(numsArray);
            int wait = 147;

            Assert.AreEqual(wait, res);
        }
    }
}
