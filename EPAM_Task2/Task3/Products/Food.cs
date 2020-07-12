namespace EPAM_Task2.Task3.Products
{
    public class Food : Product
    {
        public Food(string type, string name, decimal price) : base(type, name, price)
        {
        }

        public static Food operator +(Food food1, Food food2)
        {
            return new Food(food1.Type, string.Format($"{food1.Name}-{food2.Name}"), (food1.Price + food2.Price) / 2);
        }

        public static explicit operator Technics(Food food)
        {
            return new Technics(food.Type, food.Name, food.Price);
        }

        public static explicit operator Furniture(Food food)
        {
            return new Furniture(food.Type, food.Name, food.Price);
        }

        public static explicit operator int(Food food)
        {
            return (int)(food.Price * 100);
        }

        public static explicit operator decimal(Food food)
        {
            return food.Price;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Food))
            {
                return false;
            }

            Food food = (Food)obj;

            return (_type == food.Type && _name == food.Name && _price == food.Price);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() * 11 + _type.GetHashCode() * 12 + _price.GetHashCode() * 13;
        }
    }
}
