using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint5.Task4.V27.Lib;
using System.IO;

namespace Tyuiu.KosishnevaAN.Sprint5.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.KosishnevaAN.Sprint5\Tyuiu.KosishnevaAN.Sprint5.Task4.V27\bin\Debug\InPutDataFileTask4V27.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
