using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint6.Task3.V1.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcArray()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { {25,20,28,2,6},
                                            {19,9,18,-7,24},
                                            {21,16,5,-7,-8},
                                            {30,-13,1,-15,2},
                                            {31,9,-3,-9,-18}};
            int[,] wait = new int[5, 5] {   {19,20,28,2,6},
                                            {21,9,18,-7,24},
                                            {25,16,5,-7,-8},
                                            {30,-13,1,-15,2},
                                            {31,9,-3,-9,-18}};
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
