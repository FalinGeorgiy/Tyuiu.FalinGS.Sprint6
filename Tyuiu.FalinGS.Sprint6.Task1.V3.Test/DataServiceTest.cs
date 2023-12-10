using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint6.Task1.V3.Lib;

namespace Tyuiu.FalinGS.Sprint6.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 1;
            valueWaitArray[1] = 2;
            valueWaitArray[2] = 5;
            valueWaitArray[3] = 2;
            valueWaitArray[4] = 1;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 5;
            valueWaitArray[7] = 16;
            valueWaitArray[8] = 5.1;
            valueWaitArray[9] = 2;
            valueWaitArray[10] = 6.3;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            
            for (int i = 0; i < valueWaitArray.Length; i++)
            {
                valueWaitArray[i] = Math.Round(valueWaitArray[i], 2);
            }
        }
    }
}
