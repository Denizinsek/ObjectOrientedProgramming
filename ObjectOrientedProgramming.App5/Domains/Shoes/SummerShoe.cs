namespace ObjectOrientedProgramming.App5.Domains.Shoes
{
    internal class SummerShoe : Shoe
    {
        public override int Raise(int price, string brand)
        {
            return base.Raise(price, brand);
        }

        public override int Discount(int price, string brand)
        {
            if (brand == "Bambi")
            {
                price -= price * 50 / 100;
            }
            else
            {
                price -= price * 20 / 100;
            }
            return price;
        }

        public override void Gift(string brand, string model)
        {
            base.Gift(brand, model);
        }
    }
}
