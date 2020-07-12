namespace EPAM_Task2.Task3.Products
{
    public class Product
    {
        protected readonly string _type;
        protected readonly string _name;
        protected readonly decimal _price;

        public Product(string type, string name, decimal price)
        {
            _type = type;
            _name = name;
            _price = price;
        }

        public string Type => _type;

        public string Name => _name;

        public decimal Price => _price;

        public override string ToString()
        {
            return string.Format($"Name: {_name}\n" +
                                 $"Type: {_type}\n" +
                                 $"Price: {_price}");
        }
    }
}
