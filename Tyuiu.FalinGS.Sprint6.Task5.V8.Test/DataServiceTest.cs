using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint6.Task5.V8.Lib;

namespace Tyuiu.FalinGS.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask5V8.txt";

            double[] res = ds.LoadFromDataFile(path);

            double[] wait = { -13, -19, -9.82, -9.71, -0.11 , -17.36,-12 , -12.35  };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
