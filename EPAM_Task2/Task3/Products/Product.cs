namespace EPAM_Task2.Task3.Products
{
    /// <summary>
    /// Class for working with product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// A field for storing the product type.
        /// </summary>
        protected readonly string _type;
        /// <summary>
        /// A field for storing the product name.
        /// </summary>
        protected readonly string _name;
        /// <summary>
        /// A field for storing the price.
        /// </summary>
        protected readonly decimal _price;

        /// <summary>
        /// Constructor to initialize a product.
        /// </summary>
        /// <param name="type">Product type</param>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price</param>
        public Product(string type, string name, decimal price)
        {
            _type = type;
            _name = name;
            _price = price;
        }

        /// <summary>
        /// Property returning a product type.
        /// </summary>
        public string Type => _type;

        /// <summary>
        /// Property returning a product name.
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// Property returning a price.
        /// </summary>
        public decimal Price => _price;

        /// <summary>
        /// The method creates and returns a string representation of the object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return string.Format($"Name: {_name}\n" +
                                 $"Type: {_type}\n" +
                                 $"Price: {_price}");
        }
    }
}
