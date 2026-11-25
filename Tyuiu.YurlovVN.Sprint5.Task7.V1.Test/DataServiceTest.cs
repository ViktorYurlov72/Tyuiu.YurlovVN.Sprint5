using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.YurlovVN.Sprint5.Task7.V1.Lib;

namespace Tyuiu.YurlovVN.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            string pathSaveFile = ds.LoadDataAndSave(path);

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}