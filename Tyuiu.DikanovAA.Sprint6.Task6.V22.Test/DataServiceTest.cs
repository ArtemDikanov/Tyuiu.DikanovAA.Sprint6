using System.Security.Cryptography.X509Certificates;
using Tyuiu.DikanovAA.Sprint6.Task6.V22.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            string wait = "MLgyapdkEPQzlIOuDWllTMRyztkPxzEVkcarVMlQunwTmf";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);

        }
    }
}