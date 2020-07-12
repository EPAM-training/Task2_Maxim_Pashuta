using EPAM_Task2.Task3.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM_Task2_Test.Task3
{
    /// <summary>
    /// Class for testing the class Furniture.
    /// </summary>
    [TestClass]
    public class FurnitureUnitTest
    {
        /// <summary>
        /// The method for testing operator +.
        /// </summary>
        [TestMethod]
        public void Test_OperatorPlus()
        {
            var furniture1 = new Furniture("furniture", "cupboard", 120.99m);
            var furniture2 = new Furniture("furniture", "table", 50.99m);
            var result = furniture1 + furniture2;
            var actualResult = new Furniture("furniture", "cupboard-table", 85.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Technics.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToTechnics()
        {
            var furniture = new Furniture("furniture", "cupboard", 120.99m);
            var result = (Technics)furniture;
            var actualResult = new Technics("furniture", "cupboard", 120.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Food.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToFood()
        {
            var furniture = new Furniture("furniture", "cupboard", 120.99m);
            var result = (Food)furniture;
            var actualResult = new Food("furniture", "cupboard", 120.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Int32.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToInt32()
        {
            var furniture = new Furniture("furniture", "cupboard", 120.99m);
            var result = (int)furniture;
            var actualResult = 12099;
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Decimal.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToDecimal()
        {
            var furniture = new Furniture("furniture", "cupboard", 120.99m);
            var result = (decimal)furniture;
            var actualResult = 120.99m;
            Assert.AreEqual(result, actualResult);
        }
    }
}
