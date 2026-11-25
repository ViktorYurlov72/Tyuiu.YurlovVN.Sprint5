namespace Tyuiu.YurlovVN.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\vitya\source\repos\Tyuiu.YurlovVN.Sprint5\Tyuiu.YurlovVN.Sprint5.Task3.V28\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}