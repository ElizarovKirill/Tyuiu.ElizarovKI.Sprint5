﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ElizarovKI.Sprint5.Task1.V27.Lib;

namespace Tyuiu.ElizarovKI.Sprint5.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\cvaga\source\repos\Tyuiu.ElizarovKI.Sprint5\Tyuiu.ElizarovKI.Sprint5.Task1.V27\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
