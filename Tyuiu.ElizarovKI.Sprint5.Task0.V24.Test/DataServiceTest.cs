using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint5.Task0.V24.Lib;

using System.IO;

namespace Tyuiu.ElizarovKI.Sprint5.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\cvaga\source\repos\Tyuiu.ElizarovKI.Sprint5\Tyuiu.ElizarovKI.Sprint5.Task0.V24\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
