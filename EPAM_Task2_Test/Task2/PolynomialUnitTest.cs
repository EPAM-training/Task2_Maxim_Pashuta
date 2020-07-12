using EPAM_Task2.Task2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM_Task2_Test.Task2
{
    /// <summary>
    /// Class for testing the class Polynomial.
    /// </summary>
    [TestClass]
    public class PolynomialUnitTest
    {
        /// <summary>
        /// Method for testing operator + when the degrees of both polynomials are equal.
        /// </summary>
        [TestMethod]
        public void OperatorPlus_WhenDegreeBothPolynomialsEquals_GetPolynomial()
        {
            var polynomial1 = new Polynomial(7, 8, 9);
            var polynomial2 = new Polynomial(3, 2, 1);
            var result = polynomial1 + polynomial2;
            var actualResult = new Polynomial(10, 10, 10);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator + when the degrees of both polynomials aren't equal.
        /// </summary>
        [TestMethod]
        public void OperatorPlus_WhenDegreeBothPolynomialsNotEquals_GetPolynomial()
        {
            var polynomial1 = new Polynomial(7, 8, 9);
            var polynomial2 = new Polynomial(9, 5, 14, 19, 36);
            var result = polynomial1 + polynomial2;
            var actualResult = new Polynomial(16, 13, 23, 19, 36);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator - when the degrees of both polynomials are equal.
        /// </summary>
        [TestMethod]
        public void OperatorMinus_WhenDegreeBothPolynomialsEquals_GetPolynomial()
        {
            var polynomial1 = new Polynomial(7, 8, 9);
            var polynomial2 = new Polynomial(3, 2, 1);
            var result = polynomial1 - polynomial2;
            var actualResult = new Polynomial(4, 6, 8);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator - when the degrees of both polynomials aren't equal.
        /// </summary>
        [TestMethod]
        public void OperatorMinus_WhenDegreeBothPolynomialsNotEquals_GetPolynomial()
        {
            var polynomial1 = new Polynomial(7, 8, 9);
            var polynomial2 = new Polynomial(9, 5, 14, 19, 36);
            var result = polynomial1 - polynomial2;
            var actualResult = new Polynomial(-2, 3, -5, -19, -36);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator * when the positive polynamial and the negative number.
        /// </summary>
        [TestMethod]
        public void OperatorMultiply_WithPositivePolynomialAndNegativeNumber_GetNegativePolynomial()
        {
            var polynomial = new Polynomial(7, 8, 9);
            var number = -2;
            var result = polynomial * number;
            var actualResult = new Polynomial(-14, -16, -18);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator * when the negative polynamial and the positive number.
        /// </summary>
        [TestMethod]
        public void OperatorMultiply_WithNegativePolynomialAndNegativeNumber_GetPositivePolynomial()
        {
            var polynomial = new Polynomial(-7, -8, -9);
            var number = -2;
            var result = polynomial * number;
            var actualResult = new Polynomial(14, 16, 18);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator / when the positive polynamial and the negative number.
        /// </summary>
        [TestMethod]
        public void OperatorDivision_WithPositivePolynomialAndNegativeNumber_GetNegativePolynomial()
        {
            var polynomial = new Polynomial(14, 26, 8);
            var number = -2;
            var result = polynomial / number;
            var actualResult = new Polynomial(-7, -13, -4);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator / when the negative polynamial and the positive number.
        /// </summary>
        [TestMethod]
        public void OperatorDivision_WithNegativePolynomialAndNegativeNumber_GetPositivePolynomial()
        {
            var polynomial = new Polynomial(-18, -8, -12);
            var number = -2;
            var result = polynomial / number;
            var actualResult = new Polynomial(9, 4, 6);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator * when the degrees of both polynomials are equal.
        /// </summary>
        [TestMethod]
        public void OperatorMultiply_WhenDegreeBothPolynomialsEquals_GetPolynomial()
        {
            var polynomial1 = new Polynomial(1, -1);
            var polynomial2 = new Polynomial(-3, 1);
            var result = polynomial1 * polynomial2;
            var actualResult = new Polynomial(-3, 4, -1);
            Assert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// Method for testing operator * when the degrees of both polynomials are equal.
        /// </summary>
        [TestMethod]
        public void OperatorMultiply_WhenDegreeBothPolynomialsNotEquals_GetPolynomial()
        {
            var polynomial1 = new Polynomial(1, -1);
            var polynomial2 = new Polynomial(-3, 1, 2);
            var result = polynomial1 * polynomial2;
            var actualResult = new Polynomial(-3, 4, 1, -2);
            Assert.AreEqual(result, actualResult);
        }
    }
}
