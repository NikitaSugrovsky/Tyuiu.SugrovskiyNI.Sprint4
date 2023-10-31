using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint4.Task1.V6.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VlidCalculate()
        {
            DataService ds = new DataService();
            int[] sumArray = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            int res = ds.Calculate(sumArray); // Возвращается сумма четных элементов, а не массив
            int wait = 20;

            Assert.AreEqual(wait, res);
        }
    }
}
