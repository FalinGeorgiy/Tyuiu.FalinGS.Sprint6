﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint6.Task0.V25.Lib;


namespace Tyuiu.FalinGS.Sprint6.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1.667;
            Assert.AreEqual(wait,res);
        }
    }
}
