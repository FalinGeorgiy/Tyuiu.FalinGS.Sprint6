using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint6.Task6.V27.Lib;

namespace Tyuiu.FalinGS.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V27.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "UpGwjzkBH OHcr KgepHrKCHa FVUh XIpph hZznJL";

            Assert.AreEqual(wait, res);
        }
    }
}
