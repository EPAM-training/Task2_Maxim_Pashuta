using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task2.Task2
{
    /// <summary>
    /// Class for wirking with polynomial.
    /// </summary>
    public class Polynomial
    {
        public readonly double[] Coefficients;
        public readonly int Degree;

        public Polynomial(params double[] coefficients)
        {
            Coefficients = coefficients;
            Degree = Coefficients.Length;
        }

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

        public static Polynomial operator *(Polynomial polynomial, double number)
        {
            double[] resultCoefficients = polynomial.Coefficients;

            for (int i = 0; i < resultCoefficients.Length; i++)
            {
                resultCoefficients[i] *= number;
            }

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator /(Polynomial polynomial, double number)
        {
            double[] resultCoefficients = polynomial.Coefficients;

            for (int i = 0; i < resultCoefficients.Length; i++)
            {
                resultCoefficients[i] /= number;
            }

            return new Polynomial(resultCoefficients);
        }

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

        public override int GetHashCode()
        {
            return (Coefficients.GetHashCode() + Degree.GetHashCode()) * Degree;
        }

        public override string ToString()
        {
            return string.Format($"[{string.Join(';', Coefficients)}]");
        }
    }
}
