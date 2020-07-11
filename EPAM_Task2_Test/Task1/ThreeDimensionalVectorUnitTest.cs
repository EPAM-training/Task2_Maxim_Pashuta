using EPAM_Task2.Task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EPAM_Task2_Test.Task1
{
    [TestClass]
    public class ThreeDimensionalVectorUnitTest
    {
        [TestMethod]
        public void OperatorPlus_WithTwoPosiniveVector_GetPositiveVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(5, 10, 6);
            var threeDimVector2 = new ThreeDimensionalVector(8, 14, 3);
            var result = threeDimVector1 + threeDimVector2;
            var actualResult = new ThreeDimensionalVector(13, 24, 9);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorPlus_WithTwoNegativeVector_GetNegativeVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(-12, -10, -8);
            var threeDimVector2 = new ThreeDimensionalVector(-18, -15, -16);
            var result = threeDimVector1 + threeDimVector2;
            var actualResult = new ThreeDimensionalVector(-30, -25, -24);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorPlus_WhenFirstVectorIsOppositeSecondVector_GetZeroVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(-12, -10, -8);
            var threeDimVector2 = new ThreeDimensionalVector(12, 10, 8);
            var result = threeDimVector1 + threeDimVector2;
            var actualResult = new ThreeDimensionalVector(0, 0, 0);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMinus_WhenFirstVectorMoreSecondVector_GetPositiveVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(14, 10, 18);
            var threeDimVector2 = new ThreeDimensionalVector(12, 7, 8);
            var result = threeDimVector1 - threeDimVector2;
            var actualResult = new ThreeDimensionalVector(2, 3, 10);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMinus_WhenFirstVectorLessSecondVector_GetNegativeVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(8, 4, 2);
            var threeDimVector2 = new ThreeDimensionalVector(15, 7, 4);
            var result = threeDimVector1 - threeDimVector2;
            var actualResult = new ThreeDimensionalVector(-7, -3, -2);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMinus_WhenFirstVectorEqualSecondVector_GetZeroVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(9, 4, 2);
            var threeDimVector2 = new ThreeDimensionalVector(9, 4, 2);
            var result = threeDimVector1 - threeDimVector2;
            var actualResult = new ThreeDimensionalVector(0, 0, 0);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMinus_WhenFirstVectorIsPositiveSecondVectorIsNegative_GetPositiveVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(9, 4, 2);
            var threeDimVector2 = new ThreeDimensionalVector(-9, -4, -2);
            var result = threeDimVector1 - threeDimVector2;
            var actualResult = new ThreeDimensionalVector(18, 8, 4);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMinus_WhenFirstVectorIsNegativeSecondVectorIsPositive_GetNegativeVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(-9, -4, -2);
            var threeDimVector2 = new ThreeDimensionalVector(9, 4, 2);
            var result = threeDimVector1 - threeDimVector2;
            var actualResult = new ThreeDimensionalVector(-18, -8, -4);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMultiply_WhenVectorIsPositiveNumberIsNegative_GetNegativeVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(10, 14, 25);
            int number = -5;
            var result = threeDimVector1 * number;
            var actualResult = new ThreeDimensionalVector(-50, -70, -125);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMultiply_WhenVectorIsNegativeNumberIsPositive_GetNegativeVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(-10, -14, -25);
            int number = 4;
            var result = threeDimVector1 * number;
            var actualResult = new ThreeDimensionalVector(-40, -56, -100);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorMultiply_WhenNumberIsZero_GetZeroVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(-10, -14, -25);
            int number = 0;
            var result = threeDimVector1 * number;
            var actualResult = new ThreeDimensionalVector(0, 0, 0);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void OperatorDivision_WhenFirstVectorIsNegativeNumberIsPositive_GetNegativeVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(10, 14, 6);
            int number = -2;
            var result = threeDimVector1 / number;
            var actualResult = new ThreeDimensionalVector(-5, -7, -3);
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OperatorDivision_WhenNumberIsZero_GetArgumentExeption()
        {
            var threeDimVector1 = new ThreeDimensionalVector(-10, -14, -25);
            int number = 0;
            var result = threeDimVector1 / number;
        }

        [TestMethod]
        public void OperatorMultiply_WithTwoPositiveVectors_GetPositiveVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(7, 1, 5);
            var threeDimVector2 = new ThreeDimensionalVector(9, 4, 2);
            var result = threeDimVector1 * threeDimVector2;
            var actualResult = 77;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void CrossVectors_WithTwoPositiveVectors_GetPositiveVector()
        {
            var threeDimVector1 = new ThreeDimensionalVector(7, 1, 5);
            var threeDimVector2 = new ThreeDimensionalVector(9, 4, 2);
            var result = ThreeDimensionalVector.CrossVectors(threeDimVector1, threeDimVector2);
            var actualResult = new ThreeDimensionalVector(-18, 31, 19);
            Assert.AreEqual(result, actualResult);
        }
    }
}