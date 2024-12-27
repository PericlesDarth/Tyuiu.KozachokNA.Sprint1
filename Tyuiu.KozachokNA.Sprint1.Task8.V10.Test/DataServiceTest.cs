using Tyuiu.KozachokNA.Sprint1.Task8.V10.Lib;

namespace Tyuiu.KozachokNA.Sprint1.Task8.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double foo = -13.142;
            double bar = ds.Calculate(1);

            Assert.AreEqual(foo, bar);
        }
    }
}