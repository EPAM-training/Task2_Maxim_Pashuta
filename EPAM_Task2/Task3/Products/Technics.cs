namespace EPAM_Task2.Task3.Products
{
    public class Technics : Product
    {
        public Technics(string type, string name, decimal price) : base(type, name, price)
        {
        }

        public static Technics operator +(Technics technics1, Technics technics2)
        {
            return new Technics(technics1.Type, string.Format($"{technics1.Name}-{technics2.Name}"), (technics1.Price + technics2.Price) / 2);
        }

        public static explicit operator Food(Technics technics)
        {
            return new Food(technics.Type, technics.Name, technics.Price);
        }

        public static explicit operator Furniture(Technics technics)
        {
            return new Furniture(technics.Type, technics.Name, technics.Price);
        }

        public static explicit operator int(Technics technics)
        {
            return (int)(technics.Price * 100);
        }

        public static explicit operator decimal(Technics technics)
        {
            return technics.Price;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Technics))
            {
                return false;
            }

            Technics technics = (Technics)obj;

            return (_type == technics.Type && _name == technics.Name && _price == technics.Price);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() + _type.GetHashCode() * 2 + _price.GetHashCode() * 3;
        }
    }
}
