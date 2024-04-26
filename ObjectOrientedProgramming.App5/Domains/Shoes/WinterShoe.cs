using System;

namespace ObjectOrientedProgramming.App5.Domains.Shoes
{
    internal class WinterShoe : Shoe
    {
        public string Feature;

        public override int Discount(int price, string brand)
        {
            return base.Discount(price, brand);
        }

        public override void Gift(string brand, string model)
        {
            base.Gift(brand, model);
            Console.WriteLine("Temizleme suyu hediyeli");
        }
    }
}
