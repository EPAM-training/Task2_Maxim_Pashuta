namespace EPAM_Task2.Task3.Products
{
    public class Furniture : Product
    {
        public Furniture(string type, string name, decimal price) : base(type, name, price)
        {
        }

        public static Furniture operator +(Furniture furniture1, Furniture furniture2)
        {
            return new Furniture(furniture1.Type, string.Format($"{furniture1.Name}-{furniture2.Name}"), (furniture1.Price + furniture2.Price) / 2);
        }

        public static explicit operator Technics(Furniture furniture)
        {
            return new Technics(furniture.Type, furniture.Name, furniture.Price);
        }

        public static explicit operator Food(Furniture furniture)
        {
            return new Food(furniture.Type, furniture.Name, furniture.Price);
        }

        public static explicit operator int(Furniture furniture)
        {
            return (int)(furniture.Price * 100);
        }

        public static explicit operator decimal(Furniture furniture)
        {
            return furniture.Price;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Furniture))
            {
                return false;
            }

            Furniture furniture = (Furniture)obj;

            return (_type == furniture.Type && _name == furniture.Name && _price == furniture.Price);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() * 11 + _type.GetHashCode() * 12 + _price.GetHashCode() * 13;
        }
    }
}
