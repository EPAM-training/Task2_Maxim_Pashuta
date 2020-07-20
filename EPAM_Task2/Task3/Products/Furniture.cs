namespace EPAM_Task2.Task3.Products
{
    /// <summary>
    /// Class for working with furniture.
    /// </summary>
    public class Furniture : Product
    {
        /// <summary>
        /// Constructor to initialize a furniture.
        /// </summary>
        /// <param name="type">Product type</param>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price</param>
        public Furniture(string type, string name, decimal price) : base(type, name, price)
        {
        }

        /// <summary>
        /// Overriding the operator + to add furnitures.
        /// </summary>
        /// <param name="technics1">First food</param>
        /// <param name="technics2">Second food</param>
        /// <returns>Food</returns>
        public static Furniture operator +(Furniture furniture1, Furniture furniture2)
        {
            return new Furniture(furniture1.Type, string.Format($"{furniture1.Name}-{furniture2.Name}"), (furniture1.Price + furniture2.Price) / 2);
        }

        /// <summary>
        /// Overriding the operator to convert furniture to technics.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator Technics(Furniture furniture)
        {
            return new Technics(furniture.Type, furniture.Name, furniture.Price);
        }

        /// <summary>
        /// Overriding the operator to convert furniture to food.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator Food(Furniture furniture)
        {
            return new Food(furniture.Type, furniture.Name, furniture.Price);
        }

        /// <summary>
        /// Overriding the operator to convert furniture to Int32.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator int(Furniture furniture)
        {
            return (int)(furniture.Price * 100);
        }

        /// <summary>
        /// Overriding the operator to convert furniture to decimal.
        /// </summary>
        /// <param name="technics">Food for converting</param>
        public static explicit operator decimal(Furniture furniture)
        {
            return furniture.Price;
        }

        /// <summary>
        /// Method for equal the current object with the specified object.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Furniture))
            {
                return false;
            }

            Furniture furniture = (Furniture)obj;

            return ((_type == furniture.Type) && (_name == furniture.Name) && (_price == furniture.Price));
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return ((_name.GetHashCode() ^ 21) ^ (_type.GetHashCode() ^ 22) ^ (_price.GetHashCode() ^ 23));
        }
    }
}
