using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint6.Task2.V18.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = ds.GetMassFunction(start, stop).Length;
            double[] wait = new double[len];
            wait[0] = 23.92;
            wait[1] = 18.88;
            wait[2] = 13.10;
            wait[3] = 7.24;
            wait[4] = 1.80;
            wait[5] = -8.00;
            wait[6] = -5.70;
            wait[7] = -11.26;
            wait[8] = -17.12;
            wait[9] = -22.88;
            wait[10] = -27.92;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
