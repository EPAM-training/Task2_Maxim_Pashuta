using EPAM_Task2.Task3.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM_Task2_Test.Task3
{
    [TestClass]
    public class TechnicsUnitTest
    {
        [TestMethod]
        public void Test_OperatorPlus()
        {
            var technics1 = new Technics("techincs", "computer1", 2099.99m);
            var technics2 = new Technics("techincs", "computer2", 3099.99m);
            var result = technics1 + technics2;
            var actualResult = new Technics("techincs", "computer1-computer2", 2599.99m);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToFood()
        {
            var technics = new Technics("techincs", "computer1", 2099.99m);
            var result = (Food)technics;
            var actualResult = new Food("techincs", "computer1", 2099.99m);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToFurniture()
        {
            var technics = new Technics("techincs", "computer1", 2099.99m);
            var result = (Furniture)technics;
            var actualResult = new Furniture("techincs", "computer1", 2099.99m);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToInt32()
        {
            var technics = new Technics("techincs", "computer1", 2099.99m);
            var result = (int)technics;
            var actualResult = 209999;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToDecimal()
        {
            var technics = new Technics("techincs", "computer1", 2099.99m);
            var result = (decimal)technics;
            var actualResult = 2099.99m;
            Assert.AreEqual(result, actualResult);
        }
    }
}
