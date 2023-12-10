﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint6.Task2.V22.Lib;

namespace Tyuiu.FalinGS.Sprint6.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 1;
            valueWaitArray[1] = 1;
            valueWaitArray[2] = 1;
            valueWaitArray[3] = 1;
            valueWaitArray[4] = 1;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = 1;
            valueWaitArray[7] = 1;
            valueWaitArray[8] = 1;
            valueWaitArray[9] = 1;
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
