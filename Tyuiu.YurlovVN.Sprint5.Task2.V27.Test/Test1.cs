using Tyuiu.YurlovVN.Sprint5.Task2.V27.Lib;
namespace Tyuiu.YurlovVN.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\vitya\AppData\Local\Temp\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }

}