using System;

namespace EPAM_Task2.Task1
{
    /// <summary>
    /// Class for working with three-dimensional vector.
    /// </summary>
    public class ThreeDimensionalVector
    {
        /// <summary>
        /// Constructor to initialize a three-dimensional vector through three coords.
        /// </summary>
        /// <param name="x">Coord X</param>
        /// <param name="y">Coord Y</param>
        /// <param name="z">Coord Z</param>
        public ThreeDimensionalVector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        /// <summary>
        /// Addition of vectors by adding the corresponding coordinates.
        /// </summary>
        /// <param name="threeDemVector1">First three-dimensional vector</param>
        /// <param name="threeDemVector2">Second three-dimensional vector</param>
        /// <returns>Three-dimensional vector</returns>
        public static ThreeDimensionalVector operator +(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return new ThreeDimensionalVector(threeDemVector1.X + threeDemVector2.X,
                                              threeDemVector1.Y + threeDemVector2.Y,
                                              threeDemVector1.Z + threeDemVector2.Z);
        }


        /// <summary>
        /// The difference of vectors by subtracting the corresponding coordinates.
        /// </summary>
        /// <param name="threeDemVector1">First three-dimensional vector</param>
        /// <param name="threeDemVector2">Second three-dimensional vector</param>
        /// <returns>Three-dimensional vector</returns>
        public static ThreeDimensionalVector operator -(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return new ThreeDimensionalVector(threeDemVector1.X - threeDemVector2.X,
                                              threeDemVector1.Y - threeDemVector2.Y,
                                              threeDemVector1.Z - threeDemVector2.Z);
        }

        /// <summary>
        /// Multiplying a vector by a number by multiplying the number by the coordinates.
        /// </summary>
        /// <param name="threeDemVector1">Three-dimensional vector</param>
        /// <param name="number">Any number</param>
        /// <returns>Three-dimensional vector</returns>
        public static ThreeDimensionalVector operator *(ThreeDimensionalVector threeDemVector1, int number)
        {
            return new ThreeDimensionalVector(threeDemVector1.X * number,
                                              threeDemVector1.Y * number,
                                              threeDemVector1.Z * number);
        }

        /// <summary>
        /// Multiplying a number by a vector by multiplying the number by the coordinates.
        /// </summary>
        /// <param name="number">Any number</param>
        /// <param name="threeDemVector1">Three-dimensional vector</param>
        /// <returns>Three-dimensional vector</returns>
        public static ThreeDimensionalVector operator *(int number, ThreeDimensionalVector threeDemVector1)
        {
            return threeDemVector1 * number;
        }

        /// <summary>
        /// Dividing a vector by a number by dividing each coordinate by a number.
        /// </summary>
        /// <param name="threeDemVector1">Three-dimensional vector</param>
        /// <param name="number">Any number</param>
        /// <returns>Three-dimensional vector</returns>
        public static ThreeDimensionalVector operator /(ThreeDimensionalVector threeDemVector1, int number)
        {
            if (number == 0)
            {
                throw new ArgumentException("The argument is equal zero.", "number");
            }

            return new ThreeDimensionalVector(threeDemVector1.X / number,
                                              threeDemVector1.Y / number,
                                              threeDemVector1.Z / number);
        }

        /// <summary>
        /// Scalar multiplication of vectors by adding the products of the corresponding coordinates.
        /// </summary>
        /// <param name="threeDemVector1">First three-dimensional vector</param>
        /// <param name="threeDemVector2">Second three-dimensional vector</param>
        /// <returns>Any number</returns>
        public static int operator *(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return threeDemVector1.X * threeDemVector2.X +
                   threeDemVector1.Y * threeDemVector2.Y +
                   threeDemVector1.Z * threeDemVector2.Z;
        }

        /// <summary>
        /// Vector multiplication of vectors.
        /// </summary>
        /// <param name="threeDemVector1">First three-dimensional vector</param>
        /// <param name="threeDemVector2">Second three-dimensional vector</param>
        /// <returns>Three-dimensional vector</returns>
        public static ThreeDimensionalVector CrossVectors(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return new ThreeDimensionalVector(threeDemVector1.Y * threeDemVector2.Z - threeDemVector1.Z * threeDemVector2.Y,
                                              threeDemVector1.Z * threeDemVector2.X - threeDemVector1.X * threeDemVector2.Z,
                                              threeDemVector1.X * threeDemVector2.Y - threeDemVector1.Y * threeDemVector2.X);
        }

        /// <summary>
        /// Method for equal the current object with the specified object.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is ThreeDimensionalVector))
            {
                return false;
            }

            var threeDemVector = (ThreeDimensionalVector)obj;

            return X.Equals(threeDemVector.X) &&
                   Y.Equals(threeDemVector.Y) &&
                   Z.Equals(threeDemVector.Z);
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return (X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode()) * 3;
        }

        /// <summary>
        /// The method creates and returns a string representation of the object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return string.Format($"({X}; {Y}; {Z})");
        }
    }
}
