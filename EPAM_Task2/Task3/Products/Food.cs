namespace EPAM_Task2.Task3.Products
{
    /// <summary>
    /// Class for working with food.
    /// </summary>
    public class Food : Product
    {
        /// <summary>
        /// Constructor to initialize a food.
        /// </summary>
        /// <param name="type">Product type</param>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price</param>
        public Food(string type, string name, decimal price) : base(type, name, price)
        {
        }

        /// <summary>
        /// Overriding the operator + to add foods.
        /// </summary>
        /// <param name="technics1">First food</param>
        /// <param name="technics2">Second food</param>
        /// <returns>Food</returns>
        public static Food operator +(Food food1, Food food2)
        {
            return new Food(food1.Type, string.Format($"{food1.Name}-{food2.Name}"), (food1.Price + food2.Price) / 2);
        }

        /// <summary>
        /// Overriding the operator to convert food to technics.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator Technics(Food food)
        {
            return new Technics(food.Type, food.Name, food.Price);
        }

        /// <summary>
        /// Overriding the operator to convert food to furniture.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator Furniture(Food food)
        {
            return new Furniture(food.Type, food.Name, food.Price);
        }

        /// <summary>
        /// Overriding the operator to convert food to Int32.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator int(Food food)
        {
            return (int)(food.Price * 100);
        }

        /// <summary>
        /// Overriding the operator to convert food to decimal.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator decimal(Food food)
        {
            return food.Price;
        }

        /// <summary>
        /// Method for equal the current object with the specified object.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Food))
            {
                return false;
            }

            var food = (Food)obj;

            return ((_type == food.Type) && (_name == food.Name) && (_price == food.Price));
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return ((_name.GetHashCode() ^ 11) ^ (_type.GetHashCode() ^ 12) ^ (_price.GetHashCode() ^ 13));
        }
    }
}
