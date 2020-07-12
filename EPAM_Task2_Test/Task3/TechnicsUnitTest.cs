using EPAM_Task2.Task3.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM_Task2_Test.Task3
{
    /// <summary>
    /// Class for testing the class Technics.
    /// </summary>
    [TestClass]
    public class TechnicsUnitTest
    {
        /// <summary>
        /// The method for testing operator +.
        /// </summary>
        [TestMethod]
        public void Test_OperatorPlus()
        {
            var technics1 = new Technics("technics", "computer1", 2099.99m);
            var technics2 = new Technics("technics", "computer2", 3099.99m);
            var result = technics1 + technics2;
            var actualResult = new Technics("technics", "computer1-computer2", 2599.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Food.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToFood()
        {
            var technics = new Technics("technics", "computer1", 2099.99m);
            var result = (Food)technics;
            var actualResult = new Food("technics", "computer1", 2099.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Furniture.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToFurniture()
        {
            var technics = new Technics("technics", "computer1", 2099.99m);
            var result = (Furniture)technics;
            var actualResult = new Furniture("technics", "computer1", 2099.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Int32.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToInt32()
        {
            var technics = new Technics("technics", "computer1", 2099.99m);
            var result = (int)technics;
            var actualResult = 209999;
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Decimal.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToDecimal()
        {
            var technics = new Technics("technics", "computer1", 2099.99m);
            var result = (decimal)technics;
            var actualResult = 2099.99m;
            Assert.AreEqual(result, actualResult);
        }
    }
}
