using Tyuiu.DikanovAA.Sprint6.Task0.V27.Lib;
namespace Tyuiu.DikanovAA.Sprint6.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(4);
            double wait = -6;
            Assert.AreEqual(wait, res);
        }
    }
}