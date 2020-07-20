namespace EPAM_Task2.Task3.Products
{
    /// <summary>
    /// Class for working with technics
    /// </summary>
    public class Technics : Product
    {
        /// <summary>
        /// Constructor to initialize a technics.
        /// </summary>
        /// <param name="type">Product type</param>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price</param>
        public Technics(string type, string name, decimal price) : base(type, name, price)
        {
        }

        /// <summary>
        /// Overriding the operator + to add technics.
        /// </summary>
        /// <param name="technics1">First technics</param>
        /// <param name="technics2">Second technics</param>
        /// <returns>Technics</returns>
        public static Technics operator +(Technics technics1, Technics technics2)
        {
            return new Technics(technics1.Type, string.Format($"{technics1.Name}-{technics2.Name}"), (technics1.Price + technics2.Price) / 2);
        }

        /// <summary>
        /// Overriding the operator to convert technics to food.
        /// </summary>
        /// <param name="technics">Technics for converting</param>
        public static explicit operator Food(Technics technics)
        {
            return new Food(technics.Type, technics.Name, technics.Price);
        }

        /// <summary>
        /// Overriding the operator to convert technics to furniture.
        /// </summary>
        /// <param name="technics">Technics for converting</param>
        public static explicit operator Furniture(Technics technics)
        {
            return new Furniture(technics.Type, technics.Name, technics.Price);
        }

        /// <summary>
        /// Overriding the operator to convert technics to Int32.
        /// </summary>
        /// <param name="technics">Technics for converting</param>
        public static explicit operator int(Technics technics)
        {
            return (int)(technics.Price * 100);
        }

        /// <summary>
        /// Overriding the operator to convert technics to decimal.
        /// </summary>
        /// <param name="technics">Technics for converting</param>
        public static explicit operator decimal(Technics technics)
        {
            return technics.Price;
        }

        /// <summary>
        /// Method for equal the current object with the specified object.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Technics))
            {
                return false;
            }

            Technics technics = (Technics)obj;

            return ((_type == technics.Type) && (_name == technics.Name) && (_price == technics.Price));
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return (_name.GetHashCode() ^ (_type.GetHashCode() ^ 2) ^ (_price.GetHashCode() ^ 3));
        }
    }
}
