using EPAM_Task2.Task3.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM_Task2_Test.Task3
{
    [TestClass]
    public class FoodUnitTest
    {
        [TestMethod]
        public void Test_OperatorPlus()
        {
            var food1 = new Food("food", "milk", 13.99m);
            var food2 = new Food("food", "meat", 15.99m);
            var result = food1 + food2;
            var actualResult = new Food("food", "milk-meat", 14.99m);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToTechnics()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (Technics)food;
            var actualResult = new Technics("food", "milk", 13.99m);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToFurniture()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (Furniture)food;
            var actualResult = new Furniture("food", "milk", 13.99m);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToInt32()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (int)food;
            var actualResult = 1399;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void Test_ConvertToDecimal()
        {
            var food = new Food("food", "milk", 13.99m);
            var result = (decimal)food;
            var actualResult = 13.99m;
            Assert.AreEqual(result, actualResult);
        }
    }
}
