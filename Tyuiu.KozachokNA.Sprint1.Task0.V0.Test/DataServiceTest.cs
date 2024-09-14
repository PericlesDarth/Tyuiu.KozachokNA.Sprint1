using Tyuiu.KozachokNA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.KozachokNA.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDivisionValid()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(res, 3);
        }
    }
}