using System;

namespace ObjectOrientedProgramming.App5.Domains.Shoes
{
    internal class Shoe // Ana class base class
    {
        public int price;
        public string brand;
        public string model;

        public virtual int Raise(int price, string brand)
        {
            if (brand == "Adidas" || brand == "Puma")
            {
                price += price * 20 / 100;
            }
            else
            {
                price += price * 15 / 100;
            }
            return price;
        }

        public virtual int Discount(int price, string brand)
        {
            if (brand == "Nike")
            {
                price -= price * 20 / 100;
            }
            else
            {
                price -= price * 10 / 100;
            }
            return price;
        }

        public virtual void Gift(string brand, string model)
        {
            if (brand == "Nike" && model == "Yürüyüş")
            {
                Console.WriteLine("Temizleme bezi hediyeli");
            }
        }
        public void GetInformation()
        {
            Console.WriteLine("Fiyat Giriniz: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marka Giriniz: ");
            brand = Console.ReadLine();
            Console.WriteLine("Model Giriniz: ");
            model = Console.ReadLine();

            Console.WriteLine("Fiyat: " + price);
            Console.WriteLine("Marka: " + brand);
            Console.WriteLine("Model: " + model);
        }

    }
}
