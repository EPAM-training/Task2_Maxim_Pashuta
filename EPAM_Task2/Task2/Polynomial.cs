using System;
using System.Linq;

namespace EPAM_Task2.Task2
{
    /// <summary>
    /// Class for wirking with polynomial.
    /// </summary>
    public class Polynomial
    {
        /// <summary>
        /// A field for storing the coefficients.
        /// </summary>
        public readonly double[] Coefficients;
        /// <summary>
        /// A field for storing the degree.
        /// </summary>
        public readonly int Degree;

        /// <summary>
        /// Constructor to initialize a polynimial through array coefficients.
        /// </summary>
        /// <param name="coefficients">Array coefficients</param>
        public Polynomial(params double[] coefficients)
        {
            Coefficients = coefficients;
            Degree = Coefficients.Length;
        }

        /// <summary>
        /// Overriding the operator + to add polynomials.
        /// </summary>
        /// <param name="polynomial1">First polynomial</param>
        /// <param name="polynomial2">Second polynomial</param>
        /// <returns>Sum of polynomials</returns>
        public static Polynomial operator +(Polynomial polynomial1, Polynomial polynomial2)
        {
            int maxDegree = Math.Max(polynomial1.Degree, polynomial2.Degree);
            double[] newCoefficients = new double[maxDegree];

            for (int i = 0; i < maxDegree; i++)
            {
                double coefficient1 = 0;
                double coefficient2 = 0;

                if (i < polynomial1.Degree)
                {
                    coefficient1 = polynomial1.Coefficients[i];
                }
                if (i < polynomial2.Degree)
                {
                    coefficient2 = polynomial2.Coefficients[i];
                }

                newCoefficients[i] = coefficient1 + coefficient2;
            }

            return new Polynomial(newCoefficients);
        }

        /// <summary>
        /// Overriding the operator - for polynomial difference.
        /// </summary>
        /// <param name="polynomial1">First polynomial</param>
        /// <param name="polynomial2">Second polynomial</param>
        /// <returns>Polynomial difference</returns>
        public static Polynomial operator -(Polynomial polynomial1, Polynomial polynomial2)
        {
            int maxDegree = Math.Max(polynomial1.Degree, polynomial2.Degree);
            double[] newCoefficients = new double[maxDegree];

            for (int i = 0; i < maxDegree; i++)
            {
                double coefficient1 = 0;
                double coefficient2 = 0;

                if (i < polynomial1.Degree)
                {
                    coefficient1 = polynomial1.Coefficients[i];
                }
                if (i < polynomial2.Degree)
                {
                    coefficient2 = polynomial2.Coefficients[i];
                }

                newCoefficients[i] = coefficient1 - coefficient2;
            }

            return new Polynomial(newCoefficients);
        }

        /// <summary>
        /// Overriding the operator * to multiply the polynomial by a number.
        /// </summary>
        /// <param name="polynomial">Polynomial</param>
        /// <param name="number">Any number</param>
        /// <returns>Result multiplying the polynomial by a number</returns>
        public static Polynomial operator *(Polynomial polynomial, double number)
        {
            double[] resultCoefficients = polynomial.Coefficients;

            for (int i = 0; i < resultCoefficients.Length; i++)
            {
                resultCoefficients[i] *= number;
            }

            return new Polynomial(resultCoefficients);
        }

        /// <summary>
        /// Overriding the operator / to divide the polynomial by a number.
        /// </summary>
        /// <param name="polynomial">Polynomial</param>
        /// <param name="number">Any number</param>
        /// <returns>Result dividing the polynomial by a number</returns>
        public static Polynomial operator /(Polynomial polynomial, double number)
        {
            double[] resultCoefficients = polynomial.Coefficients;

            for (int i = 0; i < resultCoefficients.Length; i++)
            {
                resultCoefficients[i] /= number;
            }

            return new Polynomial(resultCoefficients);
        }

        /// <summary>
        /// Overriding the operator * to multiply the polynomials.
        /// </summary>
        /// <param name="polynomial1">First polynomial</param>
        /// <param name="polynomial2">Second polynomial</param>
        /// <returns>Result multiplying the polynomials</returns>
        public static Polynomial operator *(Polynomial polynomial1, Polynomial polynomial2)
        {
            double[] resultCoefficients = new double[polynomial1.Degree + polynomial2.Degree - 1];

            for (int i = 0; i < polynomial1.Degree; i++)
            {
                for (int j = 0; j < polynomial2.Degree; j++)
                {
                    resultCoefficients[i + j] += polynomial1.Coefficients[i] * polynomial2.Coefficients[j];
                }
            }

            return new Polynomial(resultCoefficients);
        }

        /// <summary>
        /// Method for equal the current object with the specified object.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Polynomial))
            {
                return false;
            }

            var polynomial = (Polynomial)obj;

            if (Degree != polynomial.Degree)
            {
                return false;
            }

            return Enumerable.SequenceEqual(Coefficients, polynomial.Coefficients);
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return (Coefficients.GetHashCode() + Degree.GetHashCode()) * Degree;
        }

        /// <summary>
        /// The method creates and returns a string representation of the object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return string.Format($"[{string.Join(';', Coefficients)}]");
        }
    }
}
