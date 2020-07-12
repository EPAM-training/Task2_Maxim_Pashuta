using EPAM_Task2.Task3.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM_Task2_Test.Task3
{
    /// <summary>
    /// Class for testing the class Food.
    /// </summary>
    [TestClass]
    public class FoodUnitTest
    {
        /// <summary>
        /// The method for testing operator +.
        /// </summary>
        [TestMethod]
        public void Test_OperatorPlus()
        {
            var food1 = new Food("food", "milk", 13.99m);
            var food2 = new Food("food", "meat", 15.99m);
            Food result = food1 + food2;
            var actualResult = new Food("food", "milk-meat", 14.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Technics.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToTechnics()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (Technics)food;
            var actualResult = new Technics("food", "milk", 13.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Furniture.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToFurniture()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (Furniture)food;
            var actualResult = new Furniture("food", "milk", 13.99m);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Int32.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToInt32()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (int)food;
            int actualResult = 1399;
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// The method for testing conversion to Decimal.
        /// </summary>
        [TestMethod]
        public void Test_ConvertToDecimal()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (decimal)food;
            decimal actualResult = 13.99m;
            Assert.AreEqual(result, actualResult);
        }
    }
}
