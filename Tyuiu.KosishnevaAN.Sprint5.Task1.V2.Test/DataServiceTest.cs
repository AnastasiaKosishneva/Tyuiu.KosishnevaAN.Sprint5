using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint5.Task1.V2.Lib;
using System.IO;

namespace Tyuiu.KosishnevaAN.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.KosishnevaAN.Sprint5\Tyuiu.KosishnevaAN.Sprint5.Task1.V2\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
