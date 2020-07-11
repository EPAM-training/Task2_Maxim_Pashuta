using System;
using System.Collections.Generic;
using System.Text;

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
        /// 
        /// </summary>
        /// <param name="threeDemVector1"></param>
        /// <param name="threeDemVector2"></param>
        /// <returns></returns>
        public static ThreeDimensionalVector operator +(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return new ThreeDimensionalVector(threeDemVector1.X + threeDemVector2.X,
                                              threeDemVector1.Y + threeDemVector2.Y,
                                              threeDemVector1.Z + threeDemVector2.Z);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="threeDemVector1"></param>
        /// <param name="threeDemVector2"></param>
        /// <returns></returns>
        public static ThreeDimensionalVector operator -(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return new ThreeDimensionalVector(threeDemVector1.X - threeDemVector2.X,
                                              threeDemVector1.Y - threeDemVector2.Y,
                                              threeDemVector1.Z - threeDemVector2.Z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="threeDemVector1"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static ThreeDimensionalVector operator *(ThreeDimensionalVector threeDemVector1, int number)
        {
            return new ThreeDimensionalVector(threeDemVector1.X * number,
                                              threeDemVector1.Y * number,
                                              threeDemVector1.Z * number);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="threeDemVector1"></param>
        /// <returns></returns>
        public static ThreeDimensionalVector operator *(int number, ThreeDimensionalVector threeDemVector1)
        {
            return threeDemVector1 * number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="threeDemVector1"></param>
        /// <param name="number"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="threeDemVector1"></param>
        /// <param name="threeDemVector2"></param>
        /// <returns></returns>
        public static int operator *(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return threeDemVector1.X * threeDemVector2.X +
                   threeDemVector1.Y * threeDemVector2.Y +
                   threeDemVector1.Z * threeDemVector2.Z;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="threeDemVector1"></param>
        /// <param name="threeDemVector2"></param>
        /// <returns></returns>
        public static ThreeDimensionalVector CrossVectors(ThreeDimensionalVector threeDemVector1, ThreeDimensionalVector threeDemVector2)
        {
            return new ThreeDimensionalVector(threeDemVector1.Y * threeDemVector2.Z - threeDemVector1.Z * threeDemVector2.Y,
                                              threeDemVector1.Z * threeDemVector2.X - threeDemVector1.X * threeDemVector2.Z,
                                              threeDemVector1.X * threeDemVector2.Y - threeDemVector1.Y * threeDemVector2.X);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode()) * 3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"({X}; {Y}; {Z})");
        }
    }
}
