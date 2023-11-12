using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint4.Task5.V23.Lib;

namespace Tyuiu.ZargarovAA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 5, -4, 5, -2, 5 },
                                          { 5, 5, -3, 8, 4 },
                                          { 8, -2, 5, 8, -4 },
                                          { -3, 5, -1, 4, 8 },
                                          { 8, -5, 6, -2, 8 } };

            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 5, 0, 5, 0, 5 },
                            { 5, 5, 0, 8, 4 },
                            { 8, 0, 5, 8, 0 },
                            { 0, 5, 0, 4, 8 },
                            { 8, 0, 6, 0, 8 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}