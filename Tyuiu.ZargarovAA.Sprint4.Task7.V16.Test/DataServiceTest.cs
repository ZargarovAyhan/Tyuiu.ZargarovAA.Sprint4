using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint4.Task7.V16.Lib;

namespace Tyuiu.ZargarovAA.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int rows = 5, colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "382976421897948";

            int res = ds.Calculate(rows, colums, str);

            Assert.AreEqual(196608, res);
        }
    }
}