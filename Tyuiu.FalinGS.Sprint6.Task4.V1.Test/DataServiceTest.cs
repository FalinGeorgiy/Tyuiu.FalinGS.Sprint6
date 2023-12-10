using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint6.Task4.V1.Lib;

namespace Tyuiu.FalinGS.Sprint6.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            string path = @"C:\DataSprint5\OutPutFileTask4.txt";
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 7;
            valueWaitArray[1] = 7;
            valueWaitArray[2] = 7;
            valueWaitArray[3] = 2;
            valueWaitArray[4] = 15;
            valueWaitArray[5] = 2;
            valueWaitArray[6] = 4;
            valueWaitArray[7] = 3;
            valueWaitArray[8] = 6;
            valueWaitArray[9] = 6;
            valueWaitArray[10] = 1;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            // Округляем значения функции в массиве valueWaitArray перед сравнением с массивом res
            for (int i = 0; i < valueWaitArray.Length; i++)
            {
                valueWaitArray[i] = Math.Round(valueWaitArray[i], 2);
            }
        }
    }
}
