using ObjectOrientedProgramming.App5.Domains.Shoes;
using System;

namespace ObjectOrientedProgramming.App5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1)Kışlık \n 2)Yazlık");
            byte choice = Convert.ToByte(Console.ReadLine());
            if (choice == 1)
            {
                WinterShoe winterShoe = new WinterShoe();
                Console.WriteLine("Özelliği: ");
                winterShoe.Feature = Console.ReadLine();
                winterShoe.GetInformation();
                Console.WriteLine("Özelliği: " + winterShoe.Feature);
                int result = winterShoe.Discount(winterShoe.price, winterShoe.brand);
                Console.WriteLine("İndirimli Fiyat: " + result);
                winterShoe.Gift(winterShoe.brand, winterShoe.model);
            }
            else
            {
                SummerShoe summerShoe = new SummerShoe();
                summerShoe.GetInformation();
                Console.WriteLine("İndirimli Fiyat: " + summerShoe.Discount(summerShoe.price, summerShoe.brand));
                Console.WriteLine("Zamlı Fiyat: " + summerShoe.Raise(summerShoe.price, summerShoe.brand));
                summerShoe.Gift(summerShoe.brand, summerShoe.model);
            }
            Console.ReadLine();
        }
    }
}
